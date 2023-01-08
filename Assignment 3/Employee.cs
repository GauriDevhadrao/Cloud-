using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3
{
    interface IPrintable
    {
        public void DisplayEmpDetails();

    }
    [Serializable]
    class Employee : IPrintable
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double NetSalary;
        private double GrossSalary;
        public int EMPNO { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NETSALARY { get; set; }
        public double GROSSSALARY { get; set; }

        public Employee()
        //int EmpNo, string EmpName, double Salary, double hra, double ta, double da, double pf, double tds, double NetSalary, double GrossSalary
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = Salary;
            this.HRA = hra;
            this.TA = ta;
            this.DA = da;
            this.PF = pf;
            this.TDS = tds;
            this.NETSALARY = NetSalary;
            this.GROSSSALARY = GrossSalary;
        }
        public virtual void CalculateDetails()
        {
            if (SALARY < 5000)
            {
                HRA = (10 * SALARY) / 100;
                TA = (5 * SALARY) / 100;
                DA = (15 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);


            }
            else if (SALARY < 10000)
            {
                HRA = (15 * SALARY) / 100;
                TA = (10 * SALARY) / 100;
                DA = (20 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY < 15000)
            {
                HRA = (20 * SALARY) / 100;
                TA = (15 * SALARY) / 100;
                DA = (25 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY < 20000)
            {
                HRA = (25 * SALARY) / 100;
                TA = (20 * SALARY) / 100;
                DA = (30 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY >= 20000)
            {
                HRA = (30 * SALARY) / 100;
                TA = (25 * SALARY) / 100;
                DA = (35 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }

        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("The Emp No is " + EMPNO);
            Console.WriteLine("The Emp Name is " + EMPNAME);
            Console.WriteLine("The Emp Salary is " + SALARY);
            Console.WriteLine("The Emp HRA is " + HRA);
            Console.WriteLine("The Emp TA is " + TA);
            Console.WriteLine("The Emp DA is " + DA);
            Console.WriteLine("The Emp PF is " + PF);
            Console.WriteLine("The Emp TDS is " + TDS);
            Console.WriteLine("The Emp Gross Salary is " + GROSSSALARY);
            Console.WriteLine("The Emp Net Salary is " + NETSALARY);

            //Console.WriteLine("The Emp Id is  " + EMPNO + " The Emp Name is " + EMPNAME + " The Emp Salary is " + SALARY + " The Emp HRA is " + HRA + " The Emp TA is " + TA + " The Emp DA is " + DA + " The Emp PF is " + PF + " The Emp TDS is " + TDS + " The Emp Netsalary is " + NETSALARY + " The Emp gross salary is " + GROSSSALARY);
        }
    }
    [Serializable]
    class Manager : Employee, IPrintable
    {
        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowance;

        public double PetrolAllowance { get; set; }
        public double FoodAllowance { get; set; }
        public double OtherAllowance { get; set; }
        public Manager()
        {
            this.PetrolAllowance = petrolAllowance;
            this.FoodAllowance = foodAllowance;
            this.OtherAllowance = otherAllowance;
        }
        public new void CalculateSalary()
        {
            PetrolAllowance = (8 * SALARY) / 100;
            FoodAllowance = (13 * SALARY) / 100;
            OtherAllowance = (3 * SALARY) / 100;
            base.CalculateDetails();
            GROSSSALARY = PetrolAllowance + FoodAllowance + OtherAllowance;
        }
        public override void CalculateDetails()
        {
            double GS = GROSSSALARY;
            PF = (10 * GS) / 100;
            TDS = (18 * GS) / 100;
            NETSALARY = GS - (PF + TDS);
        }
        public void DisplayManDetails()
        {
            Console.WriteLine("Petrol Allowance is " + PetrolAllowance);
            Console.WriteLine("Food Allowance is " + FoodAllowance);
            Console.WriteLine("Other Allowance is " + OtherAllowance);
            Console.WriteLine("Gross Salary is " + GROSSSALARY);
            Console.WriteLine("PF of manager is " + PF);
            Console.WriteLine("TDS of manager is " + TDS);
            Console.WriteLine("Net Salary of manager is " + NETSALARY);
        }
    }
    [Serializable]
    class MarketingExecutive : Employee, IPrintable
    {
        double kmsTravel;
        double tourAllowance;
        double TeleAllowance;
        double GS;
        public void CalculteMarketing()
        {
            Console.WriteLine("Enter Kilometer Travel: ");
            kmsTravel = Convert.ToDouble(Console.ReadLine());
            tourAllowance = 5 * kmsTravel;
            TeleAllowance = 1000;
            base.CalculateDetails();
            GROSSSALARY = kmsTravel + tourAllowance + TeleAllowance;
            GS = GROSSSALARY;
        }
        public override void CalculateDetails()
        {
            PF = (10 * GS) / 100;
            TDS = (18 * GS) / 100;
            NETSALARY = GS - (PF + TDS);
        }
        public void DisplayMarketing()
        {
            Console.WriteLine("Tour Allowance: " + tourAllowance);
            Console.WriteLine("Kilometers Travel: " + kmsTravel);
            Console.WriteLine("Gross Salary is " + GROSSSALARY);
            Console.WriteLine("PF of marketing executive is " + PF);
            Console.WriteLine("TDS of marketing executive is " + TDS);
            Console.WriteLine("Net Salary of marketing executive is " + NETSALARY);
            Console.ReadKey();
        }
    }
}