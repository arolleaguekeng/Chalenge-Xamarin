using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace devoirXamaarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoardinPage : ContentPage
    {
        public OnBoardinPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await FadeBox.FadeTo(1, 1000);
            await Navigation.PopModalAsync(false);
        }
    }
}