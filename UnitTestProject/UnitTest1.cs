using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Figures;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            Square square = new Square();
            square.SideLength = 4;

            double expected = 16;
            double actual = square.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}
