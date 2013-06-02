using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyJudoClub;
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

    public class MemberPrinter
    {
        public static bool PrintAsPdf(Member member, string path, out string errorMessage)
        {
            errorMessage = "";
            var outputFileName = Path.Combine(path, member.Prenom + member.Nom + ".pdf");

            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;

                using (var bitmap = GetMemberFormAsBitmap(member))
                {
                    using (var image = XImage.FromGdiPlusImage(bitmap as Image))
                    {
                        using (var graphic = XGraphics.FromPdfPage(page))
                        {
                            var x = 30;
                            var y = 30;
                            graphic.DrawImage(image, x, y);
                        }
                    }
                }

                try
                {
                    document.Save(outputFileName);
                    return File.Exists(outputFileName);
                }
                catch (Exception e)
                {
                    errorMessage = e.Message;
                    return false;
                }
            }
        }

        public static Bitmap GetMemberFormAsBitmap(Member member)
        {
            using (var formMember = new FrmLicencie())
            {
                formMember.Member = member;
                formMember.FormBorderStyle = FormBorderStyle.None;
                formMember.Visible = false;
                formMember.BackColor = Color.White;
                formMember.HideButtons();
                formMember.Show();
                
                var bitmap = new Bitmap(formMember.Width, formMember.Height);
                formMember.DrawToBitmap(bitmap, formMember.ClientRectangle);
                return bitmap;
             }
        }
    }
}


