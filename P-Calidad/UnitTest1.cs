using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace P_Calidad
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [DataRow(4, 4, 8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 0, 1)]
        public void Suma_retonaValor(int a, int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act

            int actual = Calculadora.suma(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }
    }
}
