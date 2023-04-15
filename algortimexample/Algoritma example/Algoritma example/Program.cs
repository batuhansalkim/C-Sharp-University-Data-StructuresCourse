using System;

namespace Algoritma_example
{
    class Program
    {
        enum Islemler
        {
            Toplanma=1,
            Cikarma=2,
            Carpma=3,
            Bolme=4
        }
        static void Main(string[] args)
        {
            int A = 100;
            int B = 20;
            Islemler secim = (Islemler) (new Random().Next(1,4));
            switch (secim)
            {
                case Islemler.Toplanma:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A-B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A*B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B}  ={A/B}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz İslem!");
                    break;
            }

            Console.ReadKey();
        }
        private static void DegerOkuma()
        {
            var k = (char)Console.Read();

            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!!'");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("kucuk karakter.");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("buyuk karakter");
            }
            else
            {
                Console.WriteLine("bilinmiyor..");
            }
            Console.WriteLine(k);
            Console.ReadKey();
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
