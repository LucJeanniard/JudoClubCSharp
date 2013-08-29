using EasyJudoClub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EasyJudoClub;
using Be.Timvw.Framework.ComponentModel;
using System.IO;
using System.Collections.Generic;

namespace EasyJudoClubTest
{
    
    [TestClass()]
    public class ClubTest
    {
        private Club _club;

        [TestInitialize()]
        public void MyClassInitialize()
        {
            _club = new Club() { Members = new SortableBindingList<Member>() };
        }

        /// <summary>
        ///A test for AddMember
        ///</summary>
        [TestMethod()]
        public void TestAddFirstMember()
        {
            _club.AddMember();
            Assert.AreEqual(1, _club.MemberCount, "member count should be 1");
            Assert.AreEqual(0, _club.Members[0].Id, "first member Id should be 0");
        }

        /// <summary>
        ///A test for AddMember
        ///</summary>
        [TestMethod()]
        public void TestAddThirdMember()
        {
            _club.AddMember();
            _club.AddMember();
            _club.AddMember();
            Assert.AreEqual(3, _club.MemberCount, "member count should be 3");
            Assert.AreEqual(2, _club.Members[2].Id, "third member id should be 2");
        }

        /// <summary>
        ///A test for AddMember
        ///</summary>
        [TestMethod()]
        public void TestAddDefaultMember()
        {
            var defaultMember = _club.AddMember();
            Assert.AreEqual(new DateTime(2000, 1, 1), defaultMember.DateDeNaissance);
            
            var defaultEntranceDay = new DateTime(2000, 1, 1);
            var exceptedDelta = new TimeSpan(0, 0, 2); // 2 secondes
            Assert.IsTrue(defaultEntranceDay - defaultMember.DateEntreeClub < exceptedDelta);
            Assert.AreEqual(true, defaultMember.saisonN);
            Assert.AreEqual(false, defaultMember.saisonNmoins1);
            Assert.AreEqual("", defaultMember.Adresse);
            Assert.AreEqual(false, defaultMember.Arbitre);
            Assert.AreEqual(false, defaultMember.Passeport);
            Assert.AreEqual(Ceinture.Blanche, defaultMember.Ceinture);
            Assert.AreEqual("", defaultMember.CertificatMedicalNomMedecin);
            Assert.AreEqual("", defaultMember.CertificatMedicalTelMedecin);
            Assert.AreEqual("", defaultMember.CodePostal);
            Assert.AreEqual(false, defaultMember.CommisaireSportif);
            Assert.AreEqual("", defaultMember.Commune);
            Assert.AreEqual(false, defaultMember.CotisationAJour);
            Assert.AreEqual("", defaultMember.EmailPere);
            Assert.AreEqual("", defaultMember.EmailMere);
            Assert.AreEqual("", defaultMember.TelPere);
            Assert.AreEqual("", defaultMember.TelMere);
            Assert.AreEqual("", defaultMember.LicenseNumber);
            Assert.AreEqual("", defaultMember.MoyenPaiementsCarteMRA);
            Assert.AreEqual("", defaultMember.MoyenPaiementsCheque);
            Assert.AreEqual("", defaultMember.MoyenPaiementsChequesVacances);
            Assert.AreEqual("", defaultMember.MoyenPaiementsChequierJeune);
            Assert.AreEqual("", defaultMember.MoyenPaiementsLiquide);
            Assert.AreEqual(false, defaultMember.CotisationAJour);
            Assert.AreEqual(Categorie.Minime, defaultMember.Categorie);
        }

        /// <summary>
        ///A test for RemoveMember
        ///</summary>
        [TestMethod()]
        public void RemoveMemberTest()
        {
            _club.AddMember();
            _club.AddMember();
            Assert.AreEqual(2, _club.MemberCount, "member count should be 2");
            _club.RemoveMember(1);
            Assert.AreEqual(1, _club.MemberCount, "member count should be 1");
            Assert.AreEqual(0, _club.Members[0].Id, "Member Id should be 0");
        }

        /// <summary>
        ///A test for UpdateMember
        ///</summary>
        [TestMethod()]
        public void UpdateMemberWithLastIndexTest()
        {
            var defaultMember = _club.AddMember();
            Assert.AreEqual(1, _club.MemberCount);

            var firstMember = _club.Members[0];
            firstMember.Adresse = "490 route du vieux clocher";
            firstMember.Arbitre = true;
            firstMember.Passeport= true;

            _club.UpdateMember(defaultMember, firstMember);

            Assert.AreEqual(1, _club.MemberCount);
            Assert.AreEqual(0, _club.Members[0].Id); 
            Assert.AreEqual("490 route du vieux clocher", _club.Members[0].Adresse);
            Assert.AreEqual(true, _club.Members[0].Arbitre);
            Assert.AreEqual(true, _club.Members[0].Passeport);
        }

