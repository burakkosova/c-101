using System;

namespace whileForEach
{
  class Program
  {
    static void Main(string[] args)
    {
      int sayi = int.Parse(Console.ReadLine());
      int sayac = 1;
      int toplam = 0;
      while (sayac <= sayi)
      {
        toplam += sayac;
        sayac++;
      }
      Console.WriteLine(toplam / sayi);

      char c = 'a';
      while (c < 'z')
      {
        Console.WriteLine(c);
        c++;
      }

      string[] arabalar = { "BMW", "Porsche", "Ford", "Ferrari", "Nissan" };
      foreach (string araba in arabalar)
      {
        Console.WriteLine(araba);
      }
    }
  }
}
