using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsKatas
{
    public static class Greed
    {

        public static int Score(int[] dice)
        {

            var score= 0;

            score += GetSingleScore(ref dice, 1);
            score += GetSingleScore(ref dice, 5);

            score += GetTrippletScore(ref dice, 1);
            score += GetTrippletScore(ref dice, 2);
            score += GetTrippletScore(ref dice, 3);
            score += GetTrippletScore(ref dice, 4);
            score += GetTrippletScore(ref dice, 5);
            score += GetTrippletScore(ref dice, 6);
            
            return score;
        }

        private static int GetSingleScore(ref int[] dice, int number)
        {
            var factor = number == 1 ? 100 : 50;

            var count = dice.Where(d => d.Equals(number)).Count();

            if (count < 3)
                return count * factor;

            var score = 0;

            while (count > 3)
            {
                score += factor;
                count--;
            }
            
            return score;
        }

        private static int GetTrippletScore(ref int[] dice, int number)
        {
            var factor = number == 1 ? 1000 : 100;
            
            if (dice.Where(d => d.Equals(number)).Count() >= 3)
                return factor * number;
            
            return 0;
        }

        
    }
}
