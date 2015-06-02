using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectPdf;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;
using Trazabilidad.App.Ganado.Servicios;
using Trazabilidad.App.Ganado.Dominio;

using System.Web;

namespace Trazabilidad.App.Reportes.Aplicacion
{
    public class ReporteVacuna
    {
        public PdfDocument makeReport()
        {
            var Vacuna = Sanidad.Servicios.FactoriaServiciosLocales<Vacuna>.GetInstance().GetServicio().GetAll();
            var ganado = Ganado.Servicios.FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                        

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
            
            SelectPdf.PdfTextElement title = new SelectPdf.PdfTextElement(70, 30, "Conteo General de Vacunación", font);
            page.Add(title);


           

            var total = 0;
            var row = 200;
            foreach (var sanidad in Vacuna)
            {
                var count = 0;
                SelectPdf.PdfTextElement subtitle = new SelectPdf.PdfTextElement(50, 150, sanidad.Nombre, subfont);
                page.Add(subtitle);


                SelectPdf.PdfTextElement subsubtitle = new SelectPdf.PdfTextElement(50, 175, "Id", subt);
                page.Add(subsubtitle);

                subsubtitle = new SelectPdf.PdfTextElement(200, 175, "Categoria", subt);
                page.Add(subsubtitle);
                
                subsubtitle = new SelectPdf.PdfTextElement(400, 175, "Dosis", subt);
                page.Add(subsubtitle);
                var str = new StringBuilder();

                foreach (var bovino in ganado)
                {
                    if (sanidad.Bovino.Id.Equals(bovino.Id))
                    {
                        SelectPdf.PdfTextElement text1 = new SelectPdf.PdfTextElement(50, row, bovino.Id.ToString(), plain);
                        page.Add(text1);

                        text1 = new SelectPdf.PdfTextElement(200, row, bovino.Categoria.Nombre.ToString(), plain);
                        page.Add(text1); 
                        
                        text1 = new SelectPdf.PdfTextElement(400, row, sanidad.Dosis.ToString(), plain);
                        page.Add(text1);
                    }                    
                }
                
                row += 30;
                total ++;
            }

            var subtitle2 = new SelectPdf.PdfTextElement(500, 150, total.ToString(),subfont);
            page.Add(subtitle2);

            var text = new SelectPdf.PdfTextElement(50, row+30, "Total Ganado", subfont);
            page.Add(text);

            text = new SelectPdf.PdfTextElement(500, row+30, total.ToString(), subfont);
            page.Add(text);

            text.Text = "";
            text = new SelectPdf.PdfTextElement(50, row+80, "Total Vacunas", subfont);
            page.Add(text);

            text = new SelectPdf.PdfTextElement(500, row+80, Vacuna.Count.ToString(), subfont);
            page.Add(text);

            PdfTemplate template = doc.AddTemplate(doc.Pages[0].ClientRectangle);
            PdfImageElement img = new PdfImageElement(
                doc.Pages[0].ClientRectangle.Width - 600,
                doc.Pages[0].ClientRectangle.Height - 850, "C:\\Users\\luigi\\Downloads\\TAG\\TAG\\water.gif");
            img.Transparency = 50;
            template.Background = true;
            template.Add(img);

            doc.Save("ReporteVacuna.pdf");
            doc.Close();

            return doc;
        }
    }
}
