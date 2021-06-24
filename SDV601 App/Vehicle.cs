using System;

namespace SDV601_App
{
    [Serializable]
    public class Vehicle

    {

        public string _registration { get; set; } //create properties 

        public string _make { get; set; }

        public string _model { get; set; }

        public int _year { get; set; }

        public decimal _hireCost { get; set; }

        public DateTime _createdDate = DateTime.Now;


        public override string ToString()
        {
            return _registration + "\n" + _make + "\n" + _model + '\n' + _year + "\n" + _hireCost + "\n" + _createdDate; //creating a return string that will display all property input data
        }

        public string Registration { get => _registration; set => _registration = value; } //initializing properties 

        public string Make { get => _make; set => _make = value; }


        public string Model { get => _model; set => _model = value; }

        public int Year { get => _year; set => _year = value; }

        public decimal HireCost { get => _hireCost; set => _hireCost = value; }


        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }

    }
}
