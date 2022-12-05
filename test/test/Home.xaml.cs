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
    public partial class Home : ContentPage
    {
        public Home()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepCountPage());
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepCountPage());
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crear());
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crear());
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}