using System;

namespace PatikaC101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 2 adet pozitif sayı giriniz");
            Console.Write("1. Sayı: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("2. Sayı: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine(n + " tane pozitif sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i+1 + ". sayı: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Girdiğiniz sayılardan {0} sayısına tam bölünenler: ",m);

            foreach (int i in numbers)
            {
                if(i%m == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
