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
    public class ReporteInseminacion
    {
        public PdfDocument makeReport()
        {
            var Inseminacion = Sanidad.Servicios.FactoriaServiciosLocales<Inseminacion>.GetInstance().GetServicio().GetAll();
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
            
            SelectPdf.PdfTextElement title = new SelectPdf.PdfTextElement(70, 30, "Conteo General de Inseminaciones", font);
            page.Add(title);


            SelectPdf.PdfTextElement subtitle = new SelectPdf.PdfTextElement(50, 150, "Vacas", subfont);
            page.Add(subtitle);


            SelectPdf.PdfTextElement subsubtitle = new SelectPdf.PdfTextElement(50, 175, "Id", subt);
            page.Add(subsubtitle);

            subsubtitle = new SelectPdf.PdfTextElement(300, 175, "Cantidad", subt);
            page.Add(subsubtitle);
            var str = new StringBuilder();

            var supertotal = 0;
            var total = 0;
            var row = 200;
            foreach (var bovino in ganado)
            {
                var count = 0;
                
                foreach (var sanidad in Inseminacion)
                {
                    if (bovino.Categoria.Nombre.Equals("vaca") && sanidad.Bovino.Id.Equals(bovino.Id))
                    {
                        count++;
                    }                    
                }

                if (count == 0)
                    continue;

                SelectPdf.PdfTextElement text1 = new SelectPdf.PdfTextElement(50, row, bovino.Id.ToString(), plain);
                page.Add(text1);

                text1 = new SelectPdf.PdfTextElement(300, row, count.ToString(), plain);
                page.Add(text1);
                
                row += 30;
                total ++;
            }

            subtitle = new SelectPdf.PdfTextElement(500, 150, total.ToString(),subfont);
            page.Add(subtitle);

            supertotal += total;

            subtitle.Text = "";

            var sub2 = row + 30;
 
            subtitle = new SelectPdf.PdfTextElement(50, sub2, "Toros", subfont);
            page.Add(subtitle);

            subsubtitle.Text = "";

            subsubtitle = new SelectPdf.PdfTextElement(50, row + 55, "Id", subt);
            page.Add(subsubtitle);

            subsubtitle = new SelectPdf.PdfTextElement(300, row + 55, "Cantidad", subt);
            page.Add(subsubtitle);

            
            total = 0;
            row = sub2 + 50;
            foreach (var bovino in ganado)
            {
                var count = 0;

                foreach (var sanidad in Inseminacion)
                {
                    if (bovino.Categoria.Nombre.Equals("toro") && sanidad.Padre.Id.Equals(bovino.Id))
                    {
                        count++;
                    }
                }

                if (count == 0)
                    continue;

                SelectPdf.PdfTextElement text1 = new SelectPdf.PdfTextElement(50, row, bovino.Id.ToString(), plain);
                page.Add(text1);

                text1 = new SelectPdf.PdfTextElement(300, row, count.ToString(), plain);
                page.Add(text1);

                row += 30;
                total++;
            }

            subtitle = new SelectPdf.PdfTextElement(500, sub2, total.ToString(), subfont);
            page.Add(subtitle);

            supertotal += total;



            var text = new SelectPdf.PdfTextElement(50, 420, "Total Ganado", subfont);
            page.Add(text);

            text = new SelectPdf.PdfTextElement(500, 420, supertotal.ToString(), subfont);
            page.Add(text);

            text.Text = "";
            text = new SelectPdf.PdfTextElement(50, 470, "Total Inseminaciones", subfont);
            page.Add(text);

            text = new SelectPdf.PdfTextElement(500, 470, Inseminacion.Count.ToString(), subfont);
            page.Add(text);

            PdfTemplate template = doc.AddTemplate(doc.Pages[0].ClientRectangle);
            PdfImageElement img = new PdfImageElement(
                doc.Pages[0].ClientRectangle.Width - 600,
                doc.Pages[0].ClientRectangle.Height - 850, "C:\\Users\\luigi\\Downloads\\TAG\\TAG\\water.gif");
            img.Transparency = 50;
            template.Background = true;
            template.Add(img);

            doc.Save("ReporteInseminacion.pdf");
            doc.Close();

            return doc;
        }
    }
}
