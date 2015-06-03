using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectPdf;
using Trazabilidad.App.Ganado.Servicios;
using Trazabilidad.App.Ganado.Dominio;

using System.Web;

namespace Trazabilidad.App.Reportes.Aplicacion
{
    public class ReporteGanado
    {
        public PdfDocument makeReport()
        {
            var nacidos = FactoriaServiciosLocales<BovinoNacido>.GetInstance().GetServicio().GetAll();
            var comprados = FactoriaServiciosLocales<BovinoComprado>.GetInstance().GetServicio().GetAll();
            var muertos = FactoriaServiciosLocales<BovinoMuerto>.GetInstance().GetServicio().GetAll();
            var vendidos = FactoriaServiciosLocales<BovinoVendido>.GetInstance().GetServicio().GetAll();


            SelectPdf.PdfDocument doc = new SelectPdf.PdfDocument();
            SelectPdf.PdfPage page = doc.AddPage();
            
            var font = doc.AddFont(SelectPdf.PdfStandardFont.HelveticaBold);
            font.Size = 30;

            var subfont = doc.AddFont(SelectPdf.PdfStandardFont.HelveticaBold);
            subfont.Size = 23;

            var subt = doc.AddFont(PdfStandardFont.HelveticaBold);
            subt.Size = 14;

            var plain = doc.AddFont(PdfStandardFont.Helvetica);
            plain.Size = 14;
            
            SelectPdf.PdfTextElement title = new SelectPdf.PdfTextElement(70, 30, "Conteo General de Ganado", font);
            page.Add(title);
            
            
            var str = new StringBuilder();


            SelectPdf.PdfTextElement text1 = new SelectPdf.PdfTextElement(50, 100,"Ganado Nacido Activo", subfont);
            page.Add(text1);

            text1 = new SelectPdf.PdfTextElement(500, 100, nacidos.Count.ToString(), subfont);
            page.Add(text1);
            
            
            str.Clear();
            str.AppendFormat("Id\t\t\tCategoría");

            SelectPdf.PdfTextElement text2 = new SelectPdf.PdfTextElement(50, 150, str.ToString(), subt);
            page.Add(text2);

            str.Clear();
            text2.Text = "";

            
            foreach (var bovino in nacidos)
            {
                str.AppendFormat("{0}\t\t\t\t\t{1}\n", bovino.Id,bovino.Categoria.Nombre);
                text2 = new SelectPdf.PdfTextElement(50, 170, str.ToString(), plain);
            }
            page.Add(text2);


            text1.Text = "";
            text1 = new SelectPdf.PdfTextElement(50, 250,"Ganado Comprado Activo", subfont);
            page.Add(text1);
            text1 = new SelectPdf.PdfTextElement(500, 250, comprados.Count.ToString(), subfont);
            page.Add(text1);


            str.Clear();
            str.AppendFormat("Id\t\t\tCategoría");
            
            text2.Text = "";
            text2 = new SelectPdf.PdfTextElement(50, 300, str.ToString(), subt);
            page.Add(text2);

            str.Clear();
            text2.Text = "";

            foreach (var bovino in comprados)
            {
                str.AppendFormat("{0}\t\t\t\t\t{1}\n", bovino.Id, bovino.Categoria.Nombre);
                text2 = new SelectPdf.PdfTextElement(50, 320, str.ToString(), plain);
            }
            page.Add(text2);


            text1.Text = "";
            text1 = new SelectPdf.PdfTextElement(50, 380, "Ganado Muerto", subfont);
            page.Add(text1);
            
            text1 = new SelectPdf.PdfTextElement(500, 380, muertos.Count.ToString(), subfont);
            
            page.Add(text1);


            str.Clear();
            str.AppendFormat("Id\t\t\tCategoría");

            text2.Text = "";
            text2 = new SelectPdf.PdfTextElement(50, 430, str.ToString(), subt);
            page.Add(text2);

            str.Clear();
            text2.Text = "";

            foreach (var bovino in muertos)
            {
                str.AppendFormat("{0}\t\t\t\t\t{1}\n", bovino.Id, bovino.Categoria.Nombre);
                text2 = new SelectPdf.PdfTextElement(50, 450, str.ToString(), plain);
            }
            page.Add(text2);


            text1.Text = "";
            text1 = new SelectPdf.PdfTextElement(50, 510, "Ganado Vendido", subfont);
            page.Add(text1);

            text1 = new SelectPdf.PdfTextElement(500, 510, vendidos.Count.ToString(), subfont);

            page.Add(text1);


            str.Clear();
            str.AppendFormat("Id\t\t\tCategoría");

            text2.Text = "";
            text2 = new SelectPdf.PdfTextElement(50, 560, str.ToString(), subt);
            page.Add(text2);

            str.Clear();
            text2.Text = "";

            foreach (var bovino in vendidos)
            {
                str.AppendFormat("{0}\t\t\t\t\t{1}\n", bovino.Id, bovino.Categoria.Nombre);
                text2 = new SelectPdf.PdfTextElement(50, 580, str.ToString(), plain);
            }
            page.Add(text2);


            text1.Text = "";
            text1 = new SelectPdf.PdfTextElement(50, 620, "Total Ganado", subfont);
            page.Add(text1);

            text1 = new SelectPdf.PdfTextElement(500, 620, (nacidos.Count + comprados.Count + muertos.Count + vendidos.Count).ToString(), subfont);

            page.Add(text1);



            PdfTemplate template = doc.AddTemplate(doc.Pages[0].ClientRectangle);
            PdfImageElement img = new PdfImageElement(
                doc.Pages[0].ClientRectangle.Width - 600,
                doc.Pages[0].ClientRectangle.Height - 850, "C:\\Users\\luigi\\Downloads\\TAG\\TAG\\water.gif");
            img.Transparency = 50;
            template.Background = true;
            template.Add(img);

            doc.Save("ReporteGanado.pdf");
            doc.Close();

            //System.Diagnostics.Process.Start("chrome.exe",
            //  "C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Reportes\\bin\\Debug\\ReporteGanado.pdf");
            return doc;
        }
    }
}
