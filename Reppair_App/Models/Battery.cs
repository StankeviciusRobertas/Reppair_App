using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reppair_App.Models
{
    public class Battery
    {
        [Key]
        public int BatteryId { get; set; }
        public string BatteryName { get; set; }
        public string BatteryModel { get; set; }
        public string BatteryManufacturer { get; set; }

        public Battery(int batteryId, string batteryName, string batteryModel, string batteryManufacturer)
        {
            BatteryId = batteryId;
            BatteryName = batteryName;
            BatteryModel = batteryModel;
            BatteryManufacturer = batteryManufacturer;
        }
    }
}
