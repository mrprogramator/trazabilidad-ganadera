using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Entradas.GUI
{
    public partial class FormEntradasLista : Form
    {
        public FormEntradasLista()
        {
            InitializeComponent();
        }

        private void FormListaEntrada_Load(object sender, EventArgs e)
        {
            FormEntradasListaController.GetInstance().LoadForm(dataGV_Entrada);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            FormEntradasListaController.GetInstance().LoadForm(dataGV_Entrada);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //var FormEntrada = new FormEntrada();
            //FormEntrada.BovinoIdSelected = (Int32)dataGV_Entrada.SelectedRows[0].Cells[0].Value;
            //FormEntrada.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //var SelectedRow = (Int32)dataGV_Entrada.SelectedRows[0].Cells[0].Value;
            //var message = MessageBox.Show("¿Está seguro de que quiere eliminar el bovino " + SelectedRow + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (message.Equals(DialogResult.Yes))
            //{
            //    FormEntradaListaController.GetInstance().DeleteItem(SelectedRow);
            //    FormEntradaListaController.GetInstance().LoadForm(dataGV_Entrada);
            //}
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //var FormEntrada = new FormEntrada();
            //FormEntrada.BovinoIdSelected = null;
            //FormEntrada.ShowDialog();
        }
              
    }
}
