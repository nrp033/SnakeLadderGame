namespace SnakeLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t ****Welcome To Snake and Ladder Game****");

            Console.WriteLine("\n GAME STARTED\n");

            int Position = 0;
            Console.WriteLine("Player Position :  "+Position);

            Console.Write("\nPress Enter To Roll Dice : ");
            Console.ReadKey();

            Random rd = new Random();   
            int RollDice=rd.Next(1,7);

            Console.WriteLine("\nDice Roll :  "+RollDice);


            Console.ReadKey();
        }
    }
}