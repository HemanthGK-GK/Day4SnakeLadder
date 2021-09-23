using System;
using System.Collections.Generic;
using System.Text;

namespace UC2SnakeLadder
{
    public class neww
    {

        public static int RollDice()
        {
            Random random = new Random();
            int diceValue = random.Next(1, 7);
            return diceValue;
        }

    }
}
