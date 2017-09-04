using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculatorLibrary.Tests
{
    [TestClass()]
    public class BasicOperationsTests
    {
        [TestMethod()]
        public void PlusFunktionTest4()
        {
            //Arrange

            var cal = new BasicOperations(2, 2);

            //Act

            double result = cal.PlusFunktion();

            //Assert

            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void MinusFunktionTest0()
        {
            //Arrange

            var cal = new BasicOperations(2, 2);

            //Act

            double result = cal.MinusFunktion();

            //Assert

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void GangeFunktionTest10()
        {
            //Arrange

            var cal = new BasicOperations(2, 5);

            //Act

            double result = cal.GangeFunktion();

            //Assert

            Assert.AreEqual(10, result);
        }

        [TestMethod()]
        public void DividerFunktionTest2()
        {
            //Arrange

            var cal = new BasicOperations(4, 2);

            //Act

            double result = cal.DividerFunktion();

            //Assert

            Assert.AreEqual(2, result);
        }
    }
}