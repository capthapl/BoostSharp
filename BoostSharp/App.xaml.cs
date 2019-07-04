using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Auth;
using Microsoft.AppCenter;
using BoostSharp.PageModels;

namespace BoostSharp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var defaultPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ProfilePageModel>();
            var navigationContainer = new FreshMvvm.FreshNavigationContainer(defaultPage);
            MainPage = navigationContainer;
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=feb09ce2-4c16-4987-b14c-5de5a9176d81;",typeof(Analytics), typeof(Crashes), typeof(Auth));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
