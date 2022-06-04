using MechanicClient.CardataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebApi_Common.Models;

namespace MechanicClient
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
            Status_ComboBox.Items.Add("Process");
            Status_ComboBox.Items.Add("Done");
            EditButton.Visibility = Visibility.Collapsed;
        }
        private void EditCommand_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields.FieldsNotEmpty(CustomerName.Text, CarName.Text, CarType.Text, PlateNumber.Text, ProblemDescription.Text))
            {
                _cardata.Name = CustomerName.Text;
                _cardata.CarName = CarName.Text;
                _cardata.CarType = CarType.Text;
                _cardata.PlateNumber = PlateNumber.Text;
                _cardata.Status = Status_ComboBox.SelectedValue.ToString();
                _cardata.ProblemDescip = ProblemDescription.Text;
                _cardata.IntakeDate = DateTime.Now;

                DataProvider.UpdateCardata(_cardata);
                UpdateWorkListView();
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCarData = WorkListView.SelectedItems as Cardata;

            if (selectedCarData != null)
            {
                _cardata = selectedCarData;
                CustomerName.Text = selectedCarData.Name;
                CarName.Text = selectedCarData.CarName;
                CarType.Text = selectedCarData.CarType;
                PlateNumber.Text = selectedCarData.PlateNumber;
                ProblemDescription.Text = selectedCarData.ProblemDescip;
                if (selectedCarData.Status.Equals("Recorded"))
                {
                    Status_ComboBox.Text = "Recorded";
                }
                else if (selectedCarData.Status.Equals("Process"))
                {
                    Status_ComboBox.Text = "Process";
                }
                else if (selectedCarData.Status.Equals("Done"))
                {
                    Status_ComboBox.Text = "Done";
                }

                EditButton.Visibility = Visibility.Visible;
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
