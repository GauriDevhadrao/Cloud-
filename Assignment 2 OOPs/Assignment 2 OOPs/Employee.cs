using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_OOPs
{
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public int empno { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }
        public double hra { get; set; }
        public double ta { get; set; }
        public double da { get; set; }
        public double pf { get; set; }
        public double tds { get; set; }
        public double netsalary { get; set; }
        public double grosssalary { get; set; }
        public Employee()
        //(int EmpNo, string EmpName, double Salary, double HRA, double TA, double DA, double PF, double TDS, double NetSalary, double GrossSalary)
        {
            this.empno = EmpNo;
            this.empname = EmpName;
            this.salary = Salary;
            this.hra = HRA;
            this.ta = TA;
            this.da = DA;
            this.pf = PF;
            this.tds = TDS;
            this.netsalary = NetSalary;
            this.grosssalary = GrossSalary;
        }
        //Member fnctions
        public void DisplayEmpDetails()
        {
            Console.WriteLine("The Emp No is " + empno + " The Emp Name is " + empname + " The Salary is " + salary + "The HRA is " + hra + "The TA is " + ta + "The DA is " + da + "The PF is " + pf + "The TDS is " + tds + "The NetSalary is " + netsalary + "The GrossSalary is " + grosssalary);

        }
        public void CalculateEmpDetails()
        {
            if (salary < 5000)
            {
                hra = (salary * 10) / 100;
                ta = (salary * 5) / 100;
                da = (salary * 15) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary < 10000)
            {
                hra = (salary * 10) / 100;
                ta = (salary * 5) / 100;
                da = (salary * 15) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary < 15000)
            {
                hra = (salary * 20) / 100;
                ta = (salary * 15)/100;
                da = (salary * 25) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary < 20000)
            {
                hra = (salary * 25) / 100;
                ta = (salary * 20)/ 100;
                da = (salary * 30) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary >=20000)
            {
                hra = (salary * 30) / 100;
                ta = (salary * 25)/ 100;
                da = (salary * 35) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
        }
    }
}

