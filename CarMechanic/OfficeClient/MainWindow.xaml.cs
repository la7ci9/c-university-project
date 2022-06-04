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
            UpdateWorkListView();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCarData = WorkListView.SelectedItem as Cardata;

            if (selectedCarData != null)
            {
              
                _cardata = selectedCarData;
                CustomerName.Text = _cardata.Name;
                CarName.Text = _cardata.CarName;
                CarType.Text = _cardata.CarType;
                PlateNumber.Text = _cardata.PlateNumber;
                ProblemDescription.Text = _cardata.ProblemDescip;

                //AddButton.Visibility = Visibility.Collapsed;
                //EditButton.Visibility = Visibility.Visible;
                //DeleteButton.Visibility = Visibility.Visible;

            }
        }
      
        private void AddWork_Click(object sender, RoutedEventArgs e)
        {
                _cardata = new Cardata();
                //AddButton.Visibility = Visibility.Visible;
                //EditButton.Visibility = Visibility.Collapsed;    //Csak kattintás után rejti el a gombokat JAVÍTANI!!
                //DeleteButton.Visibility = Visibility.Collapsed;
        
            if (ValidateFields.FieldsNotEmpty(CustomerName.Text, CarName.Text, CarType.Text, PlateNumber.Text, ProblemDescription.Text))
            {
                _cardata.Name = CustomerName.Text;
                _cardata.CarName = CarName.Text;
                _cardata.CarType = CarType.Text;
                _cardata.PlateNumber = PlateNumber.Text;
                _cardata.Status = "Recorded";
                _cardata.ProblemDescip = ProblemDescription.Text;
                _cardata.IntakeDate = DateTime.Now;

                //Küldeni a szervernek
                DataProvider.CreateCardata(_cardata);
                UpdateWorkListView();
            }
        }

        private void EditWork_Click(object sender, RoutedEventArgs e)
        {

            if (ValidateFields.FieldsNotEmpty(CustomerName.Text, CarName.Text, CarType.Text, PlateNumber.Text, ProblemDescription.Text))
            {
               
                _cardata.Name = CustomerName.Text;
                _cardata.CarName = CarName.Text;
                _cardata.CarType = CarType.Text;
                _cardata.PlateNumber = PlateNumber.Text;
                _cardata.ProblemDescip = ProblemDescription.Text;
                _cardata.IntakeDate = DateTime.Now;

                DataProvider.UpdateCardata(_cardata);
                UpdateWorkListView();
                WorkListView.UnselectAll();
            }
        }

        private void DeleteWork_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DataProvider.DeleteCardata(_cardata.Id);
                UpdateWorkListView();
            }
        }

        private void UpdateWorkListView()
        {
            //frissíti a listát
            var cardatas = DataProvider.GetCardata().ToList();
            WorkListView.ItemsSource = cardatas;
        }
    }
}