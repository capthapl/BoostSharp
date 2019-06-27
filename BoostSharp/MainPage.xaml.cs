using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Auth;
using Xamarin.Forms;

namespace BoostSharp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Auth.SignOut();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            { 
                // Sign-in succeeded, UserInformation is not null.
                UserInformation userInfo = await Auth.SignInAsync();
               

                // Do work with either token.
            }
            catch (Exception ex)
            {
                // Do something with sign-in failure.
            }
        }


    }
}
