using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            ArrayList vowels = new ArrayList();

            foreach (char letter in sentence)
            {
                if ("aeioöuüAEIİOÖUÜ".Contains(letter))
                {
                    vowels.Add(letter);
                }
            }

            foreach (char item in vowels)
            {
                Console.Write(item+" ");
            }
        }
    }
}
