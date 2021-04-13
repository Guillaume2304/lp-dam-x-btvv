using ProjetXam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPlatPage : ContentPage
    {
        public DetailPlatPage(Models.Menu menuSelected)
        {
            InitializeComponent();
            BindingContext = new DetailPlatViewModel(menuSelected);
        }
    }
}