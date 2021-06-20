using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SDV601_App
{
    [Serializable]
    public class Vehicle
    {
        public string Registration { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal HireCost { get; set; }

        public DateTime CreatedDate { get; set; }

        public  List<IActivity> _activities = new List<IActivity>();

        public  IList<IActivity> Activities { get => _activities; }

        public string _registration
        {
            get { return Registration; }
            set { Registration = value; }
        }

        public string _make
        {
            get { return Make; }
            set { Make = value; }
        }

        public string _model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int _year
        {
            get { return Year; }
            set { Year = value; }
        }
        public decimal _hireCost
        {
            get { return 0.00M; }
            set { HireCost = value; }
        }
    }
}
