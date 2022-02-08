using System;

namespace Checking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

             result = num1 + num2;
              Console.ReadKey();ghh

            if(result < 100)
            {
                Console.WriteLine("True");

            }
               else if( result > 100)
            {
                Console.WriteLine("False");
                Console.WriteLine("Press Enter to exit");

            }










        }
    }
}
