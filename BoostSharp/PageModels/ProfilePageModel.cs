using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    class ProfilePageModel : FreshBasePageModel
    {
        public ICommand PopCommand { get; set; }
        public ICommand ShowCommentsCommand { get; set; }
        public ProfilePageModel()
        {
            PopCommand = new Command(async () =>
            {
                await CoreMethods.PopPageModel(this);
            });

            ShowCommentsCommand = new Command(async () =>
            {
                await CoreMethods.PushPageModel<ReviewsPageModel>();
            });
        }
    }
}
