using System;


namespace SDV601_App 
{
    [Serializable]
    public class Hire : Activity //creating Hire sub class inheriting from Activity class
    {

        private string _hireCustName { get; set; } //creating Hire properties
        private float _hireCost { get; set; }

        private DateTime _hireStartDate = DateTime.Today;

        private DateTime _hireEndDate = DateTime.Today;

        public string HireCustName { get => _hireCustName; set => _hireCustName = value; } //initilizing proprties

        public float HireCost { get => _hireCost; set => _hireCost = value; }
       
        public DateTime HireStartDate { get => _hireStartDate; set => _hireStartDate = value; }


        public DateTime HireEndDate { get => _hireEndDate; set => _hireEndDate = value; }

        public override string ToString()
        {
            return _hireCustName + "\n" + _hireCost + "\n" + _hireStartDate + '\n' + _hireEndDate; //overriding string, including all Hire properties that can be used later to store in a list
        }

    }
}
