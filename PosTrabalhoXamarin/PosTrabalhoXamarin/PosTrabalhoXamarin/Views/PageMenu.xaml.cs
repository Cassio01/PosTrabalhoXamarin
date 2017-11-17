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
    public partial class PageMenu : ContentPage
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCadastroCliente());
        }

        private void ListaCliente_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListaCliente());
        }

        private void SobreApp_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SobreApp());
        }
    }
}