namespace SnakeAndLadder1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstPosition = 0;
            int Playerreach = firstPosition;
            Console.WriteLine("Snake and ladder begins \n");

            if (Playerreach < firstPosition)
            {
                Playerreach = firstPosition;
            }
            Random random = new Random();
            int PlayerOneROll = random.Next(1 , 7);
            Console.WriteLine("player One dice number is :" + PlayerOneROll);

            int Player_1 = random.Next(0,1) ;

            if (Player_1 == Playerreach)
            {
                Playerreach = firstPosition;  
            }

        }
    }
}