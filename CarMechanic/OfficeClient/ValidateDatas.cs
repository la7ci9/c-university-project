using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace OfficeClient
{
    public class ValidateDatas
    {
        public static bool validateNotEmpty(string name, string carname, string cartype, string platenumber, string problemdesc)
        {
            if (name == "" || carname=="" || cartype == "" || platenumber == "" || problemdesc == "")
            { 
                return false;
            }


            return true;
        }

        public static bool validateAllData(string name, string carname, string cartype, string platenumber, string problemdesc)
        {
            isvalid_name(name);
            return true;
        }

        public static bool isvalid_name(string name)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(name);
            if (valid)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Wrong name");
                return valid;
            }
        }
    }
}
