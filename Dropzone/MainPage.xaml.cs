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

        //jump to map page 
        private void Map_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new DropMap());
        }

        //Jump to weather page 
        private void Weather_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WeatherPage());
        }

        //to logbook page
        private void Logbook_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogbookPage());
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
    }
}
