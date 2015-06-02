using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Categorias.GUI
{
    public partial class FormCategoriaLista : Form
    {
        public FormCategoriaLista()
        {
            InitializeComponent();
        }

        private void FormListaCategoria_Load(object sender, EventArgs e)
        {
            FormCategoriaListaController.GetInstance().LoadForm(dataGV_Categoria);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            FormCategoriaListaController.GetInstance().LoadForm(dataGV_Categoria);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var FormCategoria = new FormCategoria();
            FormCategoria.CategoriaSelected = dataGV_Categoria.SelectedRows[0].Cells[1].Value.ToString();
            FormCategoria.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var SelectedRow = dataGV_Categoria.SelectedRows[0].Cells[1].Value.ToString();
            var message = MessageBox.Show("¿Está seguro de que quiere eliminar la categoría " + SelectedRow + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (message.Equals(DialogResult.Yes))
            {
                var deleted = FormCategoriaListaController.GetInstance().DeleteItem(SelectedRow);
                if (deleted)
                    FormCategoriaListaController.GetInstance().LoadForm(dataGV_Categoria);
                else
                    MessageBox.Show("Error al intentar eliminar la categoria. Existen " + SelectedRow + "s.\nElimine todos los bovinos de esa categoria y vuelva a intentarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            var FormCategoria = new FormCategoria();
            FormCategoria.CategoriaSelected = null;
            FormCategoria.ShowDialog();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().SetAll();
            MessageBox.Show("Los cambios han sido guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
