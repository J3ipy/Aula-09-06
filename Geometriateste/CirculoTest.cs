using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometriateste
{
    public class CirculoTest
    {
        Circulo circulo = new Circulo();
        [TestMethod]
        public void CirculoCalcularAreaTestAccept()
        {
            double esperado = 20;
            string[] medidas = {"4","5"};
            double resultado = circulo.CalcularArea(medidas);

            Assert.AreEqual(esperado,resultado);
        }
    }
}