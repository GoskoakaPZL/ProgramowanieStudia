using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static zadanie4.obliczanie;

namespace TestProject1
{

    [TestClass]
    public class Testjednostkowy1
    {

        [TestMethod]
        public void Test1()
        {
            zadanie4.obliczanie l = new zadanie4.obliczanie();

            double x1, x2;
            var a = 2;
            var b = 5;
            var c = 1;
            zadanie4.obliczanie.rownaniekwadratowe(a, b, c, out x1, out x2);

            Assert.AreNotEqual(x1, double.NaN);
            Assert.AreNotEqual(x2, double.NaN);

        }

        [TestClass]
        public class Testjednostkowy2
        {
            [TestMethod]
            public void Test1()
            {
                double x1, x2;
                var a = 1;
                var b = 2;
                var c = 1;
                zadanie4.obliczanie.rownaniekwadratowe(a, b, c, out x1, out x2);
                Assert.AreEqual(x1, x2);



            }
        }
    }
}

