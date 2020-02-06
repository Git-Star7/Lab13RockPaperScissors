using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    abstract class Player
    {
        //fields
        //properties
        public string Name { get; set; }
        public Roshambo Attack { get; set; }
        //constructors

        //methods
        public abstract Roshambo GenerateRoshambo();
    }
}
