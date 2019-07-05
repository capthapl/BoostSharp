using System;
using System.Collections.Generic;
using BoostSharp.CustomControls.ViewModels;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    [ContentProperty("VisibleChildren")]
    public partial class Section : ContentView
    {
        public StackLayout VisibleLayout { get; set; }

        public IList<View> VisibleChildren => VisibleLayout.Children;

        public SectionViewModel SectionViewModel { get; set; }

        public string Title
        {
            get
            {
                return SectionViewModel.Title;
            }
            set
            {
                SectionViewModel.Title = value;
            }
        }

        public Section()
        {
            InitializeComponent();
            SectionViewModel = new SectionViewModel();
            VisibleLayout = content;
            BindingContext = SectionViewModel;
        }
    }
}
