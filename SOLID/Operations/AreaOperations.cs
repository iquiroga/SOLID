using SOLID.Interfaces;
using System.Collections.Generic;

namespace SOLID.Operations
{
    public class AreaOperations
    {
        public double SumAreas(IEnumerable<IHasArea> shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
