using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        // Invoked when the button is clicked
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}
