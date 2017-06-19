using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roots;
namespace UnitTestRoots
{
    [TestClass]
    public class Secant
    {
        [TestMethod]
        public void RootTest()
        {
            Roots.Secant secant = new Roots.Secant()
            {
                Expresion = "cos(x)-x",
                Tolerance = 10e-4,
                ValStarta = 0.5,
                ValStartb = Math.PI/4,
                Iteration = 20
            };
            var resultado = secant.solucion();
            double root = secant.Root;
            double esperado = 0.7390851332;

            Assert.AreEqual(root, esperado);
        }
    }
}
