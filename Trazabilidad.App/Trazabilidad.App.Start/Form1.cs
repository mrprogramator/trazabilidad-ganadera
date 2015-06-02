using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Start
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGanado_Click(object sender, EventArgs e)
        {
            new Ganado.GUI.FormGanadoLista().ShowDialog();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            new Categorias.GUI.FormCategoriaLista().ShowDialog();
        }

        private void buttonSanidad_Click(object sender, EventArgs e)
        {
            new Sanidad.GUI.FormSanidadLista().ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            new Reporte.GUI.FormReporte().ShowDialog();
        }
    }
}
