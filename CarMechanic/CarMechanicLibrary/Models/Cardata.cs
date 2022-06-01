using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanicLibrary.Models
{
    public class Cardata
    {
        public long Id { get; set; }
        public string CustomerName { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string PlateNumber { get; set; }
        public string Status { get; set; }
        public string ProblemDescip { get; set; }
        public DateTime IntakeDate { get; set; }

        public override string? ToString()
        {
            return $"{CustomerName} -  {CarName} - {CarType}";
        }
    }
}
