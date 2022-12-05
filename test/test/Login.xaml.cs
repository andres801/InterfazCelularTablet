using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        // Invoked when the button is clicked
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}