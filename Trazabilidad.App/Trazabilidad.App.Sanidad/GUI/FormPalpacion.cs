using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Sanidad.Aplicacion;

namespace Trazabilidad.App.Sanidad.GUI
{
    public partial class FormPalpacion : Form
    {
        public Object TipoSanidad;

        public FormPalpacion()
        {
            InitializeComponent();
        }

        private void textBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
              
        private void FormEntrada_Load(object sender, EventArgs e)
        {
            FormPalpacionController.GetInstance().LoadFormSanidad(TipoSanidad, textBoxSanidadId, dateTPEntrada, textBoxNumero, textBoxMes, checkBoxEstado, comboBoxBovino);
        
            if (TipoSanidad == null)
            {
                textBoxSanidadId.Visible = false;
                labelSanidadId.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxMes.Text.Equals(""))
            {
                textBoxMes.Text = "0";
            }

            if (textBoxNumero.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el número de palpación.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxBovino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un bovino.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormPalpacionController.GetInstance().Update(TipoSanidad, textBoxSanidadId, dateTPEntrada,textBoxNumero,textBoxMes,checkBoxEstado,comboBoxBovino);

            MessageBox.Show("Se han registrado los cambios.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }
    }
}
