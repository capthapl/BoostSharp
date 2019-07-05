using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BoostSharp.Universal;
using Xamarin.Forms;

namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class BoosterCardViewModel 
    {
        public Uri ImageSource { get; set; }
    }
}

