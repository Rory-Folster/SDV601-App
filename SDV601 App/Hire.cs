﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV601_App 
{
    [Serializable]
    public abstract class Hire : Activity
    {
        public string hireCustName { get; set; }
        public decimal hireCost { get; set; }
        public DateTime hireStartDate { get; set; }
        public DateTime hireEndDate { get; set; }

        public void HireActivity ()
        {
            hireCustName = "Please enter a name";
            hireCost = 0.00M;
            hireStartDate = DateTime.Today;
            hireEndDate = DateTime.Today;
        }

        public void HireActivity(string _hireCustName, decimal _hireCost, DateTime _hireStartDate, DateTime _hireEndDate)
        {
            hireCustName = _hireCustName;
            hireCost = _hireCost;
            hireStartDate = _hireStartDate;
            hireEndDate = _hireEndDate;
        }
    }


}
