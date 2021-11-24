using System;
class NumberGuessingGame
{
    public static void Main()
    {
        WelcomePage();
    }
    public static void WelcomePage()
    {
        Console.WriteLine("Number Guessing Games");
        Console.WriteLine("Choose One Option");
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Exit");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1: GameLogic();
                break;
            case 2: 
                break;
            default:Console.WriteLine("Invalid Input");
                break;
        }
    }
    public static void GameLogic()
    {
        System.Random random = new System.Random();
        int count = 0;
        int num = random.Next(1,100);
        Console.WriteLine("Choose any Number Between 1 and 100");
        int gNum = Convert.ToInt32(Console.ReadLine());
        label:
        do
        {
            if (gNum < num)
            {
                Console.WriteLine("Number is low. Try Again");
                Console.WriteLine("Select a number higher than your previous selection");
                gNum = Convert.ToInt32(Console.ReadLine());
                count++;
                goto label;
            }
            if (gNum > num)
            {
                Console.WriteLine("Number is High. Try Again");
                Console.WriteLine("Select a number lower than your previous selection");
                gNum = Convert.ToInt32(Console.ReadLine());
                count++;
                goto label;
            }
            if (gNum == num)
            {
                Console.WriteLine("You Guessed it Right. The Number was :" +num);
                Console.WriteLine("You Guessed it in "+count +" attempts");
                FinalScore(count);
                Console.WriteLine("Congratulations!!.You win!!");
                break;
            }

        }
        while (num == gNum);
        Console.WriteLine("Do You Want to Continue?? If yes HIT 1. Else HIT 0");
        int option2 = Convert.ToInt32(Console.ReadLine());
        if (option2 == 1)
        {
            WelcomePage();
        }
    }
    public static void FinalScore(int c)
    {
        int score = 100;
        c--;
        c = c*10;
        score = 100 - c;
        if (score != 0 && score>0)
        {
            Console.WriteLine("You Accuracy was: " + score + " %");
        }
        else
        {
            Console.WriteLine("You just Cleared the level. Took Too many Guesses.");
        }
    }
}