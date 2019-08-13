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
    public partial class ModifyProfilePage : ContentPage
    {
        public ModifyProfilePage()
        {
            InitializeComponent();
        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            
            // reload logbook page
            Navigation.PopAsync();
        }
    }
}