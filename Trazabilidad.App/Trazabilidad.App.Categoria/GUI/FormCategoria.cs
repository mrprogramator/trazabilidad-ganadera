using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Categorias.Aplicacion;

namespace Trazabilidad.App.Categorias.GUI
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        public Object CategoriaSelected { get; set; }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            FormCategoriaController.GetInstance().LoadComboBoxCategoria(comboBx_Nombre);
            comboBx_Nombre.SelectedItem = CategoriaSelected;
            if (comboBx_Nombre.SelectedItem == null)
            {
                comboBx_Nombre.DropDownStyle = ComboBoxStyle.Simple;

                lbl_Tittle.Text = "Nueva Categoria";
                btn_Guardar.Text = "Registrar";
            }
            else 
            {
                
            }
        }

        private void comboBx_BovinoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormCategoriaController.GetInstance().LoadForm(comboBx_Nombre, richTextBx_Descripcion,LayoutSex);
        }       

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (comboBx_Nombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoría.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            
            if (comboBx_Nombre.DropDownStyle.Equals(ComboBoxStyle.Simple))
            {                
                var succesfullAdd = FormCategoriaController.GetInstance().AddItem(comboBx_Nombre, richTextBx_Descripcion,LayoutSex);
                if (succesfullAdd)
                {
                    MessageBox.Show("El registro fue agregado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var succesfullEdit = FormCategoriaController.GetInstance().EditItem(comboBx_Nombre, richTextBx_Descripcion,LayoutSex);

                if (succesfullEdit)
                {
                    MessageBox.Show("El registro fue editado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al editar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
                 
    }
}
