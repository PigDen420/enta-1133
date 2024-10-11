using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiceGame
{
    internal class GameManager
    {
        internal void PlayGame()
        {
            bool playerTurn = false; //assign bool
            bool cpuTurn = false;

            Console.WriteLine("Give me your name!");

            string x = Console.ReadLine();

            Console.WriteLine("Hello, ", x, "Let's roll");

            Console.WriteLine("Whoever gets the most highest rolls after all 4 rounds wins the game")

            Console.WriteLine("\nDo you want to go first?");
            string reply = Console.ReadLine(); //Whatever you type in is assigned to the string variable. It's like choosing what you want to store in the box

            if (reply == "yes") //This is expecting that if you typed in "yes", so this limits what you can say in the string reply variable; == means comparison
            {
                Console.WriteLine("\nYour turn");
                playerTurn = true; //This is how you activate the bool
            }
            else
            {
                Console.WriteLine("\nCPU turn");
                cpuTurn = true;
            }

            Console.WriteLine("Welcome to Die vs Die!\nLet's roll!");

            while (x < 10000)
            {
                successiveAttempts = 0;
                while (successiveAttempts < 2)
                {
                    diceRoll = numGen.Next(1, 7);
                    if (diceRoll == 6)
                    {
                        successiveAttempts++;
                    }
                    else
                    {
                        successiveAttempts = 0;
                    }
                    attempts++;
                }
                x++;
            }
            int percentage = attempts / x;

            Console.WriteLine(percentage);
            Console.WriteLine(attempts);
            Console.ReadKey();
        }

        /*DiceRoller fourSidedDie = new DiceRoller(); // This is how you put made classes into the program
        fourSidedDie.numberOfSides = 4; //x.y = variable inside a variable. The same "sub-variable" in different variables act independently
        int dieValue = fourSidedDie.Roll(); //Using what is in the DiceRoller class to assign the variable; rolls using numbers that can only go up to what is assigned 


        DiceRoller sixSidedDie = new DiceRoller();
        sixSidedDie.numberOfSides = 6;
        dieValue = sixSidedDie.Roll();

        DiceRoller tenSidedDie = new DiceRoller();
        tenSidedDie.numberOfSides = 10;
        dieValue = tenSidedDie.Roll();

        DiceRoller twentySidedDie = new DiceRoller();
        twentySidedDie.numberOfSides = 20;
        dieValue = twentySidedDie.Roll(); */

        public class GameManager
            }
    private void DetermineStart(); {

    }
    private void DoNextTurn(); {
    }
    private bool DidPlayerWin(); {

    int playerScore = 0;
    int cpuScore = 0;

    if (playerScore > cpuScore)
    {
        Console.WriteLine(x "wins");
        playerScore +

    } else if (playerScore = cpuScore) {

        Console.WriteLine("It's a tie! Roll again!");

    } else {

        Console.WriteLine("CPU wins");

    }
}

            Console.ReadLine();
            //Console.WriteLine($"Rolled a {fourSidedDie.d4} sided die for a result of {randomD4Roll}");
            //Console.WriteLine($"Rolled a {sixSidedDie.d6} sided die for a result of {randomD6Roll}");
            //Console.WriteLine($"Rolled a {tenSidedDie.d10} sided die for a result of {randomD10Roll}");
            //Console.WriteLine($"Rolled a {twentySidedDie.d20} sided die for a result of {randomD20Roll}");
        }

    }
}
