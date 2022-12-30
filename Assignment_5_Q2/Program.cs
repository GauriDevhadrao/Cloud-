using System;

namespace Assignment_5_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Accept(101, "Nikita", 25000, "8 dec 2022", "Sales");



            emp1.Accept(101, "Ram", 25000, "1 mar 2022", "Sales");



            emp1.Accept(101, "Vijay", 25000, "7 nov 2022", "Sales");



            emp1.display();



        }
    }
}