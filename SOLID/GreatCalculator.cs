using SOLID.Interfaces;
using SOLID.Operations;
using System.Collections.Generic;

namespace SOLID
{
    public class GreatCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public void Calculate(IEnumerable<IGeometricShape> figuras)
        {
            var areaOperations = new AreaOperations();
            var perimeterOperations = new PerimeterOperations();

            TotalAreas = areaOperations.SumAreas(figuras);
            TotalPerimeters = perimeterOperations.SumPerimeters(figuras);            
        }
    }
}
