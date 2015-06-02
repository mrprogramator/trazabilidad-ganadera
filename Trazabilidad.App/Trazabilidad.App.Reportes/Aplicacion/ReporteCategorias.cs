using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectPdf;
using Trazabilidad.App.Categorias.Servicios;
using Trazabilidad.App.Categorias.Dominio;
using Trazabilidad.App.Ganado.Servicios;
using Trazabilidad.App.Ganado.Dominio;

using System.Web;

namespace Trazabilidad.App.Reportes.Aplicacion
{
    public class ReporteCategorias
    {
        public PdfDocument makeReport()
        {
            var categorias = FactoriaServiciosLocales.GetInstance().GetServicioCategoria().GetAll();
            var ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();

            

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
            
            SelectPdf.PdfTextElement title = new SelectPdf.PdfTextElement(70, 30, "Conteo General por Categorías", font);
            page.Add(title);


            SelectPdf.PdfTextElement subtitle = new SelectPdf.PdfTextElement(50, 150, "Nombre", subfont);
            page.Add(subtitle);

            subtitle = new SelectPdf.PdfTextElement(420, 150, "Cantidad", subfont);
            page.Add(subtitle);
            
            var str = new StringBuilder();

            var total = 0;
            var row = 200;
            foreach (var cat in categorias)
            {
                var count = 0;
                
                foreach (var bovino in ganado)
                {
                    if (bovino.Categoria.Id.Equals(cat.Id))
                    {
                        count++;
                    }                    
                }

                SelectPdf.PdfTextElement text1 = new SelectPdf.PdfTextElement(50, row, cat.Nombre, plain);
                page.Add(text1);

                text1 = new SelectPdf.PdfTextElement(500, row, count.ToString(), plain);
                page.Add(text1);
                
                row += 30;
                total += count;
            }

            var text = new SelectPdf.PdfTextElement(50, 420, "Total Ganado", subfont);
            page.Add(text);

            text = new SelectPdf.PdfTextElement(500, 420, total.ToString(), subfont);
            page.Add(text);

            PdfTemplate template = doc.AddTemplate(doc.Pages[0].ClientRectangle);
            PdfImageElement img = new PdfImageElement(
                doc.Pages[0].ClientRectangle.Width - 600,
                doc.Pages[0].ClientRectangle.Height - 850, "C:\\Users\\luigi\\Downloads\\TAG\\TAG\\water.gif");
            img.Transparency = 50;
            template.Background = true;
            template.Add(img);

            doc.Save("ReporteCategorias.pdf");
            doc.Close();

            return doc;
        }
    }
}
