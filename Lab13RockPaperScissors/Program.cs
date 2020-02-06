using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(GetUserInput("Enter your name: "));
            bool continueLoop = true;
            while (continueLoop)
            {
                RoshamboApp rockPaperScissors = new RoshamboApp();
                Console.Write("Select an enemy, rocky/randy: ");
                rockPaperScissors.SelectEnemy();

                Console.Write("Player 1: rock, paper or scissors?: ");
                Roshambo p1Attack = user.GenerateRoshambo();
                Roshambo p2Attack = rockPaperScissors.enemySelection.Attack;
                Console.WriteLine($"Enemy threw: {Enum.GetName(typeof(Roshambo), p2Attack)}");
                string result = EvaluateMatch(p1Attack, p2Attack);

                Console.WriteLine(result);
            }        
        }

        public static string EvaluateMatch(Roshambo userAttack, Roshambo enemyAttack)
        {

            if (userAttack == Roshambo.paper && enemyAttack == Roshambo.rock)
            {
                return "yay";
            }
            return "yo";
        }

        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int GetUserInt(string message)
        {
            int num = 0;
            try
            {
                num = int.Parse(GetUserInput(message));
            }
            catch
            {
                GetUserInt(message);
            }
            return num;
        }

        public static bool YesOrNo(string message, string yes, string no)
        {
            string userContinue = null;
            while (userContinue != yes && userContinue != yes)
            {
                Console.Write(message);
                userContinue = Console.ReadLine().ToLower();

                if (userContinue == no)
                {
                    Console.WriteLine("Okay!!");
                    return false;
                }
            }
            return true;
        }


    }
}
