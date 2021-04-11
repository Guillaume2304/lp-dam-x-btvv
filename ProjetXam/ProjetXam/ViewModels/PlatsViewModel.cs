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
    class PlatsViewModel : BaseViewModel
    {
        ObservableCollection<Menu> menus = new ObservableCollection<Menu>();
        string menuSelected;
        Menu menu = new Menu();

        public ObservableCollection<Menu> Menus
        {
            get { return menus; }
            set { SetProperty(ref menus, value); }
        }

        public Menu Menu
        {
            get { return menu; }
            set { SetProperty(ref menu, value); }
        }

        public PlatsViewModel(string menuSelected)
        {
            this.menuSelected = menuSelected.ToLower();
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
                if(menu.Type == menuSelected)
                {
                    Menus.Add(menu);
                }
            }
        }
    }
}
