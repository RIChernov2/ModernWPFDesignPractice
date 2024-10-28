using ModernWPFDesignPractice.Core;

namespace ModernWPFDesignPractice.MVVM.ViewModel
{
    public class MainViewModel : MyObservableObject
    {
        public MyRelayCommand HomeViewCommand { get; set; }
        public MyRelayCommand DiscoveryViewCommand { get; set; }
        public MyRelayCommand FeaturedViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }

        private object _currentView;

        public object CurrentView 
        { 
            get => _currentView;
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }  
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            FeaturedVM = new FeaturedViewModel();

            _currentView = HomeVM;

            HomeViewCommand = new MyRelayCommand(x =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new MyRelayCommand(x =>
            {
                CurrentView = DiscoveryVM;
            });

            FeaturedViewCommand = new MyRelayCommand(x =>
            {
                CurrentView = FeaturedVM;
            });
        }
    }
}
