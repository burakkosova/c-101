using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("Lütfen 20 tane sayı giriniz: ");
            int n = 0;
            while (n < 20)
            {
                if (!int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.WriteLine("Sayı girmelisiniz");
                    continue;
                }

                numbers[n] = x;
                n++;
            }


            int max = FindMax(numbers);
            int secondMax = FindMax(Array.FindAll(numbers, n => n != max));
            int thirdMax = FindMax(Array.FindAll(numbers, n => n != max && n != secondMax));

            int min = FindMin(numbers);
            int secondMin = FindMin(Array.FindAll(numbers, n => n != min));
            int thirdMin = FindMin(Array.FindAll(numbers, n => n != min && n != secondMin));

            Console.WriteLine("En büyük 3 sayı: {0}, {1}, {2}",max,secondMax,thirdMax);
            double average = (max + secondMax + thirdMax)/3;
            Console.WriteLine("Ortalama: "+average);
            Console.WriteLine();
            Console.WriteLine("En küçük 3 sayı: {0}, {1}, {2}",min,secondMin,thirdMin);
            double average2 = (min + secondMin + thirdMin)/3;
            Console.WriteLine("Ortalama: "+average2);
            
        }

        private static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        private static int FindMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
