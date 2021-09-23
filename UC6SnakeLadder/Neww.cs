using System;
using System.Collections.Generic;
using System.Text;

namespace UC6SnakeLadder
{
    public class neww
    {

        public static int RollDice()
        {
            Random random = new Random();
            int diceValue = random.Next(1, 7);
            return diceValue;
        }


        public static int getOptions()
        {
            Random random = new Random();
            int Opt = random.Next(0, 3);
            return Opt;
        }
    }
}
