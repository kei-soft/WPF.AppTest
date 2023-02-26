using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF.ValidationRuleTest
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private ObservableCollection<TestData> items;

        public ObservableCollection<TestData> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ObservableCollection<TestData>();
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
            this.Items.Add(new TestData { Name = "Jack", StartDate = new DateTime(2023, 10, 15), EndDate = new DateTime(2023, 10, 20) });
            this.Items.Add(new TestData { Name = "Brown", StartDate = new DateTime(2023, 1, 11), EndDate = new DateTime(2023, 1, 22) });
        }
    }
}