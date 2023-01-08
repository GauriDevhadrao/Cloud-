using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_7_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\GDEVHADR\source\repos\Cloud-\Assignment_7_Q2\Output.txt";
            Employee emp = new Employee(101, "Gauri", 70000);
            FileStream stream = new FileStream(file, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + file);


            FileStream stream1 = new FileStream(file, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);
        }
    }
}