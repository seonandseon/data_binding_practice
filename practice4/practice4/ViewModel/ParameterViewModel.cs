using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace practice4.ViewModel
{
    public class ParameterViewModel : INotifyPropertyChanged
    {
        public int num { get; set; }
        public double result { get; private set; }

        public ICommand SquareRootParameterCommand { get; private set; }
        
        void CalculateSquareRoot(string value)
        {
            double num = Convert.ToDouble(value);
            result = Math.Sqrt(num);
            OnPropertyChanged("result");
        }

        public ParameterViewModel()
        {
            SquareRootParameterCommand = new Command<string>(CalculateSquareRoot);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
