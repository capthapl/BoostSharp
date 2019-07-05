using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {
        public ICommand OpenProfilePage { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            OpenProfilePage = new Command(() =>
            {
                CoreMethods.PushPageModel<ProfilePageModel>();
            });
            TapGestureRecognizer t = new TapGestureRecognizer();
        }
    }
}
