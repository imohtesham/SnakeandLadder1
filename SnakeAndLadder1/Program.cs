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
            int Player1reach = 0;
            int lastposition = 100;

            string[] Options = { "Snake", "Ladder", "rest" };


            if (Playerreach < firstPosition)
            {
                Player1reach = firstPosition;
            }
            Random random = new Random();
            int PlayerdiceROll = random.Next(1, 7);
            Console.WriteLine("player One dice number is :" + PlayerdiceROll);
            int Player_1 = random.Next(0, 3);

            if (Player_1 == 1)
            {
                Console.WriteLine("Player_1 got: " + Options[Player_1]);
                Player1reach = PlayOption(PlayerdiceROll, Player1reach, Player_1, lastposition);
                Console.WriteLine("player one roll again if ladder came");
                Console.WriteLine("Position reached by player 1 after diceroll :" + Player1reach + "/n");
            }
        }
    }      
}