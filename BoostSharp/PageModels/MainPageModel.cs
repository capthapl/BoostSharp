using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public ICommand OpenHomePageCommand { get; set; }
        public ICommand OpenTermsCommand { get; set; }
        public override void Init(object initData)
        {
            base.Init(initData);
            OpenHomePageCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<HomePageModel>();
            });
            TapGestureRecognizer t = new TapGestureRecognizer();

            OpenTermsCommand = new Command(() =>
            {
                Device.OpenUri(new Uri(@"https://firebasestorage.googleapis.com/v0/b/poc-files.appspot.com/o/Polityka%20BoostSharp.pdf?alt=media&token=61c70183-6cf3-4802-84b7-13946070a660"));
            });
        }
    }
}
