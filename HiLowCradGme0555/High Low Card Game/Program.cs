﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.PlayGame();
            Console.ReadKey();
            
        }
    }
}
