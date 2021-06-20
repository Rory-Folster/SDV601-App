using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App
{
    [Serializable]
    public class Service : Activity
    {
        public string nameOfWorkshop { get; set; }
        public DateTime dateOfService { get; set; }
        public string serviceDescription { get; set; }
        public decimal serviceCost { get; set; }

        public void ServiceActivity()
        {
            nameOfWorkshop = "Please enter a workshopname name";
            dateOfService = DateTime.Today;
            serviceDescription = "Please enter a service description";
            serviceCost = 0.00M;
        }

        public void ServiceActivity(string _nameOfWorkshop, DateTime _dateOfService, string _serviceDescription, decimal _serviceCost)
        {
            nameOfWorkshop = _nameOfWorkshop;
            dateOfService = _dateOfService;
            serviceDescription = _serviceDescription;
            serviceCost = _serviceCost;
        }

    }
}
