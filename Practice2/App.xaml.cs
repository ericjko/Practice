using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practice2.Data;
using System.IO;

namespace Practice2
{
    public partial class App : Application
    {
        static VehicleDatabase database;
        

        public static VehicleDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new VehicleDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        
     
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VehicleList());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
