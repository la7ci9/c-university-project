using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace OfficeClient
{
    public class ValidateFields
    {
        public ValidateFields()
        {
        }

        public static bool FieldsNotEmpty(string customerName, string carName, string carType, string plateNumber, string problemDescription)
        {
            bool result = true;
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(carName) || string.IsNullOrEmpty(carType) ||  string.IsNullOrEmpty(plateNumber) || string.IsNullOrEmpty(problemDescription))
            {
                MessageBox.Show("Fill all the fields");
                result = false;
            }
            else if (!ValidateName(customerName))
            {
                MessageBox.Show("Invalid name in customer name field", "Warning");
                result = false;
            }
            else if (!ValidateCarName(carName))
            {
                MessageBox.Show("Invalid car name in Car name field", "Warning");
                result = false;
            }
            else if (!ValidatePlateNumber(plateNumber))
            {
                MessageBox.Show("Invalid plate number\nPlease use XXX-000 format", "Warning");
                result = false;
            }

            return result;

        }

        public static bool ValidateName(string name)
        {
            Regex check = new Regex(@"^[A-ZŐÚÖÜÓÁŰÉ][a-zöüóúőéáű]*(\s[A-ZŐÚÖÜÓÁŰÉ][a-zöüóúőéáű]*)+$");
            bool valid = false;
            valid = check.IsMatch(name);
            return valid;
        }

        public static bool ValidateCarName(string name)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(name);
            return valid;
        }

        public static bool ValidatePlateNumber(string platenum)
        {
            Regex check = new Regex(@"^[A-Z]{3}-[0-9]{3}$");
            bool validPlate = false;
            validPlate = check.IsMatch(platenum);
            return validPlate;
        }


    }
}