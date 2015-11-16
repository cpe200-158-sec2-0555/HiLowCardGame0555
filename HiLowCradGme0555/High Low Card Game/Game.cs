using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Card_Game
{
    class Game
    {
        private Deck _gameCard=new Deck();
        private bool _isEnd = false;
        private Players _p1=new Players();
        private Players _p2 = new Players();

        public bool IsEnd
        {
            get
            {
                return _isEnd;
            }
            set
            {
                _isEnd = value;
            }
        }

        public void CompareCards(Cards c1,Cards c2)
        {
            int sum = 2;
            Cards c11 = new Cards();
            Cards c21 = new Cards();

           
            while(c1.Rank == c2.Rank)
            {
                int count;
                if (c1.Rank > _gameCard.CountCards)
                {
                    count = _gameCard.CountCards;
                }
                else count = c1.Rank;

                Console.ReadKey();
                Console.WriteLine("{0} and {1} Draw!! ", _p1.Name, _p2.Name);
                //Console.WriteLine("Score {0}: {1} and Score {2}: {3}  ", _p1.Name,_p1.Score, _p2.Name,_p2.Score);
                //Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards/2);
                if (_gameCard.CountCards != 0)
                {
                    c11 = _gameCard.DealCard();
                    c21 = _gameCard.DealCard();
                    Console.WriteLine("{0} has {1}\n{2} has {3}", _p1.Name, c11,_p2.Name, c21);
                    
                    if (c11.Rank == c21.Rank)
                    {
                        _gameCard.ReturnCard(c1, c2, c11, c21);
                      
                        Console.WriteLine("{0} and {1} Draw Again!! ", _p1.Name, _p2.Name);
                       // Console.WriteLine("Score {0}: {1} and Score {2}: {3}  ", _p1.Name, _p1.Score, _p2.Name, _p2.Score);
                       // Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards/2);
                        if (_gameCard.CountCards != 0)
                        {
                            c1 = _gameCard.DealCard();
                            c2 = _gameCard.DealCard();

                            Console.WriteLine("{0} has {1}\n{2} has {3}", _p1.Name, c11, _p2.Name, c21);
                        }
                        else _isEnd = true;
                    }
                    else if (c11.Rank < c21.Rank)
                    {
                        _p1.Score += (c1.Rank + 1) * 2;
                        Console.WriteLine("{0} Win!! Score: {1} ", _p1.Name, _p1.Score);
                        Console.WriteLine("{0} Lose!! Score: {1} ", _p2.Name, _p2.Score);
                        
                        
                        for(int i=1;i<count*2;i++)
                        {
                            c11 = _gameCard.DealCard();
                        }
                        Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards / 2);
                        break;

                    }
                    else if (c11.Rank > c21.Rank)
                    {
                        _p2.Score += (c1.Rank+1)*2;
                        Console.WriteLine("{0} Win!! Score: {1} ", _p2.Name, _p2.Score);
                        Console.WriteLine("{0} Lose!! Score: {1} ", _p1.Name, _p1.Score);
                        
                        for (int i = 1; i < count*2; i++)
                        {
                            c11 = _gameCard.DealCard();
                        }
                        Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards / 2);
                        break;
                    }
                }
                else _isEnd = true;
            }
            if (c1.Rank < c2.Rank)
            {
                _p1.Score+=sum;
                Console.WriteLine("{0} Win!! Score: {1} ", _p1.Name, _p1.Score);
                Console.WriteLine("{0} Lose!! Score: {1} ", _p2.Name, _p2.Score);
                Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards/2);

            }
            else if (c1.Rank > c2.Rank)
            {
                _p2.Score+=sum;
                Console.WriteLine("{0} Win!! Score: {1} ", _p2.Name, _p2.Score);
                Console.WriteLine("{0} Lose!! Score: {1} ", _p1.Name, _p1.Score);
                Console.WriteLine("Amount of remained cards in Player's Deck: {0}", _gameCard.CountCards/2);

            }
        }
        public void PlayGame()
        {
            Console.Write("First Player: ");
            _p1.Name = Console.ReadLine();
            Console.Write("Second Player: ");
            _p2.Name = Console.ReadLine();
            Cards c1 = new Cards();
            Cards c2 = new Cards();
            while (!_isEnd)
            {
               
                if (_gameCard.CountCards != 0)
                {
                    c1 = _gameCard.DealCard();
                    c2 = _gameCard.DealCard();
                    Console.WriteLine("{0} has {1}\n{2} has {3}", _p1.Name, c1, _p2.Name, c2);
                    CompareCards(c1, c2);
                    Console.ReadKey();
                    Console.WriteLine("\n");
                }
                else _isEnd = true;
            }
            EndGame();

        }
        public void EndGame()
        {
            
                Console.WriteLine("----------------End Game-----------------\n");
                if (_p1.Score > _p2.Score)
                {
                    Console.WriteLine("{0} Win!!", _p1.Name);
                }
                else if (_p1.Score < _p2.Score)
                {
                    Console.WriteLine("{0} Win!!", _p2.Name);
                }

            
        }
    }
}
