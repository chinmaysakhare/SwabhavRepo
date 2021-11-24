using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            UpdateScoreToZero(score);
            Console.WriteLine(score);
            int[] manyScores = {70, 80, 90, 100};
            UpdateManyScoreToZero(manyScores);
            foreach (int s in manyScores)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
        static void UpdateScoreToZero(int p)
        {
            p = 0;
         }
        static void UpdateManyScoreToZero(int[] pscores)
        {
            for(int s=0;s<pscores.Length;s++ )
            {
                pscores[s] = 0;
                
            }
        }
    }
}
