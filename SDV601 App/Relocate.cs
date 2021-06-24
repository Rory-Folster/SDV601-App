using System;

namespace SDV601_App
{
    [Serializable]
    public class Relocate : Activity
    {
        
        public string _newLocationOfVehicle { get; set; } //creating properties 
        public int _relocationKS { get; set; }
        public float _relocationCost { get; set; }


        public string NewlocationOfVehicle { get => _newLocationOfVehicle; set => _newLocationOfVehicle = value; } //initilizing properties
        public int RelocationKS { get => _relocationKS; set => _relocationKS = value; }
        public float RelocationCost { get => _relocationCost; set =>  _relocationCost = value; }

    }


}
