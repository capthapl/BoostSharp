using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BoostSharp.Universal;
using FreshMvvm;
using Xamarin.Forms;

namespace BoostSharp.PageModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class HomePageModel : FreshBasePageModel
    {
        public ICommand OpenProfilePage
        {
            get;
            set;
        }

        public ObservableCollection<BoosterOfferCardModel> Boosters
        {
            get;
            set;
        }
        private ObservableCollection<BoosterOfferCardModel> _visibleBoosters;
        public ObservableCollection<BoosterOfferCardModel> VisibleBoosters
        {
            get
            {
                _visibleBoosters = new ObservableCollection<BoosterOfferCardModel>();
                for (int i = (CurrentReviewPage - 1) * MaxItemsInPage; i < CurrentReviewPage * MaxItemsInPage; i++)
                {
                    if (i < Boosters.Count() - 1)
                        _visibleBoosters.Add(Boosters.ElementAt(i));
                }

                return _visibleBoosters;
            }
        }
        public int CurrentReviewPage { get; set; }
        public int MaxItemsInPage { get; set; }
        public ICommand BackReviews { get; set; }
        public ICommand NextReviews { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            CurrentReviewPage = 1;
            MaxItemsInPage = 12;
            BackReviews = new Command(() =>
            {
                if (CurrentReviewPage > 1)
                    CurrentReviewPage--;
            });
            NextReviews = new Command(() =>
            {
                if (CurrentReviewPage * MaxItemsInPage < Boosters.Count())
                    CurrentReviewPage++;
            });
            OpenProfilePage = new Command(() => {
                CoreMethods.PushPageModel<ProfilePageModel>();
            });
            TapGestureRecognizer t = new TapGestureRecognizer();

            //temp
            Boosters = new ObservableCollection<BoosterOfferCardModel>() {
    new BoosterOfferCardModel() {
      Displayname = "Rekurencja",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja1",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja2",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja3",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja4",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja5",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja6",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja7",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja8",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja9",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja6",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja7",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja8",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja9",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     }, new BoosterOfferCardModel() {
      Displayname = "Rekurencja6",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja7",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja8",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja9",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja6",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja7",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja8",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
     new BoosterOfferCardModel() {
      Displayname = "Rekurencja9",
       Email = "capthapl@gmail.com",
       ImageSource = "http://fioextremadura.es/wp-content/uploads/placeholder-blue-800x600px.png"
     },
   };
        }
    }
}