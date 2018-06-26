﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpCode { get; set; }
        public string Designation { get; set; }

        public string GetEmployeeName()
        {
            return FirstName + ' ' + LastName;
        }
    }
}
