using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OOP_Assignment_3
{
    class Program
    {

        public static void SerializeObject(Object o)
        {
            FileStream fs = new FileStream(@"C:\Github\.Net-FullStack\c#\OOP_Assignment_3\Output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }

        public static void DeserializeObject()
        {
            FileStream fs = new FileStream(@"C:\Github\.Net-FullStack\c#\OOP_Assignment_3\Output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager();
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"-----Printing DeSerialized Manager Object-----\n{m1}");
            fs.Close();
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Manager emp = new Manager();
            MarketingExecutive M = new MarketingExecutive();
            Console.WriteLine("Enter Employee Number: ");
            emp.EMPNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name: ");
            emp.EMPNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
            emp.SALARY = Convert.ToDouble(Console.ReadLine());
            //emp.CalculateDetails();
            //emp.DisplayEmpDetails();
            emp.CalculateSalary();
            //Serializing and DeSerializing from assignment-7
            SerializeObject(emp);
            DeserializeObject();


            emp.CalculateDetails();
            emp.DisplayManDetails();
            M.CalculteMarketing();
            M.CalculateDetails();
            M.DisplayMarketing();

            StreamReader s = new StreamReader(@"C:\Github\.Net-FullStack\c#\OOP_Assignment_3\Output.txt");
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();

            Console.ReadKey();
        }
    }
}

