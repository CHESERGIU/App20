using System;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            {
                char first = number.ToString()[0];
                char second = number.ToString()[1];
                char third = number.ToString()[2];
                char fourth = number.ToString()[3];
                Check(first);                
                Check(second);
                Check(third);
                Check(fourth);
            }
        }

        private static void Check(char digit)
        {
            switch (digit % 2)
            {
                case 0:
                    Console.WriteLine("PAR");
                    break;
                default:
                    Console.WriteLine("IMPAR");
                    break;
            }
        }
    }
}
