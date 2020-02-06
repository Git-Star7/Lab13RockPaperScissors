using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class RandomPlayer : Player
    {

        public RandomPlayer()
        {
            Name = "randy";
        }
        public override Roshambo GenerateRoshambo()
        {
            Random r = new Random();
            int randomNum = r.Next(0, 3);
            return (Roshambo)Enum.Parse(typeof(Roshambo), randomNum.ToString());
        }
    }
}
