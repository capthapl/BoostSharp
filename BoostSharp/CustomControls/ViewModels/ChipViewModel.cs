using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ChipViewModel
    {
        public bool Clicked { get; set; }
        public Color FillColor
        {
            get
            {
                if (Clicked)
                    return (Color)Application.Current.Resources["MainBlue"];
                return (Color)Application.Current.Resources["SoftBlue"];
            }
        }

        public ICommand TapContainer { get; set; }

        public string Text { get; set; }

        public ChipViewModel()
        {
            TapContainer = new Command(()=>
            {
                Clicked = !Clicked;
            });
        }
    }
}

