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
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

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

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
