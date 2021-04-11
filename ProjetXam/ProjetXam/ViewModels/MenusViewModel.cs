using Newtonsoft.Json;
using ProjetXam.Models;
using ProjetXam.Services;
using ProjetXam.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetXam.ViewModels
{
    class MenusViewModel : BaseViewModel
    {
        ObservableCollection<Models.Menu> menus = new ObservableCollection<Models.Menu>();

        ObservableCollection<string> typeMenus = new ObservableCollection<string>();
        string menuSelected;

        public string MenuSelected
        {
            get { return menuSelected; }
            set { 
                SetProperty(ref menuSelected, value);
                if(value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new PlatsPage(MenuSelected));
                        MenuSelected = null;
                    });
                }
            }
        }

        public ObservableCollection<string> TypeMenus
        {
            get { return typeMenus; }
            set { SetProperty(ref typeMenus, value); }
        }

        public MenusViewModel()
        {
            TypeMenus.Add("Burger");
            TypeMenus.Add("Pizza");
            TypeMenus.Add("Tacos");
            TypeMenus.Add("Panini");
        }
    }
}
