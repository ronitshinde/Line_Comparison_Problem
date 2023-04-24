using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineComparison
    {
        int x_One, x_Three, y_One, y_Two;
        //Constructor.
        //It does not have return type.
        public LineComparison(int x_One, int x_Two, int y_One, int y_Two)
        {
            this.x_One = x_One;
            x_Three = x_Two;
            this.y_One = y_One;
            this.y_Two = y_Two;
        }
        public double CompareTwoLines()
        {
            double length = Math.Sqrt(Math.Pow((x_Three - x_One), 2) + Math.Pow((y_Two - y_One), 2));
            return length;
        }
    }
}
