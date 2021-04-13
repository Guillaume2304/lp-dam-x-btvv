using Menu = ProjetXam.Models.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjetXam.ViewModels
{
    class DetailPlatViewModel : BaseViewModel
    {
        string nom;
        string type;
        string description;
        string image;

        public string Nom
        {
            get { return nom; }
            set { SetProperty(ref nom, value); }
        }
        public string Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }
        public DetailPlatViewModel(Menu menuSelected)
        {
            Nom = menuSelected.Name;
            Type = menuSelected.Type;
            Description = menuSelected.Description;
            Image = menuSelected.Image;
        }
    }
}