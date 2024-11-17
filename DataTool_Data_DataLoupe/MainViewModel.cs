using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CircularProgressBarExample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double _progressValue;
        public double ProgressValue
        {
            get { return _progressValue; }
            set
            {
                if (_progressValue != value)
                {
                    _progressValue = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
