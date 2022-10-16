using System;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Enter a Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Enter a Number is an Odd Number");
                Console.Read();
            }
        }
    }
}