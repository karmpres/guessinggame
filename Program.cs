using System;
// This is basically a random number guessing game.
// There will be two players. First they will guess their number and then the number will be compared to see who is closer. The closer one wins.
// lets try no use class on this one, then the other one will use class.


namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int PlayerANum, PlayerBNum;

                Console.WriteLine("Player A, please guess a number from 1 to 10");
                PlayerANum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Player B, please guess a number from 1 to 10");
                PlayerBNum = Convert.ToInt32(Console.ReadLine());


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
