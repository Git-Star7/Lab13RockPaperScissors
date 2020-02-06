using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "rocky";
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
