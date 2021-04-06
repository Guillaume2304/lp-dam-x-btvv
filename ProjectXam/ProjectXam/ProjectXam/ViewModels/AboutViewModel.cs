using ProjectXam.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProjectXam.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Accueil";
            OpenWebCommand = new Command(async () => await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}"));
        }

        public ICommand OpenWebCommand { get; }
    }
}