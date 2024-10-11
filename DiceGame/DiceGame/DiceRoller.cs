using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    
    internal class DiceRoller
    {
        internal int numberOfSides = 6;


        Random randomNumberGenerator = new Random();



        internal int Roll()
        {
         //(1-7)
         //(1-5)
         //(1-11)
         //(1-21)
            int randomRoll = randomNumberGenerator.Next(1, numberOfSide + 1);
            return randomRoll;
        }
    }
}
