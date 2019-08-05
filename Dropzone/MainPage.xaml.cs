using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dropzone
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = $"Logging in...";
            // todo log in validation
            // todo post log in page
            // todo log in error page
            // todo set up account page
            Navigation.PushAsync(new HomePage());
            // todo prevent back nav to login page
        }
    }
}
