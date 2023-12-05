using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reppair_App.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        //Navigaciniai properciai
        public Battery Battery { get; set; }
        public Engine Engine { get; set; }
        public Tire Tire { get; set; }

        public Vehicle(int vehicleId, string plateNumber, string vIN, string type, string brand, string name)
        {
            VehicleId = vehicleId;
            PlateNumber = plateNumber;
            VIN = vIN;
            Type = type;
            Brand = brand;
            Name = name;
        }
    }
}
