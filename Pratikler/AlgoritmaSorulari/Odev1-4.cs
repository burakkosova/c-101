using System;

namespace PatikaC101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            Console.WriteLine();

            string[] words = sentence.Split(" ");
            Console.WriteLine("Girdiğiniz cümle {0} harf ve {1} kelimeden oluşmaktadır.",sentence.Length,words.Length);
        }
    }
}
