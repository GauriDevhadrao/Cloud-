using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Assignment_7_Q4
{
    [Serializable]
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}