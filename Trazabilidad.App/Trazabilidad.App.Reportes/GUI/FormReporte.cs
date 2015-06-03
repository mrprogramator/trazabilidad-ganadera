using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Reportes.Aplicacion;
using SelectPdf;
using AcroPDFLib;

namespace Trazabilidad.App.Reporte.GUI
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormListaReporte_Load(object sender, EventArgs e)
        {
            //FormReporteController.GetInstance().LoadForm<MuertoItemListener>(dataGridView3);
            //FormReporteController.GetInstance().LoadForm<VendidoItemListener>(dataGridView4);            
            //FormReporteController.GetInstance().LoadForm<NacidoItemListener>(dataGridView1);
            //FormReporteController.GetInstance().LoadForm<CompradoItemListener>(dataGridView2);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //FormReporteController.GetInstance().LoadForm<MuertoItemListener>(dataGridView3);
            //FormReporteController.GetInstance().LoadForm<VendidoItemListener>(dataGridView4);
            //FormReporteController.GetInstance().LoadForm<NacidoItemListener>(dataGridView1);
            //FormReporteController.GetInstance().LoadForm<CompradoItemListener>(dataGridView2);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //FormReporteController.GetInstance().Edit(tabControl1);            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //FormReporteController.GetInstance().Delete(tabControl1);
            //var SelectedRow = (Int32)dataGV_Reporte.SelectedRows[0].Cells[0].Value;
            //var message = MessageBox.Show("¿Está seguro de que quiere eliminar el bovino " + SelectedRow + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (message.Equals(DialogResult.Yes))
            //{
            //    FormReporteController.GetInstance().DeleteItem(SelectedRow);
            //    FormReporteController.GetInstance().LoadForm(dataGV_Reporte);
            //}
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //FormReporteController.GetInstance().New();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selTab = (sender as TabControl).SelectedTab;

            //if (selTab.Text.Equals("Nacidos") || selTab.Text.Equals("Comprados"))
            //{
            //    btn_Eliminar.Text = "Eliminar"; 
            //}

            //if (selTab.Text.Equals("Muertos") || selTab.Text.Equals("Vendidos"))
            //{
            //    btn_Eliminar.Text = "Restaurar";
            //}

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().SetAll();
            //FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().SetAll();
            //FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().SetAll();
            //FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().SetAll();
            //MessageBox.Show("Los cambios han sido guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

            
        }

        private void conteoGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReporteGanado().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReporteGanado.pdf");
        }

        private void conteoPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReporteCategorias().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReporteCategorias.pdf");

        }

        private void inseminaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReporteInseminacion().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReporteInseminacion.pdf");
        }

        private void palpaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReportePalpacion().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReportePalpacion.pdf");
        }

        private void preñadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReportePreñado().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReportePreñado.pdf");

        }

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            new ReporteVacuna().makeReport();
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReporteVacuna.pdf");
        }

        private void trazabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboBox1.Visible = true;
            button1.Visible = true;
            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxGanado(comboBox1, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedId = comboBox1.SelectedItem;
            new ReporteTraza().makeReport((Int32)selectedId);
            webBrowser1.Visible = true;
            LayoutMain.BackgroundImageLayout = ImageLayout.None;
            webBrowser1.Navigate("C:\\Projects\\trazabilidad-ganadera\\Trazabilidad.App\\Trazabilidad.App.Start\\bin\\Debug\\ReporteTraza" + selectedId.ToString() + ".pdf");
        }

    }
}
