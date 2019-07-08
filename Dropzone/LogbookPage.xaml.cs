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

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            // todo add entry to db
            Navigation.PushAsync(new AddJumpPage());

        }
    }
}