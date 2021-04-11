using Newtonsoft.Json;
using ProjetXam.Models;
using ProjetXam.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjetXam.ViewModels
{
    class MenusViewModel : BaseViewModel
    {
        ObservableCollection<Menu> menus = new ObservableCollection<Menu>();
        Menu menuSelected;

        public Menu MenuSelected
        {
            get { return menuSelected; }
            set { SetProperty(ref menuSelected, value); }
        }

        public ObservableCollection<Menu> Menus
        {
            get { return menus; }
            set { SetProperty(ref menus, value); }
        }

        public MenusViewModel()
        {
            _ = getMenusApi();
        }

        private async Task getMenusApi()
        {
            var client = HttpService.getInstance();
            var result = await client.GetAsync("https://raw.githubusercontent.com/Guillaume2304/lp-dam-x-btvv/main/menu2.json");
            var serializedResponse = await result.Content.ReadAsStringAsync();
            Menus = JsonConvert.DeserializeObject<ObservableCollection<Menu>>(serializedResponse);
        }

        
    }
}
