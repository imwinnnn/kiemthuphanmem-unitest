using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using baithuchanh;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private bai1 b = null;
        [TestMethod, Ignore]
        public void TestIfnbang0()
        {
          
            double kq = bai1.Power(5, 0);
            Assert.AreEqual(1.0,kq);
        }
        [TestMethod]
        public void TestIfnlonHon0()
        {
            b = new bai1();
            double kq = bai1.Power(5, 2);
            Assert.AreEqual(25.0, kq);
        }
        [TestMethod, Ignore]
        public void TestIfnbeHon0()
        {
            b = new bai1();
            double kq = bai1.Power(5, -1);
            Assert.AreEqual(0.2, kq);
        }
    }
}
