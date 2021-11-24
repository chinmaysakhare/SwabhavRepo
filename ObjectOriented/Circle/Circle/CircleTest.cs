using System;


namespace Circle.Module
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy();    
        }
        public static void CaseStudy()
        {
            Circle cOne = new Circle(7.2f, "Green", "YELLOW");
            Circle cTwo = new Circle(5.9f, "blue;", "GREEN");
            Circle cThree = new Circle(9.48f, "red", "Blue");
            PrintDetails(cOne);
            PrintDetails(cTwo);
            PrintDetails(cThree);
            LargestCircle(cOne,cTwo,cThree);
        }
        public static void PrintDetails(Circle obj)
        {
            Console.WriteLine(obj.GetRadius());
            Console.WriteLine(obj.GetBorderColor());
            Console.WriteLine(obj.GetFillColor());
        }
        public static void LargestCircle(Circle a, Circle b, Circle c)
        {
            float lr, largestRadius;
            lr = a.GetRadius() > b.GetRadius() ? a.GetRadius() : b.GetRadius();
            largestRadius = c.GetRadius() > lr ? c.GetRadius() : lr;
            Console.WriteLine("The Largest Circle has Radius : " + largestRadius + "\nThe area is :" +(largestRadius*largestRadius*3.14));
            Console.ReadLine();        
        }
        /*public static void CaseStudy3()
        {
            Circle c = new Circle();
            c.SetRadius(7.2f);
            c.SetFillColor("green");
            c.SetBorderColor("red");
            Circle[] manyCircles = new Circle[3];
            manyCircles[0] = c;
            manyCircles[1] = new Circle();
            manyCircles[1].SetRadius(15.5f);
            manyCircles[1].SetBorderColor("blue");
            manyCircles[1].SetFillColor("red");
            manyCircles[2] = new Circle();
            manyCircles[2].SetRadius(20.2f);
            manyCircles[2].SetBorderColor("green");
            manyCircles[2].SetFillColor("blue");
            PrintDetails(manyCircles);
        }
        public static void CaseStudy2()
        {
            Console.WriteLine(new Circle().GetRadius());            //anonymous obj
            Console.WriteLine(new Circle().GetBorderColor());
            Console.WriteLine(new Circle().GetFillColor());
            PrintDetails(new Circle());
            Console.ReadLine();

        }
        public static void CaseStudy1()
        {
            Circle small = new Circle();
            small.SetRadius(5.5f);
            small.SetBorderColor("red");
            small.SetFillColor("green");
            PrintDetails(small);
            Circle big = new Circle();
            big.SetRadius(-0.5f);
            big.SetBorderColor("yellow");
            big.SetFillColor("GREEN");
            PrintDetails(big);
        }
        
        public static void PrintDetails(Circle []c )
        {
            for (int i = 0; i < c.Length;i++)
            {
                Console.WriteLine(c[i].GetRadius());
                Console.WriteLine(c[i].GetBorderColor());
                Console.WriteLine(c[i].GetFillColor());
                Console.ReadLine();
            }
        }*/



    }
}

