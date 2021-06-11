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

    }
}
