using System;

namespace loops
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Lütfen bir sayı giriniz: ");
      int counter = int.Parse(Console.ReadLine());
      for (int i = 1; i <= counter; i++)
      {
        if (i % 2 == 1)
          Console.WriteLine(i);
      }

      int totalOdd = 0;
      int totalEven = 0;

      for (int i = 1; i <= 1000; i++)
      {
        if (i % 2 == 0)
          totalEven += i;

        if (i % 2 == 1)
          totalOdd += i;
      }

      Console.WriteLine("Tek sayıların toplamı: {0}", totalOdd);
      Console.WriteLine("Çift sayıların toplamı: {0}", totalEven);
    }
  }
}
