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
    public partial class FormSalida : Form
    {
        public Object TipoBovino;

        public FormSalida()
        {
            InitializeComponent();
        }

        private void radioBtnMuerte_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                labelObservaciones.Text = "Causa";
            }

            labelPrecio.Visible = !(sender as RadioButton).Checked;
            textBoxPrecio.Visible = !(sender as RadioButton).Checked;

            labelDestino.Visible = !(sender as RadioButton).Checked;
            textBxDestino.Visible = !(sender as RadioButton).Checked;
        }

        private void radioBtnVenta_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                labelObservaciones.Text = "Observaciones";
            }
        }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            FormSalidaController.GetInstance().LoadFormSalida(TipoBovino, dateTimePicker1, richTextBox1, radioBtnMuerte, radioBtnVenta, textBoxPrecio, textBxDestino);           
            
            if (TipoBovino != null)
            {
                textBoxBovinoId.Text = (TipoBovino as GanadoItemListener).Id.ToString();
                
                if (TipoBovino is MuertoItemListener || TipoBovino is VendidoItemListener)
                {
                    tableLayoutTipo.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (labelObservaciones.Text.Equals("Causa") && richTextBox1.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la causa de muerte","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxPrecio.Visible && textBoxPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el precio de la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            if (textBxDestino.Visible && textBxDestino.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el destino de la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var successfull = FormSalidaController.GetInstance().Register(TipoBovino, dateTimePicker1, richTextBox1, tableLayoutTipo, textBoxPrecio, textBxDestino);

            if (successfull)
            {
                MessageBox.Show("Se han registrado los cambios.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            this.Dispose();
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
