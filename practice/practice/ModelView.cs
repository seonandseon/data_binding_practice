using System;
using System.ComponentModel;

namespace practice
{
    public class ModelView : INotifyPropertyChanged
    {
        public ModelView()
        {

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

        int _number1 = 0;
        public int number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("number1"));
            }
        }

        int _number2 = 0;
        public int number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("number2"));
            }
        }

        int _number3 = 0;
        public int number3
        {
            get { return _number3; }
            set
            {
                _number3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("number3"));
            }
        }
    }
}
