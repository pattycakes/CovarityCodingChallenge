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
    public class TrayTests
    {
        [TestMethod()]
        public void ReplenishFuncionalityTest()
        {
            Tray testTray = new Tray();
            Assert.AreEqual(0, testTray.Replenish(1, 1.00));
        }

        [TestMethod()]
        public void ReplenishEdgeTest()
        {
            Tray testTray = new Tray();
            testTray.Replenish(10, 1.00);
            Assert.AreEqual(1, testTray.Replenish(1, 1.00));
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Tray testTray = new Tray();
            testTray.Remove();
            Assert.Inconclusive();
        }
    }
}