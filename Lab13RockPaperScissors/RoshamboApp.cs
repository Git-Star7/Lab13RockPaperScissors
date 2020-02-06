using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class RoshamboApp
    {
        public Player enemySelection;

        RockPlayer rocky = new RockPlayer();
        RandomPlayer randy = new RandomPlayer();
        User user = null;

        public void SelectEnemy()
        {
            string input = Validator.ValidPlayer();

            if (input.ToString() == randy.Name)
            {
                enemySelection = randy;
                randy.Attack = randy.GenerateRoshambo();
            }
            else if (input.ToString() == rocky.Name)
            {
                enemySelection = rocky;
                rocky.Attack = rocky.GenerateRoshambo();
            }
            else if (input.ToString() == "p2")
            {
                Console.Write("Player 2 Name: ");
                user = new User(Console.ReadLine());
                enemySelection = user;
                Console.Write("Player 2, rock/paper/scissors: ");
                user.Attack = user.GenerateRoshambo();
            }
        }
    }
}
