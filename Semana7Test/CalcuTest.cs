using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
    [TestClass]
    public class CalcuTest
    {
        [DataRow(4,4,8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 2)]

        [TestMethod]
        public void Suma_retonaValor(int a,int b, int esperado)
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

      // Test Driven Development
      //programacion entre pares


        [DataRow(4, 4, 1)]
        [DataRow(4, 0, -1)]
        [DataRow(20, 5, 4)]
        [TestMethod]
        public void Div_retonaValor(int a, int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act

            Calculadora calc = new Calculadora();

            int actual = calc.div(a, b);

            //Assert

            Assert.AreEqual(esperado, actual);

        }


        [DataRow(4, 0, 0)]
        [TestMethod]
        public void Div_EntreCero(int a, int b, int esperado)
        {
            //arrange
            //int a = 4;
            // int b = 4;
            // int esperado = 7;

            //Act

            Calculadora calc = new Calculadora();

            int actual = calc.div(a, b);

            //Assert

            Assert.AreNotEqual(null, actual);

        }

        [DataRow(4, 4, 0)]
        [DataRow(4, 6, -2)]
        [DataRow(5, 4, 1)]
        [TestMethod]
        public void RestaTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            Calculadora calc = new Calculadora();

            int actual = calc.resta(a, b);

            //Assert
            Assert.AreEqual(actual, esperado);

        }
        [DataRow(4, 4, 16)]
        [DataRow(4, 8, 32)]
        [DataRow(5, 4, 20)]
        [TestMethod]
        public void MultiTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            Calculadora calc = new Calculadora();

            int actual = calc.multi(a, b);

            //Assert
            Assert.AreEqual(actual, esperado);
        }
    }
}
