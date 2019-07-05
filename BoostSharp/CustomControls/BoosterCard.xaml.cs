using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BoostSharp.CustomControls.ViewModels;
using BoostSharp.Universal;
using Xamarin.Forms;

namespace BoostSharp.CustomControls
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public partial class BoosterCard : ContentView
    {
        public BoosterCardViewModel BoosterCardViewModel { get; set; }

        private ObservableCollection<Image> _serviceIcons;

        public ObservableCollection<Image> ServiceIcons
        {
            get
            {
                return _serviceIcons;
            }
            set
            {
                _serviceIcons = value;
                OnPropertyChanged(nameof(ServiceIcons));
            }
        }

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
            ServiceIcons = new ObservableCollection<Image>();
            BindingContext = this;
        }

        public void AddServices(ObservableCollection<EServiceTypes> list)
        {

            _icons.Children.Clear();
            ServiceIcons.Clear();
            int counter = 0;
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine(item.ToString() + ServiceIcons.Count);
                if (counter == 2 && list.Count > 3)
                {
                    ServiceIcons.Add(CreateIcon("moreicon"));
                    break;

                }
                switch (item)
                {
                    case EServiceTypes.EloBoosting:
                        ServiceIcons.Add(CreateIcon("eloboostingicon"));
                        break;
                    case EServiceTypes.Coaching:
                        ServiceIcons.Add(CreateIcon("coachingicon"));
                        break;
                    case EServiceTypes.MMRBoosting:
                        ServiceIcons.Add(CreateIcon("mmrboostingicon"));
                        break;
                    case EServiceTypes.Custom:
                        ServiceIcons.Add(CreateIcon("email_logo"));
                        break;
                    case EServiceTypes.None:
                    default:
                        throw new NotSupportedException("Ikona usługi nie jest obsługiwana");
                }
                counter++;
            }

            foreach (var item in ServiceIcons)
            {
                _icons.Children.Add(item);
            }
        }

        private Image CreateIcon(string source)
        {
            Image tempImage = new Image
            {
                HeightRequest = 20,
                WidthRequest = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Source = source,
            };
            return tempImage;
        }
    }
}
