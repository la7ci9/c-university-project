using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OfficeClient.Commands
{
    public class AddWorkCommand : CommandBase
    {
        private string customerName;
        private string carName;
        private string carType;
        private string plateNumber;
        private string problemDescription;

        public AddWorkCommand(string customerName, string carName, string carType, string plateNumber, string problemDescription)
        {
            this.customerName = customerName;
            this.carName = carName;
            this.carType = carType;
            this.plateNumber = plateNumber;
            this.problemDescription = problemDescription;
        }

        public override void Execute(object parameter)
        {
            if (ValidateDatas.validateNotEmpty(customerName, carName, carType, plateNumber, problemDescription))
            {
                MessageBox.Show(customerName);
            }
            else
            {
                ValidateDatas.validateAllData(customerName, carName, carType, plateNumber, problemDescription);
            }


            //TO-DO
            MessageBox.Show("Add");
            
        }
    }
}
