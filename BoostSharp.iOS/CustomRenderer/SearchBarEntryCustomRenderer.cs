using System;
using BoostSharp.CustomControls;
using BoostSharp.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchBarEntry), typeof(SearchBarEntryCustomRenderer))]
namespace BoostSharp.iOS.CustomRenderer
{
    public class SearchBarEntryCustomRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Layer.BackgroundColor = UIKit.UIColor.FromRGBA(0, 0, 0, 0).CGColor;
            Control.BorderStyle = UIKit.UITextBorderStyle.None;
        }
    }
}
