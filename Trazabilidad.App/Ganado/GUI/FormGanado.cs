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
    public partial class FormGanado : Form
    {
        public FormGanado()
        {
            InitializeComponent();
        }

        private void FormGanado_Load(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().EmptyDateTimePickerFormat(dateTP_Entrada);
            FormGanadoController.GetInstance().EmptyDateTimePickerFormat(dateTP_Salida);
            FormGanadoController.GetInstance().LoadComboBox(comboBx_BovinoId);
        }

        private void comboBx_BovinoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().LoadForm(comboBx_BovinoId.SelectedItem.ToString(),
                txtBx_Madre, txtBx_Padre, lbl_Entrada, dateTP_Entrada, lbl_Salida, dateTP_Salida,
                txtBx_Categoria, radioBtn_Hembra, radioBtn_Macho, checkBx_Estado);
        }

        private void dateTP_Entrada_ValueChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().SetDateTimePickerFormat(dateTP_Entrada);
        }

        private void dateTP_Salida_ValueChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().SetDateTimePickerFormat(dateTP_Salida);
        }
    }
}