        /// <summary>
        ///A test for UpdateMember
        ///</summary>
        [TestMethod()]
        public void UpdateMemberWithIndexNotTheGreatest()
        {
            _club.AddMember();
            var defaultMember = _club.AddMember();
            _club.AddMember();
            Assert.AreEqual(3, _club.MemberCount);
            Assert.AreEqual(1, defaultMember.Id);

            var secondMember = _club.Members[1];
            secondMember.EmailPere = "luc.jeanniard@gmail.com";

            _club.UpdateMember(defaultMember, secondMember);

            Assert.AreEqual(3, _club.MemberCount);
            Assert.AreEqual("luc.jeanniard@gmail.com", _club.Members[1].EmailPere);
            Assert.AreEqual(1, _club.Members[1].Id);
        }

        [TestMethod()]
        public void GetAllDoctorsAndTelephones()
        {
            var newMember1 = _club.AddMember();
            newMember1.CertificatMedicalNomMedecin="medecin1";
            newMember1.CertificatMedicalTelMedecin = "11111111";
            var newMember2 = _club.AddMember();
            newMember2.CertificatMedicalNomMedecin = "medecin2";
            newMember2.CertificatMedicalTelMedecin = "22222222";

            var newMember2bis = _club.AddMember();
            newMember2bis.CertificatMedicalNomMedecin = "medecin2";
            newMember2bis.CertificatMedicalTelMedecin = "22222222";

            var newMemberEmptyDoc = _club.AddMember();
            newMemberEmptyDoc.CertificatMedicalNomMedecin = "";
            newMemberEmptyDoc.CertificatMedicalTelMedecin = "";
            
            var doctors = _club.GetDoctorsAndTel();
            Assert.AreEqual(2, doctors.Keys.Count);
            Assert.IsTrue(doctors.ContainsKey("medecin1"));
            Assert.IsTrue(doctors.ContainsKey("medecin2"));
            Assert.AreEqual("11111111", doctors["medecin1"]);
            Assert.AreEqual("22222222", doctors["medecin2"]);
        }

        [TestMethod()]
        public void TestNewSaisonSetsNminus1SaisonANdEmptiesN()
        {
            var newMember1 = _club.AddMember();
            var newMember2 = _club.AddMember();
            newMember1.saisonN = true;
            newMember2.saisonN = false;
            newMember1.saisonNmoins1 = false;
            newMember2.saisonNmoins1 = true;

            newMember1.MoyenPaiementsCarteMRA = "10";
            newMember1.MoyenPaiementsCheque = "16";
            newMember1.MoyenPaiementsChequesVacances = "2";
            newMember1.MoyenPaiementsChequierJeune = "52";
            newMember1.MoyenPaiementsLiquide = "45";

            newMember2.MoyenPaiementsCarteMRA = "10";
            newMember2.MoyenPaiementsCheque = "16";
            newMember2.MoyenPaiementsChequesVacances = "2";
            newMember2.MoyenPaiementsChequierJeune = "52";
            newMember2.MoyenPaiementsLiquide = "45";


            _club.NewSaison();

            Assert.IsFalse(newMember1.saisonN);
            Assert.IsFalse(newMember2.saisonN);
            Assert.IsTrue(newMember1.saisonNmoins1);
            Assert.IsFalse(newMember2.saisonNmoins1);

            Assert.IsTrue(newMember1.MoyenPaiementsCarteMRA == String.Empty);
            Assert.IsTrue(newMember1.MoyenPaiementsCheque == String.Empty);
            Assert.IsTrue(newMember1.MoyenPaiementsChequesVacances == String.Empty);
            Assert.IsTrue(newMember1.MoyenPaiementsChequierJeune == String.Empty);
            Assert.IsTrue(newMember1.MoyenPaiementsLiquide == String.Empty);

            Assert.IsTrue(newMember2.MoyenPaiementsCarteMRA == String.Empty);
            Assert.IsTrue(newMember2.MoyenPaiementsCheque == String.Empty);
            Assert.IsTrue(newMember2.MoyenPaiementsChequesVacances == String.Empty);
            Assert.IsTrue(newMember2.MoyenPaiementsChequierJeune == String.Empty);
            Assert.IsTrue(newMember2.MoyenPaiementsLiquide == String.Empty);
        }
    }

    
}
