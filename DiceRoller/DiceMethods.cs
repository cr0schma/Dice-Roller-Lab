using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class DiceMethods
    {
        public static int ReturnRandomNumber(int sides)
        {
            var ran = new Random();
            int ranResult = ran.Next(1, sides + 1);
            return ranResult;
        }
        public static string ReturnValidCombination(int die1, int die2)
        {
            string nickName = string.Empty;
            int dieTotal = die1 + die2;
            if (dieTotal == 2)
            {
                nickName = "Snake Eyes!";
            }
            else if (dieTotal == 3)
            {
                nickName = "Ace Deuce!";
            }
            else if (dieTotal == 6) 
            {
                nickName = "Box Cars!";
            }
            else
            {
            }
            return nickName;
        }
        public static string ReturnValidCombination2(int die1, int die2)
        {
            string nickName = string.Empty;
            int dieTotal = die1 + die2;
            if (dieTotal == 7 || dieTotal == 11)
            {
                nickName = "Win!";
            }
            else if (dieTotal == 2 || dieTotal == 3 || dieTotal == 12)
            {
                nickName = "Craps!";
            }
            else
            {
            }
            return nickName;
        }
    }
}
