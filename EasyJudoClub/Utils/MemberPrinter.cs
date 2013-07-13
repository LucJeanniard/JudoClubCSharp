using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace EasyJudoClub.Utils
{

    public class MemberPrinter
    {

        public static void Print(Member member)
        {
            var path = Path.GetTempPath();
            var errorMessage = "";
            if (PrintAsPdf(member, path, out errorMessage))
            {
                var filePath = GetPdfFileNameForOneMember(member, path);
                using (var process = Process.Start(filePath)) { }
            }
            else
            {
                MessageBox.Show(errorMessage, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public static void Print(List<Member> members)
        {
            var path = Path.GetTempPath();
            var errorMessage = "";
            if (PrintAsPdf(members, path, out errorMessage))
            {
                var filePath = GetPdfFileNameForListOfMember(path);
                using (var process = Process.Start(filePath)) { }
            }
            else
            {
                MessageBox.Show(errorMessage, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool PrintAsPdf(List<Member> members, string path, out string errorMessage)
        {
            errorMessage = "";
            var outputFileName = GetPdfFileNameForListOfMember(path);

            using (var document = new PdfDocument())
            {
                foreach (var member in members)
                {
                    AddMemberToNewPage(member, document);
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

        private static string GetPdfFileNameForListOfMember(string path)
        {
            var outputFileName = Path.Combine(path, "JudoMembers" + ".pdf");
            return outputFileName;
        }

        public static bool PrintAsPdf(Member member, string path, out string errorMessage)
        {
            errorMessage = "";
            var outputFileName = GetPdfFileNameForOneMember(member, path);

            using (var document = new PdfDocument())
            {

                AddMemberToNewPage(member, document);

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

        private static void AddMemberToNewPage(Member member, PdfDocument document)
        {
            using (var bitmap = GetMemberFormAsBitmap(member))
            {
                PdfPage page = document.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;

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
        }

        private static string GetPdfFileNameForOneMember(Member member, string path)
        {
            var outputFileName = Path.Combine(path, member.Prenom + "_" + member.Nom + ".pdf");
            return outputFileName;
        }

        private static Bitmap GetMemberFormAsBitmap(Member member)
        {
            using (var formMember = new FrmLicencie())
            {
                formMember.Member = member;
                formMember.FormBorderStyle = FormBorderStyle.None;
                formMember.Visible = false;
                formMember.BackColor = Color.White;
                formMember.PrepareForPrinting();
                formMember.Show();

                var bitmap = new Bitmap(formMember.Width, formMember.Height);
                formMember.DrawToBitmap(bitmap, formMember.ClientRectangle);
                return bitmap;
            }
        }
    }
}
