using EasyJudoClub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EasyJudoClubTest
{
    [TestClass()]
    public class CommunesHelperTest
    {

        [TestMethod()]
        public void GetCodePostalTest()
        {
            Assert.AreEqual(38690, CommunesHelper.GetCodePostal("Colombe"));
        }

        [TestMethod()]
        public void GetCommunesTest()
        {
            var communesDontLeCodePostaleEst38690 = CommunesHelper.GetCommunes("38690");
            Assert.AreEqual(15, communesDontLeCodePostaleEst38690.Count);
            Assert.IsTrue(communesDontLeCodePostaleEst38690.Contains("Colombe"));
            Assert.IsTrue(communesDontLeCodePostaleEst38690.Contains("Belmont"));
            Assert.IsTrue(communesDontLeCodePostaleEst38690.Contains("Bévenais"));
            Assert.IsTrue(communesDontLeCodePostaleEst38690.Contains("Biol"));
        }
    }
}
