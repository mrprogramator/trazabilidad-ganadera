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
    public partial class FormInseminacion : Form
    {
        public Object TipoSanidad;

        public FormInseminacion()
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
              
        private void FormEntrada_Load(object sender, EventArgs e)
        {
            FormInseminacionController.GetInstance().LoadFormSanidad(TipoSanidad, textBoxSanidadId, dateTPEntrada, richTextBoxObservaciones, comboBoxBovino, comboBoxPadre);
        
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
            if (comboBoxBovino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una madre.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxPadre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un padre.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormInseminacionController.GetInstance().Update(TipoSanidad, textBoxSanidadId, dateTPEntrada, richTextBoxObservaciones, comboBoxBovino, comboBoxPadre);
        
            MessageBox.Show("Se han registrado los cambios.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }
    }
}
