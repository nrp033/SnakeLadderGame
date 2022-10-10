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

            Console.WriteLine("Player Position :  " + playerPosition);

            Random rd = new Random();
            int rolldice = rd.Next(1, 7);

            Console.WriteLine("Dice Roll : " + rolldice);

            int option = rd.Next(0, 3);
            switch (option)
            {
                case Ladder:
                    Console.WriteLine(" Ladder :  " + rolldice);
                    playerPosition += rolldice;
                    break;

                case Snake:
                    Console.WriteLine(" Snake Bite :  -" + rolldice);
                    playerPosition -= rolldice;
                    break;

                default:
                    Console.WriteLine(" No Play !");

                    break;
            }
            Console.WriteLine("Current Player Position :   " + playerPosition);


            Console.ReadKey();
        }
    }
}