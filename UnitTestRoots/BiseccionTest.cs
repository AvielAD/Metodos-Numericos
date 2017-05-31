using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roots;
namespace UnitTestRoots
{
    [TestClass]
    public class BiseccionTest
    {
        [TestMethod]
        public void RootTest()
        {
            //Arrange
            Biseccion biseccion = new Biseccion()
            {
                Expresion = "sqrt(x)-cos(x)",
                ValStarta = 0,
                ValStartb = 1,
                Tolerance = 10e-4,
                Iteration = 10
            };

            //Act
            var resultado = biseccion.solucion();

            //Assert
            Assert.AreEqual(biseccion.Root, 0.6416015625);
        }
    }
}
