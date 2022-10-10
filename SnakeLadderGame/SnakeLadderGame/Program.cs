namespace SnakeLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t****  Welcome To Snake and Ladder Game  ****");

            Console.WriteLine("\n\t\t GAME STARTED\n");

            int playerPosition = 0;

            const int Ladder = 1;
            const int Snake = 2;
            const int WinPoint = 100;
            Console.WriteLine("Player Position :  " + playerPosition);

            while (playerPosition <= WinPoint)
            {
                Random rd = new Random();
                int rolldice = rd.Next(1, 7);
                Console.WriteLine(" Dice Roll : " + rolldice);
                int option = rd.Next(0, 3);
                switch (option)
                {
                    case Ladder:
                        Console.WriteLine(" It's Ladder ! ");
                        playerPosition = playerPosition + rolldice;
                        break;
                    case Snake:
                        Console.WriteLine(" Snake Bite !");
                        playerPosition = playerPosition - rolldice;
                        break;

                    default:
                        Console.WriteLine(" No Play !");

                        break;
                }
                Console.WriteLine("Current Player Position :   " + playerPosition);
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }

            }
            Console.ReadLine();

        }
    }
}