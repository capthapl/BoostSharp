using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using BoostSharp.CustomControls;
using BoostSharp.Universal;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ReviewsPageModel : FreshMvvm.FreshBasePageModel
    {
        public ICommand PopCommand { get; set; }
        public int CurrentReviewPage { get; set; }
        public int MaxItemsInPage { get; set; }
        public ObservableCollection<Review> Reviews { get; set; }
        public ICommand BackReviews { get; set; }
        public ICommand NextReviews { get; set; }
        public string ReviewsDisplayCount
        {
            get
            {
                return Reviews.Count() + " opinii";
            }
        }
        private ObservableCollection<Review> _visibleReviews;
        public ObservableCollection<Review> VisibleReviews {
            get
            {
                _visibleReviews = new ObservableCollection<Review>();
                for (int i = (CurrentReviewPage-1)*MaxItemsInPage; i < CurrentReviewPage * MaxItemsInPage; i++)
                {
                        if (i < Reviews.Count()-1)
                            _visibleReviews.Add(Reviews.ElementAt(i));
                }

                return _visibleReviews;
            }
        }

        public ReviewsPageModel()
        {
            Reviews = new ObservableCollection<Review>();
            PopCommand = new Command(() => CoreMethods.PopPageModel(this));
            MaxItemsInPage = 8;
            BackReviews = new Command(() =>
            {
                if (CurrentReviewPage > 1)
                    CurrentReviewPage--;
            });
            NextReviews = new Command(() =>
            {
                if (CurrentReviewPage*MaxItemsInPage < Reviews.Count())
                    CurrentReviewPage++;
            });

            for (int i = 0; i < 35; i++)
            {
                Reviews.Add(GetRandomReview());
            }
        }

        private Review GetRandomReview()
        {
            CurrentReviewPage = 1;
            Review r = new Review()
            {
                Description = DateTime.Now.GetHashCode().ToString(),
                DisplayNameOwner = "Rekurencja",
                EmailOwner = "capthapl@gmail.com",
                ReviewType = EReviewType.positive
            };
            return r;
        }
    }
}
