using System;
using System.Collections.Generic;
using System.Windows.Input;
using BoostSharp.CustomControls.ViewModels;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    public partial class Chip : ContentView
    {
        public ChipViewModel ChipViewModel { get; set; }

        public ICommand OnClick {
            get{
                return ChipViewModel.TapContainer;
            }
            set
            {
                ChipViewModel.TapContainer = value;
            }
        }

        public string Text
        {
            get
            {
                return ChipViewModel.Text;
            }
            set
            {
                ChipViewModel.Text = value;
            }
        }

        public Chip()
        {
            ChipViewModel = new ChipViewModel();
            InitializeComponent();
            BindingContext = ChipViewModel;
        }
    }
}
