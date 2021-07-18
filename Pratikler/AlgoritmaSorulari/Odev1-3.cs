using System;

namespace PatikaC101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] words = new string[n];
            Console.WriteLine(n + " tane kelime giriniz:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i+1 + ". kelime: ");
                words[i] =Console.ReadLine();
            }

            Console.WriteLine();
            Console.Write("Girdiğiniz sayılardan kelimeler(sondan başa doğru): ");

            for (int i=words.Length - 1; i >= 0; i--)
            {
                    Console.Write(words[i] + " ");
            }
        }
    }
}
