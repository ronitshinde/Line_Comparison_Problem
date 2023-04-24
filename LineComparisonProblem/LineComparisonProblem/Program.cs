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
            LineComparison lineOne = new LineComparison(15, 14, 17, 8);
            double lineLengthOne = lineOne.CompareTwoLines();
            Console.WriteLine($"Length of the line one : {lineLengthOne}");
            LineComparison lineTwo = new LineComparison(25, 3, 15, 21);
            double lineLengthTwo = lineTwo.CompareTwoLines();
            Console.WriteLine($"Length of the line two : {lineLengthTwo}");
            if(lineLengthOne.Equals(lineLengthTwo))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both lines are unequal");
            Console.ReadKey();
        }
    }
}
