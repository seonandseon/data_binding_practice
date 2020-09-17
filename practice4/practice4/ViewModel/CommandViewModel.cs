using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace practice4.ViewModel
{
    public class CommandViewModel : INotifyPropertyChanged
    {
        //private int _num = 0;
        public int num { get; set;}

        //private double _result = 0.0;
        public double result { get; private set; }

        public ICommand SquareRootCommand { get; private set; }

        void CalculateSquareRoot() //action
        {
            result = Math.Sqrt(num);
            OnPropertyChanged("result");
        }

        public CommandViewModel()
        {
            num = 25;
            SquareRootCommand = new Command(CalculateSquareRoot);
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
