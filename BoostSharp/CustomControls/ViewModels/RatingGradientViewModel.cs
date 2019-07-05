using System;
using Xamarin.Forms;

namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class RatingGradientViewModel
    {
        public Thickness IndicatorMarginPosition { get; set; }
    }
}
