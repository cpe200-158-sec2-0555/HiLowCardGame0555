using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Card_Game
{
    class Cards
    {
        private int _rank;
        private string _suit;
        private bool _isUsed=false;
        public int Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }
        public string Suit
        {

            get
            {
                return _suit;
            }
            set
            {

                _suit = value;
            }
        }
        public bool IsUsed
        {
            get
            {
                return _isUsed;
            }
            set
            {
                _isUsed = value;
            }
        }
        public override string ToString()
        {
            string st;
            switch (Rank)
            {
                case 1:
                    st="A Card is Ace"+ " "+Suit;
                    break;
                case 11:
                    st = "A Card is Jack" + " " + Suit;
                    break;
                case 12:
                    st = "A Card is Queen" + " " + Suit;
                    break;
                case 13:
                    st = "A Card is King" + " " + Suit;
                    break;
                default:
                    st = "A Card is " +Rank+ " " + Suit;
                    break;

            }
            
            return st;
        }
    }
}
