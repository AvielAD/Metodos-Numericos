using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roots;
namespace UnitTestRoots
{
    [TestClass]
    public class NewtonTest
    {
        [TestMethod]
        public void RootTest()
        {
            Newton newton = new Newton()
            {
                Expresion = "cos(x)-x",
                Derivate = "-sin(x)-1",
                ValStarta = Math.PI / 4,
                Iteration = 20,
                Tolerance = 10e-4
            };

            var resultado = newton.solucion();

            Assert.AreEqual(newton.Root, 0.7390851332);
        }
    }
}
