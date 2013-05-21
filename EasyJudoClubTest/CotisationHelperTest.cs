using EasyJudoClub;
using EasyJudoClub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{

    /*
    83€ pour les éveil judo et poussinets car ils n’ont qu’un cours et 
    103€ pour les éveil corporel poussins benjamins et +
    103€ pour les éveil corporel car ils n’ ont qu’un cours mais ils ont une assurance à part.
  */

    /// <summary>
    ///This is a test class for CotisationHelperTest and is intended
    ///to contain all CotisationHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CotisationHelperTest
    {
        [TestMethod()]
        public void GetAdhesionTest()
        {
            Assert.AreEqual(83, CotisationHelper.GetAdhesion(Categorie.Eveil));
            Assert.AreEqual(83, CotisationHelper.GetAdhesion(Categorie.Poussinet));
            
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.EveilCorporel));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Poussin));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Benjamin));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Minime));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Cadet));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Junior));
            Assert.AreEqual(103, CotisationHelper.GetAdhesion(Categorie.Senior));
           
        }

        [TestMethod()]
        public void GetCotisationExterieurTest()
        {
            Assert.AreEqual(146, CotisationHelper.GetCotisation("Grand-Lemps", Categorie.Senior));
        }
        
        [TestMethod()]
        public void GetCotisationColombeTest()
        {
            Assert.AreEqual(136, CotisationHelper.GetCotisation("Colombe", Categorie.Senior));
        }
 
    }
}
