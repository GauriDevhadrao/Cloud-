using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class Mystack
    {
    static void Main(string[] args)
    
    {
        int n;
        MyStack m = new MyStack();
            do
            {
                Console.WriteLine("enter choice:");
                Console.WriteLine("1.push");
                Console.WriteLine("2.pop");
                Console.WriteLine("3.dispkay");
                Console.WriteLine("4.clone");
                Console.WriteLine("5.exit");

                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("enter element");
                        int num = Convert.ToInt32(Console.ReadLine());
                        m.push(num);
                        break;
                    case 2:
                        m.pop();
                        break;
                    case 3:
                        m.display();
                        break;
                    case 4:
                        MyStack newStack = m.Clone() as MyStack;
                        newStack.display();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("enter valid choice");
                        break;
                }

            } while (n < 6);
        }
    }
}
