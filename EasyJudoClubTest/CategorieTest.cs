using EasyJudoClub;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyJudoClubTest
{

    [TestClass]
    public class CategorieTest
    {
        [TestMethod]
        public void EveilCorporelTest()
        {
            var annee = 2012;

            var anneeNaissance = 2009;
            Assert.AreEqual(Categorie.EveilCorporel, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void EveilTest()
        {
            var annee = 2012;

            var anneeNaissance = 2007;
            Assert.AreEqual(Categorie.Eveil, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 2008;
            Assert.AreEqual(Categorie.Eveil, CategorieHelper.GetCategorie(annee, anneeNaissance));

        }

        [TestMethod]
        public void PoussinetTest()
        {
            var annee = 2012;

            var anneeNaissance = 2005;
            Assert.AreEqual(Categorie.Poussinet, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 2006;
            Assert.AreEqual(Categorie.Poussinet, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void PoussinTest()
        {
            var annee = 2012;

            var anneeNaissance = 2003;
            Assert.AreEqual(Categorie.Poussin, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 2004;
            Assert.AreEqual(Categorie.Poussin, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void BenjaminTest()
        {
            var annee = 2012;

            var anneeNaissance = 2001;
            Assert.AreEqual(Categorie.Benjamin, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 2002;
            Assert.AreEqual(Categorie.Benjamin, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void MinimesTest()
        {
            var annee = 2012;

            var anneeNaissance = 1999;
            Assert.AreEqual(Categorie.Minime, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 2000;
            Assert.AreEqual(Categorie.Minime, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void CadetsTest()
        {
            var annee = 2012;

            var anneeNaissance = 1997;
            Assert.AreEqual(Categorie.Cadet, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 1998;
            Assert.AreEqual(Categorie.Cadet, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void JuniorsTest()
        {
            var annee = 2012;

            var anneeNaissance = 1994;
            Assert.AreEqual(Categorie.Junior, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 1995;
            Assert.AreEqual(Categorie.Junior, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 1996;
            Assert.AreEqual(Categorie.Junior, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }

        [TestMethod]
        public void SeniorsTest()
        {
            var annee = 2012;

            var anneeNaissance = 1993;
            Assert.AreEqual(Categorie.Senior, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 1990;
            Assert.AreEqual(Categorie.Senior, CategorieHelper.GetCategorie(annee, anneeNaissance));

            anneeNaissance = 1950;
            Assert.AreEqual(Categorie.Senior, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }


        [TestMethod]
        public void JuniorsTest2()
        {
            var annee = 2013;

            var anneeNaissance = 1995;
            Assert.AreEqual(Categorie.Junior, CategorieHelper.GetCategorie(annee, anneeNaissance));
        }
    }
}
