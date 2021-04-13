using ProjetXam.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetXam.Views
{
    public partial class MenusPage : ContentPage
    {
        public MenusPage()
        {
            InitializeComponent();
            BindingContext = new MenusViewModel();
        }
    }
}
