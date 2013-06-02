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
        public void TestMemberPrintAsPdf()
        {
            var member = new Member();
            member.Nom = "Jeanniard";
            member.Prenom = "Luc";
            member.Ceinture = Ceinture.Blanche;


            var outPutPath = Path.GetTempPath();
            var expectedOutputFileName = Path.Combine(outPutPath, member.Prenom + member.Nom + ".pdf");
            MemberPrinter.Print(member, outPutPath);
            Assert.IsTrue(File.Exists(expectedOutputFileName));
            Process.Start(expectedOutputFileName);
        }
    }

    public class MemberPrinter
    {
        public static void Print(Member member, string path)
        {
            var outputFileName = Path.Combine(path, member.Prenom + member.Nom + ".pdf");
            if (File.Exists(outputFileName))
                File.Delete(outputFileName);

            using (var formMember = new FrmLicencie())
            {
                formMember.Member = member;
                formMember.FormBorderStyle = FormBorderStyle.None;
                formMember.Visible = false;
                formMember.BackColor = Color.White;
                formMember.HideButtons();
                formMember.Show();
                
                using (var bitmap = new Bitmap(formMember.Width, formMember.Height))
                {
                    formMember.DrawToBitmap(bitmap, formMember.ClientRectangle);


                    using (var document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();
                        page.Orientation = PdfSharp.PageOrientation.Landscape;

                        var graphic = XGraphics.FromPdfPage(page);
                        using (var image = XImage.FromGdiPlusImage(bitmap as Image))
                        {
                            var x = 30;
                            var y = 30;
                            graphic.DrawImage(image, x, y);
                            
                        }
                        document.Save(outputFileName);
                    }
                }
            }
        }
    }
}
