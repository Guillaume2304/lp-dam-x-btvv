using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetXam.ViewModels
{
    class LivraisonViewModel : BaseViewModel
    {

        string adressEntered;
        string nameEntered;
        string firstNameEntered;

        public LivraisonViewModel() {
            try { 
            adressEntered = Application.Current.Properties["adresse"].ToString();
            nameEntered = Application.Current.Properties["name"].ToString();
            firstNameEntered = Application.Current.Properties["firstName"].ToString();
            }
            catch
            {
                Application.Current.Properties["adresse"] = adressEntered;
                Application.Current.Properties["name"] = nameEntered;
                Application.Current.Properties["firstName"] = firstNameEntered;
                Application.Current.SavePropertiesAsync();

            }
        }
        public string AdressEntered
        {
            get
            {
                return adressEntered;
            }
               
            set
            {
                SetProperty(ref adressEntered, value);
            }
               
        }
        public string NameEntered
        {
            get { return nameEntered; }
            set
            {
                SetProperty(ref nameEntered, value);                
            }
        }
        public string FirstNameEntered
        {
            get { return firstNameEntered; }
            set
            {
                SetProperty(ref firstNameEntered, value);              
            }
        }

        public ICommand SaveData
        {
            get { return new Command(onValidate); }
        }
        void onValidate()
        {
            Application.Current.Properties["adresse"] = AdressEntered;
            Application.Current.Properties["name"] = NameEntered;
            Application.Current.Properties["firstName"] = FirstNameEntered;
            Application.Current.SavePropertiesAsync();
        }   
    }
}
