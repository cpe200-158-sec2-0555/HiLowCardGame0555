using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Card_Game
{
    class Deck
    {
        private int _countCards=52;
        private bool _isEmpty;
        private List<Cards> acard=new List<Cards>();

        public int CountCards
        {
            get
            {
                return _countCards;
            }
            set
            {
                    _countCards = value;
            }

        }
        public bool IsEmpty
        {
            get
            {
                return _isEmpty;
            }
            set
            {
                _isEmpty = value;
            }
            
        }

        public Deck()
        {
            
            for (int i = 1; i <= 13; i++)
            {
                Cards c = new Cards();
                c.Suit = "Clubs";
                c.Rank = i;
                acard.Add(c);
            }
            for (int j = 1; j <= 13; j++)
            {
                Cards c = new Cards();
                c.Suit = "Diamonds";
                c.Rank = j;
                acard.Add(c);
            }
            for (int k = 1; k <= 13; k++)
            {
                Cards c = new Cards();
                c.Suit = "Hearts";
                c.Rank = k;
                acard.Add(c);
            }
            for (int l = 1; l <= 13; l++)
            {
                Cards c = new Cards();
                c.Suit = "Spades";
                c.Rank = l;
                acard.Add(c);
            }
            
        }
        Random card = new Random();
        public Cards DealCard()
        {
            Cards c = new Cards();
            int a = card.Next(acard.Count());
            c =acard[a];
            acard.Remove(c);
            CountCards--; 
            return c;
        }
        public void ReturnCard(Cards a,Cards b,Cards c,Cards d)
        {
            acard.Add(a);
            acard.Add(b);
            acard.Add(c);
            acard.Add(d);
            CountCards+=4;
        }
        public int getCount()
        {
            return acard.Count();

        }


    }
}
