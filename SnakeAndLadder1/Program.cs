﻿namespace SnakeAndLadder1
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int firstPosition = 0;
            int Playeroneposition = firstPosition;

            string[] Options = { "Snake", "Ladder", "rest" };


            if (Playeroneposition < firstPosition)
            {
                Playeroneposition = firstPosition;
            }
            int Player_1 = 0;

            if (Player_1 == Playeroneposition)
            { 
                Playeroneposition = firstPosition;  
            }

        }
    }
}