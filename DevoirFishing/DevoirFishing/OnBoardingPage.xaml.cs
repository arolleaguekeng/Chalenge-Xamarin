using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevoirFishing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoardingPage : ContentPage
    {
        public OnBoardingPage()
        {
            InitializeComponent();
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            myRadialgradient.RadiusX = width * 6;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await FadeBox.FadeTo(1, 1000);
            await Navigation.PopModalAsync(false);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //myRadialgradient.RadiusX = this.Width * e.NewValue;
        }

    }
}