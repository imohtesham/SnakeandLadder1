namespace SnakeAndLadder1
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int firstPosition = 0;
            int Player1reach = firstPosition;

            string[] Options = { "Snake", "Ladder", "rest" };


            if (Player1reach < firstPosition)
            {
                Player1reach = firstPosition;
            }
            int Player_1 = 0;

            if (Player_1 == Player1reach)
            {
                Player1reach = 0;
                Console.WriteLine("Position reached by player 1 after diceroll :" + Player1reach + "/n");
            }

        }
    }
}