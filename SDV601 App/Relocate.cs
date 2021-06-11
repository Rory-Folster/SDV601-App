using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App
{
    [Serializable]
    public class Relocate : Activity
    {
        public string newLocationOfVehicle { get; set; }
        public int kmsOfRelocation { get; set; }
        public decimal relocationCost { get; set; }
    }
}
