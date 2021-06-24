using System;

namespace SDV601_App
{
    [Serializable]
    public class Service : Activity
    {

        public string _nameOfWorkshop { get; set; } //create properties

        public DateTime _dateOfService = DateTime.Today;
        public string _serviceDescription { get; set; }
        public float _serviceCost { get; set; }

        public string NameOfWorkshop { get => _nameOfWorkshop; set => _nameOfWorkshop = value; } //initilize properties
        public DateTime DateOfService { get => _dateOfService; set => _dateOfService = value; }
        public string ServiceDescription { get => _serviceDescription; set => _serviceDescription= value; }
        public float ServiceCost { get => _serviceCost; set => _serviceCost = value; }


    }
}
