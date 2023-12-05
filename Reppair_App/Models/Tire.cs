using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reppair_App.Models
{
    public class Tire
    {
        [Key]
        public int TireId { get; set; }
        public string TireName { get; set; }
        public string TireSerialNumber { get; set; }
        public string TireManufacturer { get; set; }
        public double TireDebth { get; set; }

        public Tire(int tireId, string tireName, string tireSerialNumber, string tireManufacturer, double tireDebth)
        {
            TireId = tireId;
            TireName = tireName;
            TireSerialNumber = tireSerialNumber;
            TireManufacturer = tireManufacturer;
            TireDebth = tireDebth;
        }

    }
}
