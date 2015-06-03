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
    public class ReporteTraza
    {
        public PdfDocument makeReport(Int32 bovinoId)
        {
            var Traza = Ganado.Servicios.FactoriaServiciosLocales<Traza>.GetInstance().GetServicio().Generate();
            var lista_bovino = Ganado.Servicios.FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().Generate();

            var lista_ins = Sanidad.Servicios.FactoriaServiciosLocales<Inseminacion>.GetInstance().GetServicio().GetAll();
            var lista_palp = Sanidad.Servicios.FactoriaServiciosLocales<Palpacion>.GetInstance().GetServicio().GetAll();
            var lista_pren = Sanidad.Servicios.FactoriaServiciosLocales<Preñado>.GetInstance().GetServicio().GetAll();
            var lista_vac = Sanidad.Servicios.FactoriaServiciosLocales<Vacuna>.GetInstance().GetServicio().GetAll();

            var bovino = lista_bovino.FirstOrDefault(b => b.Id.Equals(bovinoId));

            var intervalos = new List<intervalItem>();
            
            var ant = new intervalItem();

            Traza.Sort((a, b) => a.Id - b.Id);

            foreach (var traza in Traza)
            {
                if (traza.Bovino.Id.Equals(bovinoId))
                {
                    var item = new intervalItem()
                    {
                        Inicio = traza.Fecha,
                        Bovino = traza.Bovino,
                        Fin = traza.Fecha
                    };
                    intervalos.Add(item);

                    if (ant == null)
                    {
                        continue;
                    }

                    ant.Fin = item.Inicio;
                }
            }

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

            var x = 30;
            
            SelectPdf.PdfTextElement title = new SelectPdf.PdfTextElement(70, x, "Trazabilidad del Bovino " + bovinoId.ToString(), font);
            page.Add(title);
            x += 50;

            SelectPdf.PdfTextElement subtitle = new SelectPdf.PdfTextElement(50, x, "Categoria", subfont);
            page.Add(subtitle);

            subtitle = new SelectPdf.PdfTextElement(300, x, "Fecha", subfont);
            page.Add(subtitle);
            var traza_bovino = Traza.All(t => t.Bovino.Id.Equals(bovinoId));
           
            foreach (var traza in intervalos)
            {
                if (traza.Bovino.Id.Equals(bovinoId))
                {
                    x += 50;
                    subtitle.Text = "";
                    subtitle = new SelectPdf.PdfTextElement(50, x, traza.Bovino.Categoria.Nombre, plain);
                    page.Add(subtitle);
                        
                    subtitle = new SelectPdf.PdfTextElement(300, x, traza.Inicio.ToString(), plain);
                    page.Add(subtitle);
                    
                    x += 30;
                    subtitle.Text = "";
                    subtitle = new SelectPdf.PdfTextElement(70, x, "Sanidad", subt);
                    page.Add(subtitle);

                    foreach (var ins in lista_ins)
                    {
                        if ( ( ins.Bovino.Id.Equals(traza.Bovino.Id)  || ins.Padre.Id.Equals(traza.Bovino.Id)) && ins.Fecha >= traza.Inicio && ins.Fecha <= traza.Fin)
                        {
                            x += 30;
                            subtitle.Text = "";
                            subtitle = new SelectPdf.PdfTextElement(70, x, "Inseminación", plain);
                            page.Add(subtitle);

                            subtitle = new SelectPdf.PdfTextElement(300, x, ins.Fecha.ToString(), plain);
                            page.Add(subtitle);
                        }
                    }

                    foreach (var sanidad in lista_palp)
                    {
                        if (sanidad.Bovino.Id.Equals(traza.Bovino.Id) && sanidad.Fecha >= traza.Inicio && sanidad.Fecha <= traza.Fin)
                        {
                            x += 30;
                            subtitle.Text = "";
                            subtitle = new SelectPdf.PdfTextElement(70, x, "Palpación", plain);
                            page.Add(subtitle);

                            subtitle = new SelectPdf.PdfTextElement(300, x, sanidad.Fecha.ToString(), plain);
                            page.Add(subtitle);
                        }
                    }

                    foreach (var sanidad in lista_pren)
                    {
                        if (sanidad.Bovino.Id.Equals(traza.Bovino.Id) && sanidad.Fecha >= traza.Inicio && sanidad.Fecha <= traza.Fin)
                        {
                            x += 30;
                            subtitle.Text = "";
                            subtitle = new SelectPdf.PdfTextElement(70, x, "Preñado", plain);
                            page.Add(subtitle);

                            subtitle = new SelectPdf.PdfTextElement(300, x, sanidad.Fecha.ToString(), plain);
                            page.Add(subtitle);
                        }
                    }

                    foreach (var sanidad in lista_vac)
                    {
                        if (sanidad.Bovino.Id.Equals(traza.Bovino.Id) && sanidad.Fecha >= traza.Inicio && sanidad.Fecha <= traza.Fin)
                        {
                            x += 30;
                            subtitle.Text = "";
                            subtitle = new SelectPdf.PdfTextElement(70, x, "Vacuna " + sanidad.Nombre, plain);
                            page.Add(subtitle);

                            subtitle = new SelectPdf.PdfTextElement(300, x, sanidad.Fecha.ToString(), plain);
                            page.Add(subtitle);
                        }
                    }
                }
            }
            x += 50;

            PdfTemplate template = doc.AddTemplate(doc.Pages[0].ClientRectangle);
            PdfImageElement img = new PdfImageElement(
                doc.Pages[0].ClientRectangle.Width - 600,
                doc.Pages[0].ClientRectangle.Height - 850, "C:\\Users\\luigi\\Downloads\\TAG\\TAG\\water.gif");
            img.Transparency = 50;
            template.Background = true;
            template.Add(img);

            doc.Save("ReporteTraza" + bovinoId.ToString() + ".pdf");
            doc.Close();

            return doc;
        }
    }
}

public class intervalItem
{
    public DateTime Inicio { get; set; }

    public DateTime Fin { get; set; }

    public virtual Bovino Bovino { get; set; }
}
