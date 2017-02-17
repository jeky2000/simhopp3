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
    public class PointTests
    {
        [TestMethod()]
        public void PointTest()
        {
            Diver diver1 = new Diver();


            Judge judge1 = new Judge();
            Judge judge2 = new Judge();
            Judge judge3 = new Judge();
            Judge judge4 = new Judge();
            Judge judge5 = new Judge();

            diver1.FirstName = "jek";
            diver1.LastName = "rohan";



            judge1.FirstName = "Son";
            judge1.LastName = "Nygren";

            judge2.FirstName = "Son";
            judge2.LastName = "Nywqeasren";

            judge3.FirstName = "Son";
            judge3.LastName = "Nygren";

            judge4.FirstName = "Son";
            judge4.LastName = "Nywqeasren";


            judge5.FirstName = "Son";
            judge5.LastName = "Nywqeasren";

            diver1.Hopp();

            judge1.rate(diver1.hopp[0], 2);
            judge2.rate(diver1.hopp[0], 3);
            judge3.rate(diver1.hopp[0], 4);
            judge4.rate(diver1.hopp[0], 5);
            judge5.rate(diver1.hopp[0], 6);


            diver1.calculate(diver1.hopp[0]);


            //tittar ifall diver1 har fått poäng
            Assert.AreEqual(diver1.hopp[0].judges[0].Item2, 2);//item1=judge, item2=double som är points
            Assert.AreEqual(diver1.hopp[0].judges[1].Item2, 3);
            Assert.AreEqual(diver1.hopp[0].judges[2].Item2, 4);
            Assert.AreEqual(diver1.hopp[0].judges[3].Item2, 5);
            Assert.AreEqual(diver1.hopp[0].judges[4].Item2, 6);


            //fråga kjell varför våra hopp inte funkar även fast vi får in poängen

            Assert.AreEqual(4, diver1.calculate(diver1.hopp[0]));

        }

    }
}