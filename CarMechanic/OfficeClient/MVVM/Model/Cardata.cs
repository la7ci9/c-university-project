using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClient.MVVM.Model
{
    public class Cardata
    {

        private string _customerName { get; set; }
        private string _carName { get; set; }
        private string _carType { get; set; }
        private string _plateNumber { get; set; }
        private string _status { get; set; }
        private string _problemDescip { get; set; }
        private DateTime _intakeDate { get; set; }

        public Cardata(string customerName, string carName, string carType, string plateNumber, string status, string problemDescip, DateTime intakeDate)
        {
            _customerName = customerName;
            _carName = carName;
            _carType = carType;
            _plateNumber = plateNumber;
            _status = status;
            _problemDescip = problemDescip;
            _intakeDate = intakeDate;

        }
    }
}
