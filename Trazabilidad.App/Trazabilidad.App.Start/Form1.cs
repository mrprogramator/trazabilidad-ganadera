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
    }
}
