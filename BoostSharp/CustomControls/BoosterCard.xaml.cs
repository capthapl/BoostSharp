using System;
using System.Collections.Generic;
using BoostSharp.CustomControls.ViewModels;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    public partial class BoosterCard : ContentView
    {
        public BoosterCardViewModel BoosterCardViewModel { get; set; }

        private string _imageSource;
        public string ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                BoosterCardViewModel.ImageSource = new Uri(_imageSource);
            }
        }

        public BoosterCard()
        {
            InitializeComponent();
            BoosterCardViewModel = new BoosterCardViewModel();
            BindingContext = BoosterCardViewModel;

        }
    }
}
