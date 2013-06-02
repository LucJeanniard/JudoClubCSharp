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
           using (var folderBrowser = new FolderBrowserDialog())
           {
               if (folderBrowser.ShowDialog() == DialogResult.OK)
               {
                   var path = folderBrowser.SelectedPath;
                   var errorMessage = "";
                   PrintAsPdf(member, path, out errorMessage);
                   var filePath = GetPdfFileName(member, path);
                   using (var process = Process.Start(filePath)) { }
                }
           }
       }

        
        public static bool PrintAsPdf(Member member, string path, out string errorMessage)
        {
            errorMessage = "";
            var outputFileName = GetPdfFileName(member, path);

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

private static string GetPdfFileName(Member member, string path)
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
                formMember.HideButtons();
                formMember.Show();

                var bitmap = new Bitmap(formMember.Width, formMember.Height);
                formMember.DrawToBitmap(bitmap, formMember.ClientRectangle);
                return bitmap;
            }
        }
    }
}
