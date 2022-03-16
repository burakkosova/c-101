using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class CardManager
    {
        private List<TeamMember> teamMembers;
        private List<Card> cards;

        public CardManager()
        {
            this.teamMembers = new List<TeamMember>()
            {
                new TeamMember() {Id=1, Name="Burak"},
                new TeamMember() {Id=2, Name="Abel"},
                new TeamMember() {Id=3, Name="Scarlet"},
                new TeamMember() {Id=4, Name="Kendal"}
            };

            this.cards = new List<Card>()
            {
                new Card {type=Type.TODO, Title = "Test",Content="Entegrasyon testi",MemberId=1, size=Size.L},
                new Card {type=Type.INPROGRESS, Title = "Ropörtaj",Content="Vogue ropörtajı",MemberId=4, size = Size.M},
                new Card {type=Type.DONE, Title = "Album",Content="Dawn FM",MemberId=2, size=Size.XL}
            };

        }

        public void ListBoard()
        {
            var todos = this.cards.FindAll(card => card.type == Type.TODO);
            var inProgress = this.cards.FindAll(card => card.type == Type.INPROGRESS);
            var done = this.cards.FindAll(card => card.type == Type.DONE);

            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            List(todos);
            
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            List(inProgress);
            
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            List(done);
        }

        private void List(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine("Başlık\t\t:" + card.Title);
                Console.WriteLine("İçerik\t\t:" + card.Content);
                Console.WriteLine("Atanan Kişi\t:" + (this.teamMembers.Find(t => t.Id == card.MemberId)).Name);
                Console.WriteLine("Büyüklük\t:" + card.size);
                Console.WriteLine();
            }
        }
        public void ListCardInfo(Card card)
        {
                Console.WriteLine("Başlık\t\t:" + card.Title);
                Console.WriteLine("İçerik\t\t:" + card.Content);
                Console.WriteLine("Atanan Kişi\t:" + (this.teamMembers.Find(t => t.Id == card.MemberId)).Name);
                Console.WriteLine("Büyüklük\t:" + card.size);
                Console.WriteLine();
        }

        public void AddCard(Card card)
        {
            var member = this.teamMembers.Find(m => m.Id == card.MemberId);
            if(member is null)
            {
                Console.WriteLine("Böyle bir takım üyesi bulunmamaktadır. Lütfen tekrar deneyin!");
                return;
            }

            this.cards.Add(card);
        }

        public Card GetCard(string title)
        {
            Card result=null;
            foreach (Card card in this.cards)
            {
                if (card.Title == title)
                    result = card;
            }
            return result;
        }

        public void DeleteCard(Card card)
        {
            this.cards.Remove(card);
        }
    }
}
