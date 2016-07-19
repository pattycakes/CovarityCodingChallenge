using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.BusinessObjects.Tests
{
    [TestClass()]
    public class CurrencyHandlerTests
    {
        [TestMethod()]
        public void AcceptCurrencyTestFiver()
        {
            Currency Fiver = new Currency(5);
            CurrencyHandler chtest = new CurrencyHandler();
            Assert.AreEqual(0, chtest.AcceptCurrency(Fiver));
        }

        [TestMethod()]
        public void AcceptCurrencyTestTenner()
        {
            Currency Tenner = new Currency(10);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(Tenner);
            Assert.AreEqual(0, chtest.AcceptCurrency(Tenner));
        }

        [TestMethod()]
        public void AcceptCurrencyTestOne()
        {
            Currency One = new Currency(1);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(One);
            Assert.AreEqual(0, chtest.AcceptCurrency(One));
        }

        [TestMethod()]
        public void AcceptCurrencyTestTwo()
        {
            Currency Two = new Currency(2);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(Two);
            Assert.AreEqual(0, chtest.AcceptCurrency(Two));
        }
        [TestMethod()]
        public void AcceptCurrencyTestThree()
        {
            Currency Three = new Currency(3);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(Three);
            Assert.AreEqual(1, chtest.AcceptCurrency(Three));
        }

        [TestMethod()]
        public void ReturnAcceptedCurrencyTest()
        {
            Currency Fiver = new Currency(5);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(Fiver);
            chtest.AcceptCurrency(Fiver);
            Assert.AreEqual(10, chtest.ReturnAcceptedCurrency());
        }

        [TestMethod()]
        public void ReturnChangeTest()
        {
            Currency Fiver = new Currency(5);
            CurrencyHandler chtest = new CurrencyHandler();
            chtest.AcceptCurrency(Fiver);
            chtest.AcceptCurrency(Fiver);
            Assert.AreEqual(5, chtest.ReturnChange(5));
        }
    }
}