﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public int DieRoll()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
        public void Play()
        {

        }
    }
}