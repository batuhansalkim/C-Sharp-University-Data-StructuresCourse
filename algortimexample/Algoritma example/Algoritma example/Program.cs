using System;

namespace Algoritma_example
{
    enum Islemler
    {
        Toplanma = 1,
        Cikarma = 2,
        Carpma = 3,
        Bolme = 4
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("dizi boyutunu giriniz :");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
        private static void Dongu()
        {
            int i = 0;
            while (i < 10)
            {

                Console.WriteLine(i);
                i++;

            }
        }
        private static void HesapMak()
        {

            int A = 100;
            int B = 20;
            Islemler secim = (Islemler)(new Random().Next(1, 4));
            switch (secim)
            {
                case Islemler.Toplanma:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B}  ={A / B}");
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
