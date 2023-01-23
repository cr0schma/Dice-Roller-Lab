using DiceRoller;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

bool playagain = true;
do
{
    Console.WriteLine("Rolling a 6 sided pair of dice");
    int num = 6;

    Console.WriteLine("Ready to roll the dice? Press enter to continue, q to quit");
    string dicedecision = Console.ReadKey().Key.ToString();

    if (dicedecision == "Enter")
    {
        int firstDie = DiceMethods.ReturnRandomNumber(num);
        Console.WriteLine($"Your first dice rolled a {firstDie}");

        int secondDie = DiceMethods.ReturnRandomNumber(num);
        Console.WriteLine($"Your second dice rolled a {secondDie}");

        int dieTotal = firstDie + secondDie;

        Console.WriteLine($"That's for a total of {dieTotal}");

        string nickName = DiceMethods.ReturnValidCombination(firstDie, secondDie);
        if (nickName != "")
        {
            Console.WriteLine(nickName);
        }

        string nickName2 = DiceMethods.ReturnValidCombination2(firstDie, secondDie);
        if (nickName2 != "")
        {
            Console.WriteLine(nickName2);
        }

        Console.WriteLine();

        Console.WriteLine("Roll again? (y/n)");

        string answer = Console.ReadLine();

        if (answer == "y")
        {
            playagain = true;
        }
        else if (answer == "n")
        {
            Console.WriteLine("Goodbye!");
            playagain = false;
        }

        Console.WriteLine();
    }
    else if (dicedecision.ToUpper() == "Q")
    {
        playagain = false;
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
while (playagain);