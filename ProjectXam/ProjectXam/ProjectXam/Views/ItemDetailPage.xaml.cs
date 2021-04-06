using ProjectXam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProjectXam.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}