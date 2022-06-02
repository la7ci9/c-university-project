using OfficeClient.Commands;
using OfficeClient.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OfficeClient.MVVM.ViewModel
{
    public class MainViewModell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Cardata> CarDatas { get; private set; }

        public ICommand AddWorkCommand { get; }
        public ICommand EditWorkCommand { get; }
        public ICommand DeleteWorkCommand { get; }

        public MainViewModell()
        {
            CarDatas = new ObservableCollection<Cardata>();
            AddWorkCommand = new AddWorkCommand(customerName, carName, carType, plateNumber, problemDescription);
            EditWorkCommand = new EditWorkCommand();
            DeleteWorkCommand = new DeleteWorkCommand();

        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private string customerName;

        public string CustomerName { get => customerName; set => SetProperty(ref customerName, value); }

        private string carName;

        public string CarName { get => carName; set => SetProperty(ref carName, value); }

        private string carType;

        public string CarType { get => carType; set => SetProperty(ref carType, value); }

        private string plateNumber;

        public string PlateNumber { get => plateNumber; set => SetProperty(ref plateNumber, value); }

        private string problemDescription;

        public string ProblemDescription { get => problemDescription; set => SetProperty(ref problemDescription, value); }
    }
}