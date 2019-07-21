using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BoostSharp.Universal
{
    public class BoosterCardModel
    {
        public string Nickname { get; set; }
        public ObservableCollection<Image> ServiceIcons { get; set; }

        public BoosterCardModel()
        {
            var img = new Image();
            img.Source = "eloboostingicon";
            img.HeightRequest = 50;
            img.WidthRequest = 50;
            img.BackgroundColor = Color.Red;
            img.HorizontalOptions = LayoutOptions.FillAndExpand;
            ServiceIcons = new ObservableCollection<Image>()
            {
               img
            };
        }
    }
}
