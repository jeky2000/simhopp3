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
    public class TournamentTests
    {
        [TestMethod()]
        public void AddDiverToTournament()

        {
            Tournament t = new Tournament();
            //t.Name = "UFC";
            //t.Datum = "2017";
            t.Add(new Diver() { FirstName = "sarmad" });
            t.Add(new Diver() { FirstName = "sar" });
            t.Add(new Diver() { FirstName = "sarma" });
            Assert.AreEqual("sarmad", t.List[0].FirstName);
            Assert.AreEqual("sar", t.List[1].FirstName);
            Assert.AreEqual("sarma", t.List[2].FirstName);
            //Assert.AreEqual("2017", t.Datum);
            //Assert.AreEqual("UFC", t.Name);
        }
        [TestMethod()]
        public void RemoveDiverFromTournament()
        {
            Tournament t = new Tournament();

            t.Add(new Diver() { FirstName = "sarmad" });
            t.Add(new Diver() { FirstName = "sar" });
            t.Add(new Diver() { FirstName = "sarma" });
            t.Remove(0);
            Assert.AreEqual("sar", t.List[0].FirstName);
            Assert.AreEqual("sarma", t.List[1].FirstName);

        }




    }
}