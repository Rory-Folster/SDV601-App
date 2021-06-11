using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App
{
    [Serializable]
    public abstract class Activity : IActivity
    {
        public string activityName { get; set; }
        public string activityType { get; set; }

        public DateTime activytDate { get; set; }
        public decimal Value { get; set; }
    }
}
