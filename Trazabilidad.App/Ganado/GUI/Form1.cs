using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Ganado.Aplicacion;

namespace Trazabilidad.App.Ganado.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormMainController.GetInstance().cargarComboBox(comboBx_BovinoId);
        }

        private void comboBx_BovinoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormMainController.GetInstance().cargarForm(comboBx_BovinoId.SelectedItem.ToString(), txtBx_Madre, txtBx_Padre, lbl_Entrada, dateTP_Entrada, lbl_Salida, dateTP_Salida, txtBx_Categoria, radioBtn_Hembra, radioBtn_Macho, checkBx_Estado);
        }
    }
}
