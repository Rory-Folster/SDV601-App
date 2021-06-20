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

/*    public void HireActivity()
    {
        hireCustName = "Please enter a name";
        hireCost = 0.00M;
        hireStartDate = DateTime.Today;
        hireEndDate = DateTime.Today;
    }
    public void RelocateActivity(string _newLocationOfVehicle, int _kmsOfRelocation, decimal _relocationCost)
    {
        newLocationOfVehicle = _newLocationOfVehicle;
        kmsOfRelocation = _kmsOfRelocation;
        relocationCost = _relocationCost;
    }*/
}
