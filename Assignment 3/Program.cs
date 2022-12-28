using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3OOP_Q1
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
        public virtual void CalculateEmpDetails()
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
                ta = (salary * 15) / 100;
                da = (salary * 25) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary < 20000)
            {
                hra = (salary * 25) / 100;
                ta = (salary * 20) / 100;
                da = (salary * 30) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
            else if (salary >= 20000)
            {
                hra = (salary * 30) / 100;
                ta = (salary * 25) / 100;
                da = (salary * 35) / 100;
                grosssalary = salary + hra + ta + da;
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = grosssalary - (pf + tds);
            }
        }
        class Manager: Employee
        {
            double Petrol;
            double Food;
            double Other;
            double gs;
            public new void CalculateGross()
            {
                Petrol = (salary * 8) /100;
                Food = (salary * 13) / 100;
                Other = (salary * 3) / 100;
                base.CalculateEmpDetails();
                grosssalary = grosssalary + Petrol + Food + Other;
            }
            public override void CalculateEmpDetails()
            {
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) /100;
                netsalary = netsalary = grosssalary - (pf + tds);

            }
            public new void Display()
            {
            Console.WriteLine("\n The Emp No is " + empno + "\n  The Emp Name is " + empname + " \n The Salary is " + salary + "\n  The Petrol allowance  is " + Petrol + "\n  The Food allowance is " + Food + "\n  The Other allowance is " + Other + "\n The HRA is " + hra + "\n The TA is " + ta + "\n The DA is " + da + "\n The PF is " + pf + "\n The TDS is " + tds + "\n The NetSalary is " + netsalary + " \n The GrossSalary is " + grosssalary);

            }
        }
        class MarketingExecutive:Employee
        {
            double KmTravel;
            double Tel;
            double Tour;
            double gs;

            public new void CalculateGross()
            {
                Console.WriteLine("Enter Travel Distance in Km");
                KmTravel = Convert.ToInt32(Console.ReadLine());
                Tel = 1000;
                Tour = KmTravel *5;
                base.CalculateEmpDetails();
                gs = gs + Tel + Tour ;

            }
            public override void CalculateEmpDetails()
            {
                pf = (grosssalary * 10) / 100;
                tds = (grosssalary * 18) / 100;
                netsalary = netsalary = grosssalary - (pf + tds);

            }
            public new void DisplayMarketing()
            {
                Console.WriteLine(  "\n  The Telephone allowance  is " + Tel + "\n  The Tour allowance  is " + Tour );

            }

        }
        public static void Main(String[] args)
        {
            Manager A = new Manager();
            MarketingExecutive B = new MarketingExecutive();
            Console.WriteLine("\n Enter Employee No");
            A.empno =
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter Employee Name");
            A.empname =
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Enter Employee Salary");
            A.salary =
            Convert.ToDouble(Console.ReadLine());

            A.CalculateGross();
            A.CalculateEmpDetails();
            A.Display();
            
            Console.WriteLine("\n Enter Employee No");
            B.empno =
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter Employee Name");
            B.empname =
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Enter Employee Salary");
            B.salary =
            Convert.ToDouble(Console.ReadLine());

            B.CalculateGross();
            B.CalculateEmpDetails();
            B.DisplayMarketing();
            Console.ReadKey();
        }
    }
}

    