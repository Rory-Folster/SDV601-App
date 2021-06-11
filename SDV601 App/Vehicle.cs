using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App
{
    [Serializable]
    public class Vehicle
    {
        public string Registration { get; set; }

        public DateTime CreatedDate { get; set; }

        private  List<IActivity> _activities = new List<IActivity>();

        public  IList<IActivity> Activities { get => _activities; }
    }
}
