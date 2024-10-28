namespace ModernWPFDesignPractice.Core
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    // testing own class instaed CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    public class MyObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // or PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
