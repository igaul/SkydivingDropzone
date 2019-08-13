using Dropzone.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dropzone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddJumpPage : ContentPage
    {


        public AddJumpPage()
        {
            InitializeComponent();
        }

        private void CmdSave_Clicked(object sender, EventArgs e)
        {
            PostJump post = new PostJump()
            {
                Date = date.Text,
                Place = place.Text,
                Aircraft = aircraft.Text,
                Equipment = equipment.Text,
                FreeFallTime = freeFallTime.Text,
                FlyingType = flyingType.Text
               
            };
           using ( SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation)){
                connection.CreateTable<PostJump>();
                int rows = connection.Insert(post);

                if (rows > 0)
                {
                    DisplayAlert("Saved", "Jump saved", "Ok");
                }
                else
                {
                    DisplayAlert("Not saved", "Jump not saved", "Ok");
                }
            }
            // reload logbook page
            Navigation.PopAsync();
        }

        private void CmdCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}