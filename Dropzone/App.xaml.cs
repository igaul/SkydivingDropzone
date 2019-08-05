using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dropzone
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            // todo set nav page
            MainPage = new NavigationPage(new MainPage());
        }
        public App (string databaseLocation)
        {
            InitializeComponent();
            // set nav page
            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
            // todo pass db loc string in ios/and
        }
        protected override void OnStart()
        {
            // Handle when your app starts
            // todo

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            // todo
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            //todo
        }
    }
}
