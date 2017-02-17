using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimHop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHop.Tests
{
    [TestClass()]
    public class JudgeTests
    {
        [TestMethod()]
        public void JudgeTest()
        {

            Judge t = new Judge();

            t.AddJudge(new Judge() { FirstName = "sarmad" });
            t.AddJudge(new Judge() { FirstName = "sar" });
            t.AddJudge(new Judge() { FirstName = "sarma" });
            Assert.AreEqual("sarmad", t.judges[0].FirstName);
            Assert.AreEqual("sar", t.judges[1].FirstName);
            Assert.AreEqual("sarma", t.judges[2].FirstName);


        }
        public void remove()
        {
            Judge t = new Judge();

            t.AddJudge(new Judge() { FirstName = "sarmad" });
            t.AddJudge(new Judge() { FirstName = "sar" });
            t.AddJudge(new Judge() { FirstName = "sarma" });
            t.removejudge(0);
            Assert.AreEqual("sar", t.judges[0].FirstName);
            Assert.AreEqual("sarma", t.judges[1].FirstName);

        }
    }
}