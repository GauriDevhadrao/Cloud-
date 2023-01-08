using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_5_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();

            Console.WriteLine("Enter the number of Employees you want:");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the names of employee :");
            for (int i = 0; i < size; i++)
            {
                string name = Console.ReadLine();
                li.Add(new Employee(name));
            }

            Console.WriteLine("The list of employee is :");
            foreach (Employee emp in li)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("List Contains " + li.Count + " Employees");
            Console.WriteLine("Enter the name of the employee you want to search");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (Employee e in li)
            {
                if (e.name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            Console.WriteLine(found == true ? "Employee found." : "No record found.");
        }
    }
}