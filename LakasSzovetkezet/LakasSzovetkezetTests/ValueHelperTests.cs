using Microsoft.VisualStudio.TestTools.UnitTesting;
using LakasSzovetkezet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakasSzovetkezet.Tests
{
    [TestClass()]
    public class ValueHelperTests
    {
        [TestMethod()]
        public void CalculateValueTest()
        {
            //m2        Ft
            //27,47   4500
            //37,4    6700
            //43,93   6800
            //55,25   9600
            //76,56   13300

            //terület alapján számolás tesztelése
            Assert.AreEqual<int>(4500, ValueHelper.CalculateValue(26, 0),"26m2 nem számol jól.");
            Assert.AreEqual<int>(4500, ValueHelper.CalculateValue(36, 0), "36m2 nem számol jól.");
            Assert.AreEqual<int>(6700, ValueHelper.CalculateValue(38, 0), "38m2 nem számol jól.");
            Assert.AreEqual<int>(6800, ValueHelper.CalculateValue(44, 0), "44m2 nem számol jól.");
            Assert.AreEqual<int>(9600, ValueHelper.CalculateValue(56, 0), "56m2 nem számol jól.");
            Assert.AreEqual<int>(13300, ValueHelper.CalculateValue(100, 0), "100m2 nem számol jól.");

        }

        [TestMethod()]
        public void CalculateValueWithRadiatorTest()
        {

            Assert.AreEqual<int>(4700, ValueHelper.CalculateValue(26, 2), "26m2 és két radiátort elszámolta.");
            Assert.AreEqual<int>(7000, ValueHelper.CalculateValue(38, 3), "38m2 és három radiátort elszámolta. Tesztelő csinálta a hibát.");
            //Assert.Fail("Hibás mert nem csináltunk semmit.");
        }

        [TestMethod()]
        public void SajátTesztMetódus()
        {
            var comboHelper = new NewDeposit.ComboHelper()
            { FlatID = 1, FlatNumber=1, Floor=1, Stairway="1."};
            Assert.AreEqual("1. lépcsőház - 1 em - 1", comboHelper.ToString());
        
        }
    }
}