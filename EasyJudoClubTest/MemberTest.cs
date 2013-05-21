using EasyJudoClub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for MemberTest and is intended
    ///to contain all MemberTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MemberTest
    {

        /// <summary>
        ///A test for Age
        ///</summary>
        [TestMethod()]
        public void AgeTest()
        {
            var dateDeNaissance = new DateTime(2005, 06, 24);
            var date =            new DateTime(2012, 06, 24);
                        
            Assert.AreEqual(7, Member.GetAge(date, dateDeNaissance));

            date = new DateTime(2012, 06, 23);
            Assert.AreEqual(6, Member.GetAge(date, dateDeNaissance));

            date = new DateTime(2012, 06, 25);
            Assert.AreEqual(7, Member.GetAge(date, dateDeNaissance));
        }

    }
}
