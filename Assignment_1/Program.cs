using System;

namespace MeetSheth
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want to run this program ?");
            int n = Convert.ToInt32(Console.ReadLine());

            double f;
            int negativecount = 0, positivecount = 0, zeros = 0;
            double minValue = 0, maxValue = 0, zero = 0;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter the 4 consequent values of x");

                Console.WriteLine("Enter the value of x");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of x1");
                int x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of x2");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of x3");
                int x3 = Convert.ToInt32(Console.ReadLine());


                if (x >= x1 && x <= x2)
                {
                    f = (x - x1) / (x2 - x1) * (x3 - x1);
                    Console.WriteLine("The value of 'f' is: " + f);
                }
                else if (x > x2 && x <= x3)
                {
                    f = (x - x1) / (x2 - x1) * (x2 - x1);
                    Console.WriteLine("The value of 'f' is: " + f);
                }
                else
                {
                    f = x3;
                    Console.WriteLine("The value of 'f' is: " + f);
                }



                if (f < zero)
                {
                    negativecount++;
                    Console.WriteLine("'f' came out negative " + negativecount + " times");

                }
                else if (f == 0)
                {
                    zeros++;
                    Console.WriteLine("'f' came out zero " + zeros + " times");
                }
                else
                {
                    positivecount++;
                    Console.WriteLine("'f' came out positive " + positivecount + " times");
                }

                if (f < minValue)
                {
                    minValue = f;
                }
                if (f > maxValue)
                {
                    maxValue = f;
                }
            }

            Console.WriteLine("Minimum value of 'f' was " + minValue);
            Console.WriteLine("Maximum value of 'f' was " + maxValue);
            Console.WriteLine("'f' came out negative " + negativecount + " times");
            Console.WriteLine("'f' came out positive " + positivecount + " times");
            Console.WriteLine("'f' came out zero " + zeros + " times");
        }
    }
}
