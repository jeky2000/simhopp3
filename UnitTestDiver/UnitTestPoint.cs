using System;
using SimHop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDiver//unitestsimhop
{
    [TestClass]
    public class UnitTestPoint
    {
        [TestMethod]
        public void TestValid()
        {
            Point p1 = new Point(13.0);
            Assert.AreEqual(false, p1.Valid());
            Point p2 = new Point(1.2);
            Assert.AreEqual(false, p2.Valid());
            Point p3 = new Point(1.5);
            Assert.AreEqual(true, p3.Valid());
        }

       

        [TestMethod]
        public void Testcalculate()
        {
            Point p = new Point(new Point(2.0), new Point(3.0), new Point(4.0), new Point(5.0), new Point(6.0));
            Assert.AreEqual(4.0, p.calculate());
        }
     
            


        
    }
}
