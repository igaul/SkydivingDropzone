using System;
using System.Collections.Generic;
using SQLite;
using Dropzone.Model;
using Xamarin.Forms;

namespace Dropzone
{
    public partial class JumpDetailPage : ContentPage
    {
        PostJump selectedJump;

        //reassign value
        public JumpDetailPage(PostJump selectedJump)
        {
            InitializeComponent();
            this.selectedJump = selectedJump;

            //jumpNumber.Text = selectedJump.JumpNumber;
            date.Text = selectedJump.Date;
            place.Text = selectedJump.Place;
            aircraft.Text = selectedJump.Aircraft;
            equipment.Text = selectedJump.Equipment;
            freeFallTime.Text = selectedJump.FreeFallTime;
            flyingType.Text = selectedJump.FlyingType;
        }

        //To edit a specific jump after clicked that jump in logbook
        void UpdateButton_Clicked(object sender, System.EventArgs e)
        {
            //selectedJump.JumpNumber = jumpNumber.Text;
            selectedJump.Date = date.Text;
            selectedJump.Place = place.Text;
            selectedJump.Aircraft = aircraft.Text;
            selectedJump.Equipment = equipment.Text;
            selectedJump.FreeFallTime = freeFallTime.Text;
            selectedJump.FlyingType = flyingType.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<PostJump>();
                int rows = connection.Update(selectedJump);

                if (rows > 0)
                    DisplayAlert("Success", "This jumps has been updated.", "OK");
                else
                    DisplayAlert("Failed", "This jump was not updated.", "OK");

                Navigation.PopAsync();
            }
        }

        //To Delete a specific jump
        void DeleteButton_Clicked(object sender, System.EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<PostJump>();
                int rows = connection.Delete(selectedJump);

                if (rows > 0)
                    DisplayAlert("Success", "This jumps has been deleted.", "OK");
                else
                    DisplayAlert("Failed", "This jump was not removed.", "OK");

                Navigation.PopAsync();
            }
        }
    }
}
