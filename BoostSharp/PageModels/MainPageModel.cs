using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public ICommand OpenHomePageCommand { get; set; }
        public override void Init(object initData)
        {
            base.Init(initData);
            OpenHomePageCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<HomePageModel>();
            });
        }
    }
}
