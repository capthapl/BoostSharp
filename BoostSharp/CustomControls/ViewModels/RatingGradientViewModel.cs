using System;
using Xamarin.Forms;

namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class RatingGradientViewModel
    {
        public Thickness IndicatorMarginPosition { get; set; }
        public string RatingText { get; set; }
        public Thickness TextMarginPosition
        {
            get
            {
                var indicatorMargin = IndicatorMarginPosition;
                indicatorMargin.Left -= 6;
                if (indicatorMargin.Left < 0)
                    indicatorMargin.Left = 0;
                return indicatorMargin;
            }
        }

    }
}
