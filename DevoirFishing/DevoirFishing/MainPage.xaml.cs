using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DevoirFishing
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        OnBoardingPage onboarding;
        public MainPage()
        {
            InitializeComponent();
            if (ShouldShowOnboading() == true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                onboarding = new OnBoardingPage();
                Navigation.PushModalAsync(onboarding, false);
            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == onboarding)
            {
                FadeBox.FadeTo(0, 1000);
                onboarding = null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool ShouldShowOnboading()
        {
            return true;
        }
    }
}
