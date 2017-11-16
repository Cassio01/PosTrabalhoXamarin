using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PosTrabalhoXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PosTrabalhoXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageListaCliente : ContentPage
	{
		public PageListaCliente ()
		{
			InitializeComponent ();
            BindingContext = new ClienteViewModel();
        }
	}
}