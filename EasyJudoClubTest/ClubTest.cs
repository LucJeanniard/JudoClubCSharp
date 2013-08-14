using EasyJudoClub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EasyJudoClub;
using Be.Timvw.Framework.ComponentModel;
using System.IO;

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
            Assert.AreEqual(true, defaultMember.saison2012_2013);
            Assert.AreEqual("", defaultMember.Adresse);
            Assert.AreEqual(false, defaultMember.Arbitre);
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

            _club.UpdateMember(defaultMember, firstMember);

            Assert.AreEqual(1, _club.MemberCount);
            Assert.AreEqual(0, _club.Members[0].Id); 
            Assert.AreEqual("490 route du vieux clocher", _club.Members[0].Adresse);
            Assert.AreEqual(true, _club.Members[0].Arbitre);
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
    }

    
}
