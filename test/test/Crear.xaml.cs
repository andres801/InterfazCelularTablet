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
    public partial class Crear : ContentPage
    {
        public Crear()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private async void buttonReturn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}