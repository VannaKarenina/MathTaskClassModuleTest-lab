using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassModule;

namespace MathTaskClassModuleTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            double a = 4;
            double b = 5;
            double c = 1;
            
            Geometry g = new Geometry();
            double[] expected = new double[2] { -0.25, -1};
            double[] act = new double[2]; 
            act = g.Sqrt(a, b, c);
            
            CollectionAssert.AreEqual(expected, act);
        }
    }
}
