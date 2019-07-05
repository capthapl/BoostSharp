using System;

using Xamarin.Forms;
namespace BoostSharp.CustomControls.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class SectionViewModel
    {
        public string Title { get; set; }
    }
}

