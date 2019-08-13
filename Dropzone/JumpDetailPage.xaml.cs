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

        public JumpDetailPage(PostJump selectedJump)
        {
            InitializeComponent();
            this.selectedJump = selectedJump;
            

        }

        void UpdateButton_Clicked(object sender, System.EventArgs e)
        {
            
        }
        void DeleteButton_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
