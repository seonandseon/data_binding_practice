using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace practice4.ViewModel
{
    public class SimulateViewModel : INotifyPropertyChanged
    {
        bool canDownload = true;

        private string _simulateDownloadResult;
        public string simulateDownloadResult
        {
            get { return _simulateDownloadResult; }
            private set
            {
                if(_simulateDownloadResult != value)
                {
                    _simulateDownloadResult = value;
                    OnPropertyChanged("simulateDownloadResult");
                }
            }
        }

        public ICommand SimulateDownloadCommand { get; private set; }

        async Task SimulateDownloadAsync()
        {
            CanInitiateNewDownload(false);
            simulateDownloadResult = string.Empty;
            await Task.Run( () => SimulateDownload() );
            simulateDownloadResult = "Simulated download complete";
            CanInitiateNewDownload(true);
        }

        void CanInitiateNewDownload(bool value) //action
        {
            canDownload = value;
            ((Command)SimulateDownloadCommand).ChangeCanExecute();
        }

        void SimulateDownload()//action
        {
            //Simulate 5 seconds pause
            var endTime = DateTime.Now.AddSeconds(5);
            while (true)
            {
                if (DateTime.Now >= endTime)
                    break;
            }
        }

        public SimulateViewModel()
        {
            SimulateDownloadCommand =
            new Command(async () => await SimulateDownloadAsync(), () => canDownload);

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
