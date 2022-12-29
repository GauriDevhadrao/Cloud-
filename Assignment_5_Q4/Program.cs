using System;

namespace Assignment_5_Q4
{
    class Program
    {
        static void Main(string[] args)
        {

        int capacity;

        Console.WriteLine("Enter capacity of stack :");

        capacity = int.Parse(Console.ReadLine());
        MyStack<object> stack = new MyStack<object>(capacity);
            while (true)
            {
                Console.WriteLine("1.Push");

                Console.WriteLine("2.Pop");

                Console.WriteLine("3.Peep");

                Console.WriteLine("4.Print Stack Element:");

                Console.WriteLine("Enter your Choice:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter element to Push:");

                            object temp = Console.ReadLine();

                            int result = stack.push(temp);

                            if (result != -1)
                            {
                                Console.WriteLine("Element Pushed into Stack !");
                            }
                            else
                            {
                                Console.WriteLine("Stack Overflow !");
                            }

                            break;
                        }
                    case 2:
                        {
                            object Result = stack.pop();

                            if(Result != null)
                            {
                                Console.WriteLine("Delete Element:" +Result);
                            }
                            else
                            {
                                Console.WriteLine("Stack Underflow !");
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Position of Element to Peep:");

                            int Position = int.Parse(Console.ReadLine());

                            object Result = stack.peep(Position);


                            if (Result != null)
                            {
                                Console.WriteLine("Element at Position" + Position + "is"  +Result);
                            }
                            break;
                        }
                    case 4:
                        {
                            object[] Elements = stack.GetAllStackElements();

                            Console.WriteLine("******Stack Content******");

                            foreach(object str in Elements)
                            {
                                Console.WriteLine(str);
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You have Entered Wrong Choice");

                            break;
                                
                        }
                }
            }
        }
    }
}
