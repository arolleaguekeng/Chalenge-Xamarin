using DevoirFishing.Models;
using MvvmHelpers;

namespace DevoirFishing.ViewModels
{
    public class OnboardingViewModel : BaseViewModel
    {
        private ObservableRangeCollection<OnboardingModel> items;
        public ObservableRangeCollection<OnboardingModel> Items { get => items;
            set => SetProperty(ref items, value);
        }

        public OnboardingViewModel()
        {
            //create our dummy onboarding items
            Items = new ObservableRangeCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Discover nature and pharaon colors",
                    Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." +
                    " Rerum placeat est sed animi. Accusantium ducimus, praesentium " +
                    "voluptates aliquid similique magni perferendis dolore autem, fuga" +
                    " illum, nostrum nulla non. Aut, illo.",
                    Image = ""
                },

                new OnboardingModel
                {
                    Title = "Find my personnal lorem ipsum dolor",
                    Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." +
                    " Rerum placeat est sed animi. Accusantium ducimus, praesentium " +
                    "voluptates aliquid similique magni perferendis dolore autem, fuga" +
                    " illum, nostrum nulla non. Aut, illo.",
                    Image = ""
                },



                new OnboardingModel
                {
                    Title = " Explore cameroun and Bafoussam",
                    Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit." +
                    " Rerum placeat est sed animi. Accusantium ducimus, praesentium " +
                    "voluptates aliquid similique magni perferendis dolore autem, fuga" +
                    " illum, nostrum nulla non. Aut, illo.",
                    Image = ""
                    
                }

            };
        }

    }
}
