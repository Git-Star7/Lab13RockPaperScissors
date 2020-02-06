using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class User : Player
    {
        public User(string input)
        {
            Name = input;
        }
        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)Enum.Parse(typeof(Roshambo), Validator.ValidAttack());
        }
    }
}
