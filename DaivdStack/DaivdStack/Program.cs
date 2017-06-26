using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaivdStack
{
    class Program
    {
        static void Main(string[] args)
        { 
            DavidStack<string> stack = new DavidStack<string>();
            while (true)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine();

                if (operation.ToLower() == "pop")
                {
                    Console.WriteLine(stack.Pop());
                }
                else if (operation.ToLower() == "peek")
                {
                    Console.WriteLine(stack.Peek());
                }
                else if (operation.ToLower() == "tostring")
                {
                    Console.WriteLine(stack.ToString());
                }
                else if (operation.ToLower() == "isempty")
                {
                    Console.WriteLine(stack.IsEmpty());
                }
                else if (operation.ToLower() == "help")
                {
                    Console.WriteLine("Some commands are: \n addtofront \n addtoend \n removefromfront \n removefromend \n removeat \n print");
                }
                else if (operation.ToLower() != "push")
                {
                    Console.WriteLine("Invalid command, type help for a list of commands");
                }
                else
                {
                    Console.WriteLine("Arguments: ");
                    string arguments = Console.ReadLine();

                    stack.Push(arguments);
                }
            }
        }
    }
}
