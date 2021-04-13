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
    public partial class PlatsPage : ContentPage
    {
        public PlatsPage(string typeMenuSelected)
        {
            InitializeComponent();
            BindingContext = new PlatsViewModel(typeMenuSelected);
        }
    }
}