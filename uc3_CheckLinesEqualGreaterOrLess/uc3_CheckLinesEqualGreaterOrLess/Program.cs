using System;

/*
As a fan of geometry, I want to compare two lines based on
the end points, So that I know one line is equal, greater or
less than the other line.
- Using C# compareTo method to compare 2 Lengths is preferable.
 */

namespace uc3_CheckLinesEqualGreaterOrLess
{
    class Program
    {
        public static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            var finalResult1 = Distance(x1, y1, x2, y2);


            Console.WriteLine("Please enter a1 and b1 coordinates: ");
            var a1 = Convert.ToDouble(Console.ReadLine());
            var b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2 and y2 coordinates: ");
            var a2 = Convert.ToDouble(Console.ReadLine());
            var b2 = Convert.ToDouble(Console.ReadLine());
            var finalResult2 = Distance(a1, b1, a2, b2);

            //Using C# compareTo method to compare 2 Lengths
            double status = finalResult1.CompareTo(finalResult2);
            if (status > 0)
            {
                Console.WriteLine("\n{0:f} is greater than {1:f}", finalResult1, finalResult2);
            }
            else if (status < 0)
            {
                Console.WriteLine("\n{0:f} is less than {1:f}", finalResult1, finalResult2);
            }
            else
            {
                Console.WriteLine("\n{0:f} is equal to {1:f}", finalResult1, finalResult2);
            }
            
            Console.WriteLine("Length of first Line = {0:f}", finalResult1);
            Console.WriteLine("Length of second Line = {0:f}", finalResult2);
        }
    }
}
