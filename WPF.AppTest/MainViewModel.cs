using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF.AppTest
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private ObservableCollection<string> items;

        public ObservableCollection<string> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ObservableCollection<string>();
                }

                return this.items;
            }
            set
            {
                this.items = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
        }
    }
}
