using System;

/*
As a fan of geometry, I want to model a line based on a point consisting of (x, y) co-ordinates
using the Cartesian system, So that I can calculate its length.
- A Length as 2 Points (x1, y1) and(x2, y2)
- Length of a Line = sqrt( (x2 - x1) ^2 + (y2 - y1) ^ 2)
*/

namespace uc1_LengthOfLine
{
    class Program
    {
        public static double Distance (double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt (temp1 + temp2);
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

            var finalResult = Distance(x1, y1, x2, y2);
            Console.WriteLine("Distance between two points ({0},{1}) and ({2},{3}) is {4:F}", x1, y1, x2, y2, finalResult);

        }
    }
}
