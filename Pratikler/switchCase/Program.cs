using System;

namespace switchCase
{
  class Program
  {
    static void Main(string[] args)
    {
      int month = DateTime.Now.Month;

      switch (month)
      {
        case 1:
          System.Console.WriteLine("Ocak ayındasınız!");
          break;
        case 2:
          System.Console.WriteLine("Şubat ayındasınız!");
          break;
        case 3:
          System.Console.WriteLine("Mart ayındasınız!");
          break;
        case 4:
          System.Console.WriteLine("Nisan ayındasınız!");
          break;
        case 5:
          System.Console.WriteLine("Mayıs ayındasınız!");
          break;
        case 6:
          System.Console.WriteLine("Haziran ayındasınız!");
          break;
        case 7:
          System.Console.WriteLine("Temmuz ayındasınız!");
          break;
        default:
          System.Console.WriteLine("yanlış deger!");
          break;
      }
    }
  }
}
