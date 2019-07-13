using System;
using System.Collections.Generic;
using BoostSharp.Universal;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    public partial class ReviewCell : ContentView
    {
        public Review Review { get; set; }

        public ReviewCell(Review review)
        {
            Review = review;
            InitializeComponent();
            BindingContext = this;
        }
    }
}
