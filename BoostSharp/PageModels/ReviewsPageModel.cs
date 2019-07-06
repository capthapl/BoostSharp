using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    public class ReviewsPageModel : FreshMvvm.FreshBasePageModel
    {
        public ICommand PopCommand { get; set; }
        public ReviewsPageModel()
        {
            PopCommand = new Command(async () =>
            {
                await CoreMethods.PopPageModel(this);
            });
        }
    }
}
