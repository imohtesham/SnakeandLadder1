namespace SnakeAndLadder1
{
    public class program
    {
        static int PlayOption(int diceroll, int diceposition, int option, int Endposition)
        {
            switch (option)
            {
                case 0:
                    diceposition -= diceroll;
                    break;
                case 1:
                    diceposition += diceroll;
                    break;
                default:
                    break;
            }
            return PlayOption(diceroll, diceposition, option, Endposition);

        }
        static int Endposition(int Playerreach, int lastposition, int Playerrolldice)
        {
            if (Playerreach > lastposition)
            {
                Playerreach = Playerrolldice;
            }
            return Playerreach;
        }
        static void Main(string[] args)
        {
            int firstPosition = 0;
            int lastposition = 10;
            Random random = new Random();
            Console.WriteLine("Snake and ladder started \n");

            string[] Options = { "Snake", "Ladder", "rest" };

            int Player1reach = firstPosition;
            int Player2reach = firstPosition;

            while (true)
            {
                if (Player1reach < firstPosition)
                {
                    Player1reach = firstPosition;
                }
                else if (Player2reach > firstPosition)
                {
                    Player2reach = firstPosition;
                }
                int PlayerOneROll = random.Next(1, 7);
                Console.WriteLine("player One dice number is :" + PlayerOneROll);
                int Player_1 = random.Next(0, 3);

                int PlayerTwoROll = random.Next(1, 7);
                Console.WriteLine("player Two dice number is :" + PlayerTwoROll);
                int Player_2 = random.Next(0, 3);

                if (Player_1 == 1)
                {
                    Console.WriteLine("Player_1 got: " + Options[Player_1]);
                    Player1reach = PlayOption(PlayerOneROll, Player1reach, Player_1, lastposition);
                    Console.WriteLine("player one roll again if ladder came");
                    Console.WriteLine("Position reached by player 1 after diceroll :" + Player1reach + "/n");
                }
                if (Player_2 == 1)
                {
                    Console.WriteLine("Player_2 got: " + Options[Player_2]);
                    Player2reach = PlayOption(PlayerOneROll, Player2reach, Player_2, lastposition);
                    Console.WriteLine("player two roll again if ladder came");
                    Console.WriteLine("Position reached by player 2 after diceroll :" + Player2reach + "/n");
                }
                if (Player1reach == lastposition)
                {
                    Console.WriteLine("Player_1 reached to :" + Player1reach + "/n Player_1 Won game");
                    break;
                }
                if (Player2reach == lastposition)
                {
                    Console.WriteLine("Player_2 reached to :" + Player2reach + "/n Player_2 Won game");
                    break;
                }
            }

            Console.ReadLine();
        }

    }
}