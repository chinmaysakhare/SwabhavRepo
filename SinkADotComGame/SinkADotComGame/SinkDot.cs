using System;
namespace SinkADotComGame
{
    class SinkDot
    {
        int[,] grid = new int[7, 7];
        int[] arrayOne = new int[9];
        int[] arrayTwo = new int[9];
        int[] finalArray = new int[9];
        int arrayOneCounter = 0, mainCounter = 0, arrayTwoCounter = 0, tempCount = 9, killCount = 3;
        string guess;
        static void Main(string[] args)
        {
            SinkDot obj = new SinkDot();
            obj.MainPage();
        }
        public void MainPage()
        {
            Console.WriteLine("\n\n\t\t\t\tWelcome to Sink a DotCom\n\n");
            Console.WriteLine("\t\t\t\t\t MAIN MENU");
            Console.WriteLine(" 1. Start game\n 2. Rules\n 3. Exit Game");
            int option = Convert.ToInt32(Console.ReadLine());
            const int START = 1; const int RULES = 2; const int EXIT = 3;
            switch (option)
            {
                case START: Logic();
                    break;
                case RULES: Rules();
                    break;
                case EXIT: Console.WriteLine("\t\t\t\t Terminating");
                           System.Environment.Exit(0);
                     break;
                default: Console.WriteLine(" Invalid Input. Select Again.");
                    MainPage();
                    break;
            }
        }
        public void Rules()
        {
            Console.WriteLine("\n\n It’s you against the computer, but unlike the real Battleship game, in this one you don’t place any ships of your own. \n Instead, your job is to sink the computer’s ships in the fewest number of guesses.\n Oh, and we aren’t sinking ships.We’re killing Dot Coms.");
            Console.WriteLine("\n\n GOAL:\n Sink all of the computer’s Dot Coms in the fewest number of guesses.\n You’re given a rating or level, based on how well you perform. ");
            Console.WriteLine("\n\n SETUP:\n When the game program is launched, the computer places three Dot Coms on a virtual 7 x 7 grid.\n When that’s complete, the game asks for your first guess. ");
            Console.WriteLine("\n\n HOW TO PLAY:\n The computer will prompt you to enter a guess (a cell), that you’ll type at the command-line as “A3”, “C5”, etc.).\n In response to your guess, you’ll see a result at the command-line, either “Hit”, “Miss”, or “You killed.\n When you’ve sent all three Dot Coms to that big 404 in the sky, the game ends by printing out your rating.");
            Console.WriteLine("\n\n\t\t\t\t\t PRESS ANY KEY FOR MAIN MENU");
            Console.ReadLine();
            MainPage();
        }
        public void Logic()
        {
            PlaceDotComsRowWise();
            PlaceDotComsColWise();
            PlaceDotComsRandomly();
            CreateIndexes();
            Console.WriteLine(" Three DotComs have been Placed. Ready to HIT or MISS?");
            /*for (i = 0; i < 9; i++)
            {
                Console.WriteLine(finalArray[i]);
            }*/
            GuessDotComs();
            /* for (i = 0; i < 7; i++)
             {
                 Console.WriteLine();
                 for (int j = 0; j < 7; j++)
                 {
                     Console.Write(" " + grid[i, j];
                 } 
              }
             Console.ReadLine();
            for (i = 0; i < 9; i++)
            {
                Console.Write(arrayOne[i]);
                Console.Write(arrayTwo[i]);
                Console.WriteLine("\n");
            }*/
            Console.ReadLine();

        }
        public void GuessDotComs()
        {
            Console.WriteLine("\n Enter the guess again"); 
            guess = Console.ReadLine();
            mainCounter++;
            int temp;
            char chOne = guess[0];
            char chTwo = guess[1];
            int indexTwo = (int)Char.GetNumericValue(chTwo);
            indexTwo = indexTwo - 1;
            int indexOne = GetCodeValue(chOne);
            //Console.WriteLine(indexOne+""+indexTwo);
            //Console.ReadLine();
            //CompareIndexes(indexOne,indexTwo);
            temp = indexOne * 10 + indexTwo;
            CompareIndexes(temp);
        }
        public void CompareIndexes(int check)
        {
            for (int i = 0; i < 9; i++)
            {
                if (check == finalArray[i])
                {
                    Console.WriteLine(" Congratulations you hit a DotCom");
                    tempCount--;
                    Console.WriteLine(" You Gotta Hit " + tempCount + " more cells to win!");
                    if (tempCount == 6||tempCount==3)
                    {
                        killCount--;
                        Console.WriteLine("\n\n\t\t\t\t Congratulations you Killed a DotCom\n\t\t\t\t\t Kill "+ killCount + " DotComs more to win");
                    }
                    finalArray[i] = 0;
                    if (tempCount == 0)
                    { Score(); }
                }
            }
            GuessDotComs();
        }
        public void Score()
        {
            Console.WriteLine("\n\n\t\t\t\t Congratulations You killed all the DotComs");
            Console.WriteLine("\n\n\t\t\t\t You Killed all the DotComs in " + mainCounter + " turns");
            if (mainCounter < 18)
            {
                Console.WriteLine("\n\n\t\t\t\t Woah!! You are a Pro.");
            }
            else if (mainCounter < 30)
            {
                Console.WriteLine("\n\n\t\t\t\t Guessed them just right");
            }
            else if (mainCounter < 50)
            {
                Console.WriteLine("\n\n\t\t\t\t I Got bored Counting your Score");
            }
            Console.WriteLine("\n Press any key to return to main menu");
            Console.ReadLine();
            MainPage();
        }
        public void CreateIndexes()
        { int temp;
            for (int i = 0; i < 9; i++)
            {
                temp = arrayOne[i] * 10 + arrayTwo[i];
                finalArray[i] = temp;
            }
        }
        public int GetCodeValue(char character)
        {
            int temp,value=0;
            temp = Convert.ToInt32(character);
            if (temp == 97 || temp == 65)
                value = 0;
            else if (temp == 98 || temp == 66)
                value = 1;
            else if (temp == 99 || temp == 67)
                value = 2;
            else if (temp == 100 || temp == 68)
                value = 3;
            else if (temp == 101 || temp ==69)
                value = 4;
            else if (temp == 102 || temp == 70)
                value = 5;
            else if (temp == 103 || temp == 71)
                value = 6;
            return value;
        }
        public void PlaceDotComsRowWise()
        {
            Random num = new Random();
            int cNum = num.Next(0, 3);
            int rNum = num.Next(0, 3);
            int count = 3;
            if (rNum < 5)
            {
                while (count > 0)
                {
                    grid[cNum, rNum] = 1;
                    arrayOne[arrayOneCounter] = cNum;
                    arrayTwo[arrayTwoCounter] = rNum;
                    arrayOneCounter++; arrayTwoCounter++;
                    rNum++;
                    count--;
                }
            }
            if (rNum > 4)
            {
                while (count > 0)
                {
                    grid[cNum, rNum] = 1;
                    arrayOne[arrayOneCounter] = cNum;
                    arrayTwo[arrayTwoCounter] = rNum;
                    arrayOneCounter++; arrayTwoCounter++;
                    rNum--;
                    count--;
                }
            }
        }
        public void PlaceDotComsColWise()
        {
            Random no = new Random();
            int cnNum = no.Next(4, 6);
            int roNum = no.Next(0, 6);
            int count = 3;
            if (cnNum < 5)
            {
                while (count > 0)
                {
                    grid[cnNum, roNum] = 1;
                    arrayOne[arrayOneCounter] = cnNum;
                    arrayTwo[arrayTwoCounter] = roNum;
                    arrayOneCounter++; arrayTwoCounter++;
                    cnNum++;
                    count--;
                }
            }
            if (cnNum > 4)
            {
                while (count > 0)
                {
                    grid[cnNum, roNum] = 1;
                    arrayOne[arrayOneCounter] = cnNum;
                    arrayTwo[arrayTwoCounter] = roNum;
                    arrayOneCounter++; arrayTwoCounter++;
                    cnNum--;
                    count--;
                }
            }
        }
        public void PlaceDotComsRandomly()
        {
            Random num = new Random();
            int randomNum = num.Next(1, 2);
            if (randomNum == 1)
            {
                int cNum = num.Next(0, 6);
                int rNum = num.Next(3, 6);
                int count = 3;
                if (rNum < 5)
                {
                    while (count > 0)
                    {
                        grid[cNum, rNum] = 1;
                        arrayOne[arrayOneCounter] = cNum;
                        arrayTwo[arrayTwoCounter] = rNum;
                        arrayOneCounter++; arrayTwoCounter++;
                        rNum++;
                        count--;
                        
                    }
                }
                if (rNum > 4)
                {
                    while (count > 0)
                    {
                        grid[cNum, rNum] = 1;
                        arrayOne[arrayOneCounter] = cNum;
                        arrayTwo[arrayTwoCounter] = rNum;
                        arrayOneCounter++; arrayTwoCounter++;
                        rNum--;
                        count--;
                        
                    }
                }
            }
            else if (randomNum == 2)
            {
                Random no = new Random();
                int cnNum = no.Next(0, 3);
                int roNum = no.Next(0, 6);
                int count = 3;
                if (cnNum < 5)
                {
                    while (count > 0)
                    {
                        grid[cnNum, roNum] = 1;
                        arrayOne[arrayOneCounter] = cnNum;
                        arrayTwo[arrayTwoCounter] = roNum;
                        arrayOneCounter++; arrayTwoCounter++;
                        cnNum++;
                        count--;
                        
                    }
                }
                if (cnNum > 4)
                {
                    while (count > 0)
                    {
                        grid[cnNum, roNum] = 1;
                        arrayOne[arrayOneCounter] = cnNum;
                        arrayTwo[arrayTwoCounter] = roNum;
                        arrayOneCounter++; arrayTwoCounter++;
                        cnNum--;
                        count--;
                        
                    }
                }

            }
        }


    }
}







/*
 *  const int A = 0; const int B = 1; const int C = 2; const int D = 3; const int E = 4; const int F = 5; const int G = 6;
    const int a = 0; const int b = 1; const int c = 2; const int d = 3; const int e = 4; const int f = 5; const int g = 6;
 * 
 * 
 * 
 */