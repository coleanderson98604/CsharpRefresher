using System;
using System.Collections.Generic;

namespace DeckOfCardOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Deck1 = new Deck();
            Player player1 = new Player("Colio");
            Deck1.shuffle();
            player1.Draw(Deck1,2);
            player1.Discard(Deck1,1);
            Deck1.reset();
        }
    }
    class Card
    {
        private string CardValue;
        private string Suit;
        private int Value;

        public Card(string CardValue, string Suit, int Value)
        {
            this.CardValue = CardValue;
            this.Suit = Suit;
            this.Value = Value;
        }
    }
    class Deck
    {
        public List<object> cards = new List<object>();
        public List<object> cardsCopy = new List<object>();

        public Deck()
        {
            string[] CardType = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            string[] CardSuit = {"Clubs","Spades","Heart","Diamonds"};
            for (int z = 0; z < CardSuit.Length; z++)
            {
                int y = 1;
                for (int x = 0; x < CardType.Length; x++)
                {
                    Card card = new Card(CardType[x],CardSuit[z],y);
                    cards.Add(card);
                    cardsCopy.Add(card);
                    y++;
                }
            }
        }
        public object deal()
        {
            int DeckAmount = this.cards.Count - 1;
            object DealtCard = this.cards[cards.Count - 1];
            this.cards.RemoveAt(DeckAmount);
            return DealtCard;
        }
        public void reset()
        {
            cards = cardsCopy;
        }
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < this.cards.Count; i++)
            {
                object temp = this.cards[i];
                int RandomIndex = rand.Next(0,this.cards.Count);
                this.cards[i] = this.cards[RandomIndex];
                this.cards[RandomIndex] = temp;
            }
        }
    }
    class Player
    {
        public string name;
        public List<object> hand = new List<object>();
        public Player(string name)
        {
            this.name = name;
        }
        public void Draw(Deck deck, int amount)
        {
            while(amount > 0)
            {
                amount--;
                hand.Add(deck.deal());
            }
        }
        public void Discard(Deck deck,int index)
        {
            object ReturnCard;
            if(this.hand.Count == 0)
            {
                return;
            }
            else
            {
                ReturnCard = this.hand[index];
                deck.cards.Add(ReturnCard);
                this.hand.RemoveAt(index);
            }
        }
    }
}
