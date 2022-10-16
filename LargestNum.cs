using System;


namespace BasicCorePrograms
{
    internal class largnum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }

}