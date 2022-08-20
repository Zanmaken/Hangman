using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Player
    {
        //Test change for player class
        //Test change 2
        string name;
        int currentScore = 0;
        long highscore = 0;
        int lives = 3;
        int hotstreak = 0;
        int highestRoundHotstreak = 0;
        int highestHotstreak = 0;

        public Player(string name)
        {
            this.name = name;           
        }
    }
}
