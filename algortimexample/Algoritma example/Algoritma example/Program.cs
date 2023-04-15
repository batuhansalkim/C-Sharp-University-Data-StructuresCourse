using System;

namespace Algoritma_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("heeloo");
        }
        private static void MutlakDegerOrnegi()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }

            Console.ReadKey();
        }
    }
}
