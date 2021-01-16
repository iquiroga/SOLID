using SOLID.Figures;
using SOLID.Interfaces;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var figuras = new IGeometricShape[]
           {

                new Rectangle { Width = 10, Height = 5},
                new EquilateralTriangle { SideLength = 5},
                new Rectangle { Width = 4, Height = 6},
                new Square { SideLength = 10},
                new Rectangle { Width = 5, Height = 1},
                new Square { SideLength = 8},
                new EquilateralTriangle { SideLength = 5}

           };

            var calculator = new GreatCalculator();
            calculator.Calculate(figuras);
            
            Console.WriteLine($"Area total: {calculator.TotalAreas}\nPerímetro total: {calculator.TotalPerimeters}");
            Console.ReadKey();
        }
    }
}
