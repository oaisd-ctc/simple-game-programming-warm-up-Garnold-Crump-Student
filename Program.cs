using System;
namespace MyProgram
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Rules();
            RoundOne();


        }
        public static void Rules()
        {
            Console.WriteLine("Dice Game");

            Console.WriteLine("In this game you and a computer Rival will play 10 rounds" + 
            " where you will each roll a 6-sided dice, and the player " + 
            "with the highest dice value will win the round. The player" + 
            " who wins the most rounds wins the game. Good luck!"
            );
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
        }
        public static void RoundOne()
        {
            int i = 1;



            int You = 0;
            int Rival = 0;

            for (i = 1; i < 11; i++)
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 6);
                Random rnd2 = new Random();
                int dice2 = rnd2.Next(1, 6);
                Console.WriteLine("Round " + i);
                Console.WriteLine("Rival Rolled a " + dice);
                Console.WriteLine("Press any key to roll the dice... ");
                Console.ReadKey();

                Console.WriteLine("You rolled a " + dice2);

                if (dice > dice2)
                {
                    Console.WriteLine("The Rival won this round");
                    Rival = Rival += 1;
                    Console.WriteLine("The score is now you  : " + You + ". " + "Rival  :" + Rival + ".");
                }
                else if (dice2 > dice)
                {
                    Console.WriteLine("You won this round");
                    You = You += 1;
                    Console.WriteLine("The score is now you  : " + You + ". " + "Rival  :" + Rival + ".");
                }
                else
                {
                    Console.WriteLine("This game is a draw");
                    Console.WriteLine("The score is now you  : " + You + ". " + "Rival  :" + Rival + ".");
                }

            }
            Console.WriteLine("Game Over");
            Console.WriteLine("The score is now you  : " + You + ". " + "Rival  :" + Rival + ".");
            if (You > Rival)
            {
                Console.WriteLine("You Won");
            }
            else if (Rival > You) { Console.WriteLine("Rival Won"); }
            else { Console.WriteLine("The Game ended in a draw"); }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dice Game was closed");

        }
    }
}