using SOLID.Interfaces;
using System.Collections.Generic;

namespace SOLID.Operations
{
    public class PerimeterOperations
    {
        public double SumPerimeters(IEnumerable<IHasPerimeter> shapes)
        {
            double perimeter = 0;

            foreach (var shape in shapes)
            {
                perimeter += shape.Perimeter();
            }

            return perimeter;
        }
    }
}
