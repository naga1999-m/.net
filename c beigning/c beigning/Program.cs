// See https://aka.ms/new-console-template for more information

using System;

class Program
    {
        public  static void Main()
        {
            Console.WriteLine("please enter FirstName");
            string FirstName = Console.ReadLine();

            Console.WriteLine("please enter LastName");
            string LastName = Console.ReadLine();

            Console.WriteLine("hello {0},{1}", FirstName ,LastName);
        }
   
    }
