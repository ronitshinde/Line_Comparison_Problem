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
            LineComparison compare = new LineComparison(15, 24, 17, 8);
            compare.CompareTwoLines();
            Console.ReadKey();
        }
    }
}
