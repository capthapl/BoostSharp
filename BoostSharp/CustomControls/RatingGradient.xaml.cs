using System;
using System.Collections.Generic;
using BoostSharp.CustomControls.ViewModels;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public partial class RatingGradient : ContentView
    {
        RatingGradientViewModel RatingGradientViewModel { get; set; }

        private double _ratingInPercent;
        public double RatingInPercent
        {
            get
            {
                return _ratingInPercent;
            }
            set
            {
                _ratingInPercent = value;
                InvalidateLayout();
            }
        }
    
        public RatingGradient()
        {
            InitializeComponent();
            RatingGradientViewModel = new RatingGradientViewModel();
            BindingContext = RatingGradientViewModel;
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            double marginLeft = ((widthConstraint / 100) * RatingInPercent);
            if (marginLeft < 0) marginLeft = 0;
            RatingGradientViewModel.IndicatorMarginPosition = new Thickness(marginLeft, 0, 0, 0);
            RatingGradientViewModel.RatingText = RatingInPercent.ToString();
            return base.OnMeasure(widthConstraint, heightConstraint);
        }
    }
}
