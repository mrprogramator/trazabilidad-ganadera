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

        public Object BovinoIdSelected { get; set; }
        
        private void FormGanado_Load(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().EmptyDateTimePickerFormat(dateTP_Entrada);
            FormGanadoController.GetInstance().EmptyDateTimePickerFormat(dateTP_Salida);
            FormGanadoController.GetInstance().LoadComboBoxGanado(comboBx_BovinoId);
            FormGanadoController.GetInstance().LoadComboBoxMadre(comboBx_Madre);
            FormGanadoController.GetInstance().LoadComboBoxPadre(comboBx_Padre);
           
            Categorias.GUI
                .FormCategoriaController.GetInstance().LoadComboBoxCategoria(comboBx_Categoria);
            comboBx_BovinoId.SelectedItem = BovinoIdSelected;
            
            if (comboBx_BovinoId.SelectedItem == null)
            {
                comboBx_BovinoId.Visible = false;
                lbl_BovinoId.Visible = false;
                lbl_Tittle.Text = "Nuevo Bovino";
                btn_Editar.Text = "Registrar";
            }
        }

        private void comboBx_BovinoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().LoadFormGanado(comboBx_BovinoId,
                comboBx_Madre, comboBx_Padre, lbl_Entrada, dateTP_Entrada, lbl_Salida, dateTP_Salida,
                comboBx_Categoria, radioBtn_Hembra, radioBtn_Macho, checkBx_Estado);
        }

        private void dateTP_Entrada_ValueChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().SetDateTimePickerFormat(dateTP_Entrada);
            
        }
        
        private void dateTP_Salida_ValueChanged(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().SetDateTimePickerFormat(dateTP_Salida);
            checkBx_Estado.Checked = (dateTP_Salida.Value == null);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (comboBx_BovinoId.SelectedItem == null)
            {
                var succesfullAdd = FormGanadoController.GetInstance().AddItem(
                                        comboBx_Madre, comboBx_Padre, lbl_Entrada, dateTP_Entrada, lbl_Salida, dateTP_Salida,
                                        comboBx_Categoria, radioBtn_Hembra, radioBtn_Macho, checkBx_Estado);
                if (succesfullAdd)
                {
                    MessageBox.Show("El registro fue agregado exitosamente", "Mensaje");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var succesfullEdit = FormGanadoController.GetInstance().EditItem(comboBx_BovinoId,
                                        comboBx_Madre, comboBx_Padre, lbl_Entrada, dateTP_Entrada, lbl_Salida, dateTP_Salida,
                                        comboBx_Categoria, radioBtn_Hembra, radioBtn_Macho, checkBx_Estado);

                if (succesfullEdit)
                {
                    MessageBox.Show("El registro fue editado exitosamente", "Mensaje");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al editar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTP_Entrada_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("Registre una nueva entrada.");
        }

        private void dateTP_Salida_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("Registre una nueva salida.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGanadoController.GetInstance().LoadFormCategoria();
        }            
    }
}
