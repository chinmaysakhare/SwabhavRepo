using System;
namespace PigGameAdvanced
{
    class Program
    {
        int mainSum = 0;
        int count = 0;
        int turnSum = 0;
        int difficulty;
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.WelcomePage();
        }
        public void WelcomePage()
        {
            Console.WriteLine("\n\n\n\t\t\t\t\tWelcome to the PIGS game");
            Console.WriteLine("\n\n1. Start \n2. Rules \n3. Exit\n\n");
            int option = Convert.ToInt32(Console.ReadLine());
            mainSum = 0;
            turnSum = 0;
            count = 0;
            const int START = 1;
            const int RULES = 2;
            const int EXIT = 3;
            difficulty = 0;
            switch (option)
            {
                case START:Console.WriteLine("\t\t\t\t\t Select your difficulty\n1. Easy\n2. Medium\n3. Hard");
                    difficulty = Convert.ToInt32(Console.ReadLine());
                    if (difficulty > 0 && difficulty < 4)
                    { PigLogic(difficulty); }
                    else
                        Console.WriteLine("Invalid Choice");
                    break;
                case RULES:
                    DisplayRules();
                    break;
                case EXIT:
                    Console.WriteLine("Thankyou for playing\nPress any key to exit");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
        public void PigLogic(int diff)
        {
            mainSum = mainSum + turnSum;
            turnSum = 0;
            if (mainSum >= 20)
            {
                Console.WriteLine("\n\n\n\n\n\n\t\t\t\t Congratulations You win!\n\n\t\t\t\t You took " + count + " turn/s");
                Console.WriteLine("\t\t\t\t Your Total Score :" + mainSum);
                Console.WriteLine("Do you want to play again\n Press y to play again.\nPress any other key to exit");
                char ex = Convert.ToChar(Console.ReadLine());
                if (ex == 'y')
                    WelcomePage();
            }
            else if (mainSum < 20)
            {
                Console.WriteLine("\n\n New Turn! Ready to Roll? Press any key to Roll the die");
                Console.ReadLine();
                Console.WriteLine("\n\n Your Total Score :" + mainSum);
                count++;
                if (difficulty == 1)
                    TurnEasy(count);
                else if (difficulty == 2)
                    TurnMedium(count);
                else if (difficulty == 3)
                    TurnHard(count);
            }
        }
        public void TurnEasy(int count)
        {
            char opt;
        lbl:
            Console.WriteLine("\n\n\nTurn " + count + "\n======================================================================");
            int roll = GenerateNumber();
            if (roll == 1)
            {
                Console.WriteLine("OOps the dice Rolled a 1\nScore Reset to Zero\nTurn Ends!!");
                turnSum = 0;
                PigLogic(difficulty);
            }
            if (roll != 1)
            {
                int temp2 = mainSum;
                Console.WriteLine("Dice rolled a " + roll);
                turnSum = turnSum + roll;
                Console.WriteLine("Your Score for this turn is : " + turnSum);
                Console.WriteLine("Your Total Score is : " + (turnSum + temp2));
                Console.WriteLine("Do you want to roll the dice again? Roll or Hold?\n\npress 'r' to roll again or press 'h' to hold");
                opt = Convert.ToChar(Console.ReadLine());
                if (opt == 'r')
                {
                    bool opt3 = CheckMainSum(turnSum);
                    if (opt3)
                    {
                        goto lbl;
                    }
                    else
                    {
                        PigLogic(difficulty);
                    }
                }
                if (opt == 'h')
                {
                    PigLogic(difficulty);
                }
            }

        }
        public void TurnMedium(int count)
        {
            char opt;
        lbll:
            Console.WriteLine("\n\n\nTurn " + count + "\n======================================================================");
            int roll = GenerateNumber();
            if (roll >=1 && roll<=2)
            {
                Console.WriteLine("OOps the dice Rolled a " + roll + "\nScore Reset to Zero\nTurn Ends!!");
                turnSum = 0;
                PigLogic(difficulty);
            }
            if (roll >2)
            {
                int temp2 = mainSum;
                Console.WriteLine("Dice rolled a " + roll);
                turnSum = turnSum + roll;
                Console.WriteLine("Your Score for this turn is : " + turnSum);
                Console.WriteLine("Your Total Score is : " + (turnSum + temp2));
                Console.WriteLine("Do you want to roll the dice again? Roll or Hold?\n\npress 'r' to roll again or press 'h' to hold");
                opt = Convert.ToChar(Console.ReadLine());
                if (opt == 'r')
                {
                    bool opt3 = CheckMainSum(turnSum);
                    if (opt3)
                    {
                        goto lbll;
                    }
                    else
                    {
                        PigLogic(difficulty);
                    }
                }
                if (opt == 'h')
                {
                    PigLogic(difficulty);
                }
            }

        }
        public void TurnHard(int count)
        {
            char opt;
        lblll:
            Console.WriteLine("\n\n\nTurn " + count + "\n======================================================================");
            int roll = GenerateNumber();
            if (roll >=1 && roll<=3)
            {
                Console.WriteLine("OOps the dice Rolled a "+roll+"\nScore Reset to Zero\nTurn Ends!!");
                turnSum = 0;
                PigLogic(difficulty);
            }
            if (roll >= 4)
            {
                int temp2 = mainSum;
                Console.WriteLine("Dice rolled a " + roll);
                turnSum = turnSum + roll;
                Console.WriteLine("Your Score for this turn is : " + turnSum);
                Console.WriteLine("Your Total Score is : " + (turnSum + temp2));
                Console.WriteLine("Do you want to roll the dice again? Roll or Hold?\n\npress 'r' to roll again or press 'h' to hold");
                opt = Convert.ToChar(Console.ReadLine());
                if (opt == 'r')
                {
                    bool opt3 = CheckMainSum(turnSum);
                    if (opt3)
                    {
                        goto lblll;
                    }
                    else
                    {
                        PigLogic(difficulty);
                    }
                }
                if (opt == 'h')
                {
                    PigLogic(difficulty);
                }
            }

        }
        public bool CheckMainSum(int a)
        {
            int temp = a;
            int temp1 = mainSum;
            if (temp + temp1 < 20)
            {
                return true;
            }
            else
                return false;
        }
        public int GenerateNumber()
        {
            System.Random random = new System.Random();
            int diceNo = random.Next(1, 6);
            return diceNo;
        }
        public void DisplayRules()
        {
            Console.WriteLine("How to Play PIG?!\n\n\n\nEASY\n\n* See how many turns it takes you to get to 20.\n* Turn ends when you hold or roll a 1.\n* If you roll a 1, you lose all points for the turn.\n*If you hold, you save all points for the turn.\n\n\n Press Any key to continue");
            Console.WriteLine("\nMEDIUM\n\n* See how many turns it takes you to get to 20.\n* Turn ends when you hold or roll a 1 OR 2.\n* If you roll a 1 or 2, you lose all points for the turn.\n*If you hold, you save all points for the turn.\n\n\n Press Any key to continue");
            Console.WriteLine("\nHARD\n\n* See how many turns it takes you to get to 20.\n* Turn ends when you hold or roll a 1 OR 2 OR 3.\n* If you roll a 1,2 or 3, you lose all points for the turn.\n*If you hold, you save all points for the turn.\n\n\n Press Any key to continue");
            Console.ReadLine();
            WelcomePage();
        }
    }
}