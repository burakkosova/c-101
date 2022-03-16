using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, long> contacts = new Dictionary<string, long>()
            {
                {"Burak Kosova",1234567890},
                {"Abel Tesfaye",532222645},
                {"Emma Stone",0123456},
                {"Kendall Jenner",456123789},
                {"Scarlet Johanssen",23456789},
            };

            MainMenu();

            void MainMenu()
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("****************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
                Console.WriteLine();

                int actionNumber = int.Parse(Console.ReadLine());
                switch (actionNumber)
                {
                    case 1:
                        SaveContact();
                        break;
                    case 2:
                        RemoveContact();
                        break;
                    case 3:
                        UpdateContact();
                        break;
                    case 4:
                        ShowContacts();
                        break;
                    case 5:
                        SearchContact();
                        break;

                }
            }
            void SaveContact()
            {
                Console.Write(" Lütfen isim giriniz\t: ");
                string nameAndSurname = Console.ReadLine();

                Console.Write("Lütfen soyisim giriniz\t:");
                long phoneNumber = long.Parse(Console.ReadLine());

                contacts.Add(nameAndSurname, phoneNumber);
                Console.WriteLine("Kişi bilgileri kaydedildi");
                Console.WriteLine();
                MainMenu();
            }
            void RemoveContact()
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string input = Console.ReadLine();

                if (contacts.ContainsKey(input))
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", input);
                    string operation = Console.ReadLine();
                    if (operation == "y")
                    {
                        contacts.Remove(input);
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        Console.WriteLine();
                        MainMenu();
                    }

                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        Console.WriteLine();
                        MainMenu();
                    }
                    else
                    {
                        RemoveContact();
                    }
                }

            }
            void UpdateContact()
            {
                Console.WriteLine("Lütfen bilgilerini güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string input = Console.ReadLine().ToUpper();

                if (contacts.ContainsKey(input))
                {
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz: ");
                    long newNumber = long.Parse(Console.ReadLine());
                    contacts[input] = newNumber;
                    Console.WriteLine("{0} adlı kişi başarıyla güncellendi");
                    foreach (var item in contacts)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz...");
                    Console.WriteLine();
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Güncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine("Yeniden denemek için              : (2)");
                }
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("İşlem iptal edildi.");
                    Console.WriteLine();
                    MainMenu();
                }
                else if (n == 2)
                {
                    UpdateContact();
                }
            }
            void ShowContacts()
            {
                Console.WriteLine("Rehber");
                Console.WriteLine("**********************");
                Console.WriteLine("Alfabetik sıraya göre (A-Z) sıralamak için\t: (1)");
                Console.WriteLine("Alfabenin tersi yönünde (Z-A) sıralamak için\t: (2)");
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    var list = contacts.OrderByDescending(i => i.Key);
                    var newList = list.Reverse();
                    foreach (var item in newList)
                    {
                        Console.WriteLine("İsim Soyisim : " + item.Key);
                        Console.WriteLine("Telefon Numarası : " + item.Value);
                        Console.WriteLine("---------------------------");
                    }
                }
                else if (n == 2)
                {
                    var list2 = contacts.OrderByDescending(i => i.Key);
                    foreach (var item in list2)
                    {
                        Console.WriteLine("İsim Soyisim : " + item.Key);
                        Console.WriteLine("Telefon Numarası: " + item.Value);
                        Console.WriteLine("---------------------------");
                    }
                }
                Console.WriteLine();
                MainMenu();
            }
            void SearchContact()
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
                Console.WriteLine("**********************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("İsim ve soyismi giriniz :");
                    String input = Console.ReadLine();
                    if (contacts.ContainsKey(input))
                    {
                        int index = 0;
                        foreach (var item in contacts)
                        {
                            if (item.Key == input)
                            {
                                Console.WriteLine("Arama sonuçları : ");
                                Console.WriteLine("*************************");
                                Console.WriteLine("İsim soyisim : " + item.Key);
                                Console.WriteLine("Telefon Numarası : " + item.Value);
                            }
                            index++;
                        }
                        Console.WriteLine();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde bulunamadı.");
                        SearchContact();
                    }
                    Console.WriteLine();
                    MainMenu();
                }
                else if (n == 2)
                {
                    Console.WriteLine("Telefon numarasını giriniz :");
                    long phoneNumber = long.Parse(Console.ReadLine());
                    if (contacts.ContainsValue(phoneNumber))
                    {
                        int index = 0;
                        foreach (var item in contacts)
                        {
                            if (item.Value == phoneNumber)
                            {
                                Console.WriteLine("Arama Sonuçlarınız : ");
                                Console.WriteLine("*************************");
                                Console.WriteLine("İsim soyisim : " + item.Key);
                                Console.WriteLine("Telefon Numarası : " + item.Value);
                            }
                            index++;
                        }
                        Console.WriteLine();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız numara rehberde bulunamadı.");
                        SearchContact();
                    }
                    Console.WriteLine();
                    MainMenu();
                }
            }

        }
    }
}
