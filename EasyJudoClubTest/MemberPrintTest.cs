using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyJudoClub;
using EasyJudoClub.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace EasyJudoClubTest
{
    [TestClass]
    public class MemberPrintTest
    {
        [TestMethod]
        public void TestMemberPrintAsPdfForSuccess()
        {
            var member = new Member();
            member.Nom = "Jeanniard";
            member.Prenom = "Luc";
            member.Nom = "Jeanniard";
            
            var outPutPath = Path.GetTempPath();
            var expectedOutputFileName = Path.Combine(outPutPath, member.Prenom + "_" + member.Nom + ".pdf");
            var errorMessage = "";
            Assert.IsTrue(MemberPrinter.PrintAsPdf(member, outPutPath, out errorMessage));
            Assert.IsTrue(File.Exists(expectedOutputFileName));
            Assert.IsTrue(String.IsNullOrEmpty(errorMessage));
            File.Delete(expectedOutputFileName);
        }

        [TestMethod]
        public void TestMemberPrintAsPdfForFailureWhenPathDoesNotExists()
        {
            var member = new Member();

            var outPutPath = @"X:\Temp\";
            var expectedOutputFileName = Path.Combine(outPutPath, member.Prenom + member.Nom + ".pdf");
            var errorMessage = "";
            Assert.IsFalse(MemberPrinter.PrintAsPdf(member, outPutPath, out errorMessage));
            Assert.IsFalse(String.IsNullOrEmpty(errorMessage));
        }

        [TestMethod]
        public void Test2MembersPrintAsPdf()
        {
            var member1 = new Member();
            member1.Nom = "Jeanniard";
            member1.Prenom = "Luc";

            var member2 = new Member();
            member2.Nom = "Jeanniard";
            member2.Prenom = "Matti";

            var memberList = new List<Member>();
            memberList.Add(member1);
            memberList.Add(member2);

            var outPutPath = Path.GetTempPath();
            var expectedOutputFileName = Path.Combine(outPutPath, "JudoMembers" + ".pdf");
            var errorMessage = "";
            Assert.IsTrue(MemberPrinter.PrintAsPdf(memberList, outPutPath, out errorMessage));
            Assert.IsTrue(File.Exists(expectedOutputFileName));
            Assert.IsTrue(String.IsNullOrEmpty(errorMessage));
            //Process.Start(expectedOutputFileName);
            File.Delete(expectedOutputFileName);
        }
    }

}


