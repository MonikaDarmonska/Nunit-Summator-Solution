// See https://aka.ms/new-console-template for more information

using System;

namespace Summator // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
            if (sum == 21)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TESTFAIL");
            }




            int average = Summator.Average(new int[] {5, 10, 15 });
            if (average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TESTFAIL");
            }

        }
    }
}
