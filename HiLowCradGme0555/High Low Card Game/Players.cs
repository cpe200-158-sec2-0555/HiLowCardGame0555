using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Card_Game
{
    class Players
    {
        private string _name;
        private int _score=0;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        public Players()
        {
            Name = "XXXXXXX";

        }
        public Players(string n)
        {
            Name = n;
        }
    }
}
