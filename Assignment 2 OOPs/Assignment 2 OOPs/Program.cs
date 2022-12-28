using System;

namespace Assignment_2_OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple C# Class !");
            //Create an Object of an Employee Class



            Employee emp = new Employee();
            Console.WriteLine("Enter Employee No");
            emp.empno =
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            emp.empname =
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            emp.salary =
            Convert.ToDouble(Console.ReadLine());
            
            emp.CalculateEmpDetails();
            emp.DisplayEmpDetails();
            Console.ReadKey();



        }
    }
}