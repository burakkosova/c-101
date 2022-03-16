using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList primes = new();
            ArrayList nonPrimes = new();

            Console.WriteLine("20 adet pozitif sayı giriniz:");
            int n = 0;
            while(n < 20)
            {
                if (!int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.WriteLine("Sayı girmelisiniz!");
                    continue;
                }

                if(x<0)
                {
                    Console.WriteLine("Girdiğiniz sayı pozitif olmalıdır!");
                    continue;
                }

                if (CheckIfPrime(x))
                {
                    primes.Add(x);
                    n++;
                    continue;
                }

                nonPrimes.Add(x);
                n++;
            }

            primes.Sort();
            primes.Reverse();
            Console.Write("Prime numbers: { ");
            foreach (int prime in primes)
            {
                Console.Write(prime+" ");
            }
            Console.WriteLine("}");
            Console.WriteLine("Prime number count: " + primes.Count);
            Console.WriteLine("Average of prime numbers: "+CalcAverage(primes));

            Console.WriteLine();

            nonPrimes.Sort();
            nonPrimes.Reverse();
            Console.Write("Non-prime numbers: { ");
            foreach (int number in nonPrimes)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("}");

            Console.WriteLine("Non-prime number count: " + nonPrimes.Count);
            Console.WriteLine("Average of non-prime numbers: " + CalcAverage(nonPrimes));

        }

        private static double CalcAverage(ArrayList numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Count;
        }

        private static bool CheckIfPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);

            int root = (int)Math.Sqrt(number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
