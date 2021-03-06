﻿using Dropzone.Model;
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
    public partial class LogbookPage : ContentPage
    {
        public LogbookPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<PostJump>();
                var jumps = connection.Table<PostJump>().ToList();
                jumpsListView.ItemsSource = jumps;
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddJumpPage());

        }

        void Process_JumpSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedJump = jumpsListView.SelectedItem as PostJump;

            if(selectedJump != null)
            {
                Navigation.PushAsync(new JumpDetailPage(selectedJump));
            }
        }
    }
}