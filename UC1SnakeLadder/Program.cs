using System;

namespace UC1SnakeLadder
{
    public class SnakeLadder
    {
        static void Main(string[] args)
        {
            int position = 0;
            int Max = 100;
            int Player1 = 0;

            int dice = neww.RollDice();
            Console.WriteLine("Dice value is : " + dice);
            int option= neww.getOptions();

            if (option == 2)
                position = position + dice;
            else if (option == 1)
                position = position - dice;
            else
                position = position;




        }
    }
}
