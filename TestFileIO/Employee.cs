﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileIO
{
    class Employee
    {
        private string Name;
        private float Salary;

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        #region Get/Set
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public float Salary1
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
            #endregion

        }
    }
}
