using PosTrabalhoXamarin.ViewModels;
using PosTrabalhoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PosTrabalhoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCadastroCliente : ContentPage
    {
       

        public PageCadastroCliente()
        {
            InitializeComponent();
            BindingContext = new ClienteViewModel();
        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListaCliente());
        }
    }
}