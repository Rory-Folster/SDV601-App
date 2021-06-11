using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App 
{
    [Serializable]
    public class Hire : Activity
    {
        public string hireCustName { get; set; }
        public decimal hireCost { get; set; }
        public DateTime hireStartDate { get; set; }
        public DateTime hireEndDate { get; set; }

    }
}
