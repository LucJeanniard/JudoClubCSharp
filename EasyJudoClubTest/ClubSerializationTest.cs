using EasyJudoClub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EasyJudoClub;
using Be.Timvw.Framework.ComponentModel;
using System.IO;

namespace EasyJudoClubTest
{

    [TestClass()]
    public class ClubSerializationTest
    {
        private Club _club;

        [TestInitialize()]
        public void TestInitialize()
        {
            DeleteDb();
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            DeleteDb();
        }

        [TestMethod]
        public void TestSerialization()
        {
            _club = new Club() { Members = new SortableBindingList<Member>() };
            var newMember = _club.AddMember();
            newMember.DateDeNaissance = new DateTime(2005, 6, 25);
            newMember.DateEntreeClub = new DateTime(2010, 9, 15);
            newMember.saison2012_2013 = true;
            newMember.Nom = "Jeanniard";
            newMember.Prenom = "Matti";
            newMember.NomPere = "Jeanniard";
            newMember.PrenomPere = "Luc";
            newMember.NomMere = "Lazzaron";
            newMember.PrenomMere = "Laetitia";
            newMember.Commune = "Colombe";
            newMember.CodePostal = "38690";
            newMember.Adresse = "490 route du vieux clocher";
            newMember.Email = "luc.jeanniard@gmail.com";
            newMember.Tel = "04.76.83.26.09";
            newMember.TelPortable = "06.76.83.26.09";
            newMember.Sexe = EasyJudoClub.Sexe.Masculin;
            newMember.LicenseNumber = "AAA";
            newMember.Ceinture = Ceinture.Blanche1Trait;
            newMember.CommisaireSportif = true;
            newMember.Arbitre = false;
            newMember.CertificatMedicalNomMedecin = "Jean Docteur";
            newMember.CertificatMedicalTelMedecin = "04.11.22.33.44";
            newMember.MoyenPaiementsLiquide = "10";
            newMember.MoyenPaiementsCheque = "20";
            newMember.MoyenPaiementsChequesVacances = "30";
            newMember.MoyenPaiementsChequierJeune = "40";
            newMember.MoyenPaiementsCarteMRA = "50";

            Club.Serialize(_club);
            Assert.IsTrue(File.Exists(Club.EASY_SPORT_CLUB_DB_FILE_NAME));

            var newClubFromDb = Club.Deserialize();
            var firstMemberFromDB = _club.Members[0];
            Assert.AreEqual(new DateTime(2005, 6, 25), firstMemberFromDB.DateDeNaissance);
            Assert.AreEqual(new DateTime(2010, 9, 15), firstMemberFromDB.DateEntreeClub);
            Assert.AreEqual(true, firstMemberFromDB.saison2012_2013);
            Assert.AreEqual("Jeanniard", firstMemberFromDB.Nom);
            Assert.AreEqual("Matti", firstMemberFromDB.Prenom);
            Assert.AreEqual("Jeanniard", firstMemberFromDB.NomPere);
            Assert.AreEqual("Luc", firstMemberFromDB.PrenomPere);
            Assert.AreEqual("Lazzaron", firstMemberFromDB.NomMere);
            Assert.AreEqual("Laetitia", firstMemberFromDB.PrenomMere);
            Assert.AreEqual("Colombe", firstMemberFromDB.Commune);
            Assert.AreEqual("38690", firstMemberFromDB.CodePostal);
            Assert.AreEqual("490 route du vieux clocher", firstMemberFromDB.Adresse);
            Assert.AreEqual("luc.jeanniard@gmail.com", firstMemberFromDB.Email);
            Assert.AreEqual("04.76.83.26.09", firstMemberFromDB.Tel);
            Assert.AreEqual("06.76.83.26.09", firstMemberFromDB.TelPortable);
            Assert.AreEqual(EasyJudoClub.Sexe.Masculin, firstMemberFromDB.Sexe);
            Assert.AreEqual("AAA", firstMemberFromDB.LicenseNumber);
            Assert.AreEqual(Ceinture.Blanche1Trait, firstMemberFromDB.Ceinture);
            Assert.AreEqual(true, firstMemberFromDB.CommisaireSportif);
            Assert.AreEqual(false, firstMemberFromDB.Arbitre);
            Assert.AreEqual("Jean Docteur", firstMemberFromDB.CertificatMedicalNomMedecin);
            Assert.AreEqual("04.11.22.33.44", firstMemberFromDB.CertificatMedicalTelMedecin);
            Assert.AreEqual("10", firstMemberFromDB.MoyenPaiementsLiquide);
            Assert.AreEqual("20", firstMemberFromDB.MoyenPaiementsCheque);
            Assert.AreEqual("30", firstMemberFromDB.MoyenPaiementsChequesVacances);
            Assert.AreEqual("40", firstMemberFromDB.MoyenPaiementsChequierJeune);
            Assert.AreEqual("50", firstMemberFromDB.MoyenPaiementsCarteMRA);
        }

        private void DeleteDb()
        {
            if (File.Exists(Club.EASY_SPORT_CLUB_DB_FILE_NAME))
                File.Delete(Club.EASY_SPORT_CLUB_DB_FILE_NAME);
            Assert.IsFalse(File.Exists(Club.EASY_SPORT_CLUB_DB_FILE_NAME));
        }
    }
}
