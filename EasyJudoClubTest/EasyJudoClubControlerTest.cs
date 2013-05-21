using EasyJudoClub.Controler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EasyJudoClub;
using Moq;
using EasyJudoClub.Model;
using System.Collections.Generic;
using Be.Timvw.Framework.ComponentModel;

namespace EasyJudoClubTest
{
    [TestClass()]
    public class EasyJudoClubControlerTest
    {
        EasyJudoClubControler _easyJudoClubControler;
        Mock<IClub> _clubMock;
        
        #region Additional test attributes
        [TestInitialize()]
        public void TestInitialize()
        {
            _easyJudoClubControler = new EasyJudoClubControler();
            _clubMock = new Mock<IClub>();
            _easyJudoClubControler.Initialize(_clubMock.Object);
        }
        
        [TestCleanup()]
        public void TestCleanup()
        {

        }
        
        #endregion


        [TestMethod()]
        public void AddMemberTest()
        {
            _clubMock.Setup(_ => _.AddMember());
            _easyJudoClubControler.AddMember();
            _clubMock.Verify(_ => _.AddMember(), Times.Once());
        }

        [TestMethod()]
        public void RemoveMemberTest()
        {
            var memberIdToRemove = 6;
            _clubMock.Setup(_ => _.RemoveMember(memberIdToRemove));
            _easyJudoClubControler.RemoveMember(memberIdToRemove);
            _clubMock.Verify(_ => _.RemoveMember(memberIdToRemove), Times.Once());
        }

        [TestMethod()]
        public void UpdateMemberTest()
        {
            var oldMember = new Member() {Id = 2 , Nom = "Jeanniard" , Prenom = "Lucc"};
            var newMember = new Member() {Id = 2 , Nom = "Jeanniard" , Prenom = "Luc"};

            _clubMock.Setup(_ => _.UpdateMember(oldMember, newMember));
            _easyJudoClubControler.UpdateMember(oldMember, newMember);
            _clubMock.Verify(_ => _.UpdateMember(oldMember, newMember), Times.Once());
        }

        /// <summary>
        ///A test for GetFilteredMembers
        ///</summary>
        [TestMethod()]
        public void GetFilteredMembersTest()
        {
            var allMembers = new SortableBindingList<Member>();
            const int MemberNumber = 100;
            for (int i = 0; i < MemberNumber;  i++ )
                allMembers.Add(new Member() {Id = i , Nom = "Nom" + i, Prenom = "Prenom" + i});

            _clubMock.Setup(_ => _.Members).Returns(allMembers);

            var filetedMembersWithAllMembersStartingWithNom = _easyJudoClubControler.GetFilteredMembersByName("Nom");
            Assert.AreEqual(MemberNumber, filetedMembersWithAllMembersStartingWithNom.Count);

            var filetedMembersWithNom50 = _easyJudoClubControler.GetFilteredMembersByName("Nom50");
            Assert.AreEqual(1, filetedMembersWithNom50.Count);
        }

        [TestMethod()]
        public void GetFilteredMembersWithDifferentCaseTest()
        {
            var allMembers = new SortableBindingList<Member>();
            const int MemberNumber = 100;
            for (int i = 0; i < MemberNumber; i++)
                allMembers.Add(new Member() { Id = i, Nom = "Nom" + i, Prenom = "Prenom" + i });

            _clubMock.Setup(_ => _.Members).Returns(allMembers);

            var filetedMembersWithNom50 = _easyJudoClubControler.GetFilteredMembersByName("nOm50");
            Assert.AreEqual(1, filetedMembersWithNom50.Count);
        }
    }
}
