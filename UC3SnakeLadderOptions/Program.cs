using System;

namespace UC3SnakeLadderOptions
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
            int option = neww.getOptions();
            Console.WriteLine("Option is : " + option);

            switch (option)
            {
                case 2:
                    position = position + dice;
                    break;
                case 1:
                    if (position == 0)
                        position = 0;
                    else
                    position = position - dice;
                    break;
                default:
                    position = position;
                    break;
            }
            Player1 = position;
            Console.WriteLine("Player Position is : " + Player1);





        }
    }
}
