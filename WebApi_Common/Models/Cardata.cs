using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi_Common.Models
{
    public class Cardata
    {
        
        public long Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        
        [MaxLength(20)]
        public string CarName { get; set; }
       
        [MaxLength(20)]
        public string CarType { get; set; }
       
        //[Key]
        [MaxLength(7)]
        public string PlateNumber { get; set; }
       
        [MaxLength(20)]
        public string Status { get; set; }
        
        [MaxLength(200)]
        public string ProblemDescip { get; set; }
        
        public DateTime IntakeDate { get; set; }
    }

}
