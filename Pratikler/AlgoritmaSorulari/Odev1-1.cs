using System;

namespace PatikaC101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane sayı gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine(n + " tane pozitif sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i+1 + ". sayı: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Girdiğiniz pozitif sayılar: ");

            foreach (int i in numbers)
            {
                if(i%2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
