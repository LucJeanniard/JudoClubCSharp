using System;
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

            var outPutPath = Path.GetTempPath();
            var expectedOutputFileName = Path.Combine(outPutPath, member.Prenom + member.Nom + ".pdf");
            var errorMessage = "";
            Assert.IsTrue(MemberPrinter.PrintAsPdf(member, outPutPath, out errorMessage));
            Assert.IsTrue(File.Exists(expectedOutputFileName));
            Assert.IsTrue(String.IsNullOrEmpty(errorMessage));
            //Process.Start(expectedOutputFileName);
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
    }

}


