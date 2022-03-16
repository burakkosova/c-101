using System;
using System.Collections;

namespace Classes
{
  class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Burak";
        calisan1.Soyad = "Kosova";
        calisan1.No = 123
        calisan1.Departman = "Yazılım";
        calisan1.CalisanBilgileri();

        Console.WriteLine("*********");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Abel";
        calisan2.Soyad = "Tesfaye";
        calisan2.No = 345;
        calisan2.Departman = "Şarkıcı";
        calisan2.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0},", Ad);
        Console.WriteLine("Çalışan Soyadı: {0},", Soyad);
        Console.WriteLine("Çalışan Numarası: {0},", No);
        Console.WriteLine("Çalışan Departmanı: {0},", Departman);
    }
}
}
