using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BoostSharp.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void OpenCloseFilter(object sender, EventArgs e)
        {
            _filter.IsVisible = !_filter.IsVisible;
            _boosters.IsVisible = !_boosters.IsVisible;
        }
    }
}
