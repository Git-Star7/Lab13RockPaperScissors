using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Validator
    {
        public static string ValidAttack()
        {
            string input = "";
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input == Roshambo.rock.ToString() || input == Roshambo.paper.ToString() || input == Roshambo.scissors.ToString())
                {
                    valid = true;
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. rock/paper/scissors");
                }
            }
            return input;
        }

        public static string ValidPlayer()
        {
            string input = "";
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input == "rocky" || input == "randy" || input == "p2")
                {
                    valid = true;
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. rocky/randy");
                }
            }
            return "";
        }
    }
}
