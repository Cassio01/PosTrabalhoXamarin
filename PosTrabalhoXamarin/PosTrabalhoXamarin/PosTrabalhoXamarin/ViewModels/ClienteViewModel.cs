using PosTrabalhoXamarin.Models;
using PosTrabalhoXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace PosTrabalhoXamarin.ViewModels
{
    class ClienteViewModel : INotifyPropertyChanged
    {
        public Cliente ClienteAtual { get; set; }
        public Command SalvarClienteCommand { get; set; }
        public Command ExcluirClienteCommand { get; set; }
        public Command EditarClienteCommand { get; set; }
        public ObservableCollection<Cliente> Clientes { get; set; }

        public ClienteViewModel()
        {
            ClienteAtual = new Cliente();
            Clientes = new ObservableCollection<Cliente>(new ClienteRepository().Listar());

            SalvarClienteCommand = new Command(Salvar);
            ExcluirClienteCommand = new Command<Cliente>(ExcluirCliente);
            EditarClienteCommand = new Command<Cliente>(EditarCliente);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Salvar(object sender)
        {
            using (var dados = new ClienteRepository())
            {
                if (ClienteAtual.Id == 0)
                {
                    new ClienteRepository().Insert(ClienteAtual);
                    Clientes.Add(ClienteAtual);
                    ClienteAtual = new Cliente();
                    OnPropertyChanged("ClienteAtual");
                   
                }
                else
                {
                    new ClienteRepository().Update(ClienteAtual);
                    Clientes = new ObservableCollection<Cliente>(new ClienteRepository().Listar());
                    OnPropertyChanged("Clientes");
                    ClienteAtual = new Cliente();
                    OnPropertyChanged("ClienteAtual");
                }
                
            }
        }


        private void ExcluirCliente(Cliente cliente)
        {
            new ClienteRepository().Delete(cliente);
            Clientes.Remove(cliente);
        }

        private void EditarCliente(Cliente cliente)
        {
            ClienteAtual = cliente;
            OnPropertyChanged("ClienteAtual");
        }
    }
}
