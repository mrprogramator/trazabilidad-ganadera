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
    public partial class FormEntrada : Form
    {
        public Object TipoBovino;

        public FormEntrada()
        {
            InitializeComponent();
        }

        private void textBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radioBtnNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            labelPrecio.Visible = !(sender as RadioButton).Checked;
            textBoxPrecio.Visible = !(sender as RadioButton).Checked;
            groupBoxDescendencia.Visible = (sender as RadioButton).Checked;
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            

            Categorias.GUI
                .FormCategoriaController.GetInstance().LoadComboBoxCategoria(comboBoxCategoria);

            if (TipoBovino != null)
            {
                FormEntradaController.GetInstance().LoadComboBoxMadre(comboBoxMadre,TipoBovino);
                FormEntradaController.GetInstance().LoadComboBoxPadre(comboBoxPadre,TipoBovino);

                textBoxBovinoId.Text = (TipoBovino as GanadoItemListener).Id.ToString();

                if (TipoBovino is NacidoItemListener || TipoBovino is CompradoItemListener)
                {
                    LayoutTipo.Enabled = false;
                }
            }
            else
            {
                FormEntradaController.GetInstance().LoadComboBoxMadre(comboBoxMadre);
                FormEntradaController.GetInstance().LoadComboBoxPadre(comboBoxPadre);

                textBoxBovinoId.Visible = false;
                labelBovinoId.Visible = false;
            }
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            var FormCategoria = new Categorias.GUI.FormCategoria();
            FormCategoria.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Ingrese una categoria","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBoxPrecio.Text == "" && textBoxPrecio.Visible)
            {
                MessageBox.Show("Ingrese el precio de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (TipoBovino == null)
            {
                var sucessful = FormEntradaController.GetInstance().AddItem(comboBoxCategoria, dateTPEntrada, richTextBoxObservaciones, textBoxPrecio, LayoutTipo, comboBoxPadre, comboBoxMadre);
                if (sucessful)
                {
                    MessageBox.Show("El registro fue agregado exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var sucessful = FormEntradaController.GetInstance().EditItem(TipoBovino,comboBoxCategoria, dateTPEntrada, richTextBoxObservaciones, textBoxPrecio, LayoutTipo, comboBoxPadre, comboBoxMadre);
                if (sucessful)
                {
                    MessageBox.Show("El registro fue editado exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Dispose();
        }

        private void FormEntrada_Activated(object sender, EventArgs e)
        {
            Categorias.GUI
                .FormCategoriaController.GetInstance().LoadComboBoxCategoria(comboBoxCategoria);
            if (TipoBovino == null)
            {
                FormEntradaController.GetInstance().LoadComboBoxMadre(comboBoxMadre);
                FormEntradaController.GetInstance().LoadComboBoxPadre(comboBoxPadre);
            }
            else
            {
                FormEntradaController.GetInstance().LoadComboBoxMadre(comboBoxMadre,TipoBovino);
                FormEntradaController.GetInstance().LoadComboBoxPadre(comboBoxPadre,TipoBovino);
            }
            FormEntradaController.GetInstance().LoadFormGanado(TipoBovino, comboBoxCategoria, dateTPEntrada, richTextBoxObservaciones, radioBtnNacimiento, radioBtnCompra, textBoxPrecio, comboBoxPadre, comboBoxMadre);
        }

        private void comboBxBovinoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormEntradaController.GetInstance().LoadFormGanado(TipoBovino, comboBoxCategoria, dateTPEntrada, richTextBoxObservaciones, radioBtnNacimiento, radioBtnCompra, textBoxPrecio, comboBoxPadre, comboBoxMadre);
            
        }

        

    }
}
