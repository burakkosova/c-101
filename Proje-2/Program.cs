using System;
using System.Collections.Generic;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager cardManager = new CardManager();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                "*******************************************\n" +
                "(1) Board Listelemek\n" +
                "(2) Board'a Kart Eklemek\n" +
                "(3) Board'dan Kart Silmek\n" +
                "(4) Kart Taşımak");

                string choice = Console.ReadLine();
                if (!int.TryParse(choice, out int result))
                    return;

                switch (result)
                {
                    case 1:
                        cardManager.ListBoard();
                        break;
                    case 2:
                        Console.Write("Başlık Giriniz\t\t\t\t\t:");
                        string title = Console.ReadLine();
                        Console.Write("İçerik Giriniz\t\t\t\t\t:");
                        string content = Console.ReadLine();
                        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)\t:");
                        int.TryParse(Console.ReadLine(), out int size);
                        Console.Write("Kişi Seçiniz\t\t\t\t\t:");
                        int.TryParse(Console.ReadLine(), out int memberId);

                        cardManager.AddCard(new Card { type = Type.TODO, Title = title, Content = content, MemberId = memberId, size = (Size)size });
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                            Console.Write("Lütfen kart başlığını yazınız:");
                            string cardTitle = Console.ReadLine();
                            var cardToDelete = cardManager.GetCard(cardTitle);
                            if (cardToDelete is null)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için : (2)");
                                int.TryParse(Console.ReadLine(), out int answer);
                                if (answer == 2)
                                    continue;

                                break;
                            }

                            cardManager.DeleteCard(cardToDelete);
                            Console.WriteLine("{0} başlıklı kart başarıyla silindi",cardTitle);
                            Console.WriteLine();
                            break;
                        }

                        break;
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                            Console.Write("Lütfen kart başlığını yazınız:");
                            string cardTitle = Console.ReadLine();
                            var cardToMove = cardManager.GetCard(cardTitle);
                            if (cardToMove is null)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("İşlemi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için : (2)");
                                int.TryParse(Console.ReadLine(), out int answer);
                                if (answer == 2)
                                    continue;

                                break;
                            }

                            Console.WriteLine("Bulunan Kart Bilgileri:");
                            Console.WriteLine("**************************************");
                            cardManager.ListCardInfo(cardToMove);

                            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                            int.TryParse(Console.ReadLine(), out int moveAnswer);
                            cardManager.DeleteCard(cardToMove);
                            cardToMove.type = (Type)moveAnswer;
                            cardManager.AddCard(cardToMove);
                            break;
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }
            }

        }
    }
}
