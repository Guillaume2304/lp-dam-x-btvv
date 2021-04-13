using Newtonsoft.Json;
using Menu = ProjetXam.Models.Menu;
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
    class PlatsViewModel : BaseViewModel
    {
        ObservableCollection<Menu> menus = new ObservableCollection<Menu>();
        string typeMenuSelected;
        Menu menuSelected = new Menu();

        public ObservableCollection<Menu> Menus
        {
            get { return menus; }
            set { SetProperty(ref menus, value); }
        }

        public Menu MenuSelected
        {
            get { return menuSelected; }
            set { 
                SetProperty(ref menuSelected, value);
                if(value != null)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new DetailPlatPage(MenuSelected));
                    });
                }
            }
        }

        public PlatsViewModel(string typeMenuSelected)
        {
            this.typeMenuSelected = typeMenuSelected.ToLower();
            _ = getMenusApi();
        }

        private async Task getMenusApi()
        {
            var client = HttpService.getInstance();
            var result = await client.GetAsync("https://raw.githubusercontent.com/Guillaume2304/lp-dam-x-btvv/main/menu2.json");
            var serializedResponse = await result.Content.ReadAsStringAsync();
            ObservableCollection<Menu> menusResponse = JsonConvert.DeserializeObject<ObservableCollection<Menu>>(serializedResponse);
            foreach(Menu menu in menusResponse)
            {
                if(menu.Type == typeMenuSelected)
                {
                    Menus.Add(menu);
                }
            }
        }
    }
}