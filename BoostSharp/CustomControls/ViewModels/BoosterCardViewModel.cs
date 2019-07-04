using System;
using Xamarin.Forms;

namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class BoosterCardViewModel 
    {
        public Uri ImageSource { get; set; }
    }
}

