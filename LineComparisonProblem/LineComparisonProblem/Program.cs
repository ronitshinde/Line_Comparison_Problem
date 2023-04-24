using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LineComparison lineOne = new LineComparison(5, 1, 7, 4);
            double lineLengthOne = lineOne.CompareTwoLines();
            Console.WriteLine($"Length of the line one : {lineLengthOne}");
            LineComparison lineTwo = new LineComparison(15, 14, 17, 8);
            double lineLengthTwo = lineTwo.CompareTwoLines();
            Console.WriteLine($"Length of the line two : {lineLengthTwo}");
            if (lineLengthOne.CompareTo(lineLengthTwo) == 0)
                Console.WriteLine("Both lines are equal");
            else if (lineLengthOne.CompareTo(lineLengthTwo) > 0)
                Console.WriteLine($"Lenght of line one : {lineLengthOne} is greater than lenght of line two : {lineLengthTwo}");
            else
                Console.WriteLine($"Lenght of line one : {lineLengthOne} is lesser than length of line two : {lineLengthTwo}");
            Console.ReadKey();
        }
    }
}
