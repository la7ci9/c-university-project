using OfficeClient.CardataProvider;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WebApi_Common.Models;

namespace OfficeClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cardata _cardata;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var selectedCarData = WorkListView.SelectedItems as Cardata;
        }

        private void AddWork_Click(object sender, RoutedEventArgs e)
        {
                _cardata = new Cardata();
                AddButton.Visibility = Visibility.Visible;
                EditButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
        
            if (ValidateFields.FieldsNotEmpty(CustomerName.Text, CarName.Text, CarType.Text, PlateNumber.Text, ProblemDescription.Text))
            {
                MessageBox.Show("Yeeeee");
                _cardata.Name = CustomerName.Text;
                _cardata.CarName = CarName.Text;
                _cardata.CarType = CarType.Text;
                _cardata.PlateNumber = PlateNumber.Text;
                _cardata.Status = (WebApi_Common.Models.Statuses)Statuses.Recorded;
                _cardata.ProblemDescip = ProblemDescription.Text;
                _cardata.IntakeDate = DateTime.Now;
                //Küldeni a szervernek
            }
        }

        private void EditWork_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteWork_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateWorkListView()
        {
            var cardatas = DataProvider.GetCardata().ToList();
            WorkListView.ItemsSource = cardatas;
            //frissíti a listát
        }
        public enum Statuses
        {
            Recorded
        }
    }
}