using System;

namespace ConsoleApplication1
{
    class Program
    {
        public  static void Main()
        {
            Console.WriteLine("please enter first name");
            string FirstName = Console.Readline();

            Console.WriteLine("please enter last name");
            string LastName = Console.Readline();

            Console.WriteLine("hello {0},{1}", FirstName ,LastName);
        }
    
    }
}