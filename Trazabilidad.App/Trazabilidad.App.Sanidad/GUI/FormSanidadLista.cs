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
    public partial class FormSanidadLista : Form
    {
        public FormSanidadLista()
        {
            InitializeComponent();
        }

        private void FormListaSanidad_Load(object sender, EventArgs e)
        {
            FormSanidadListaController.GetInstance().LoadForm<InseminacionItemListener>(dataGridView1);
            FormSanidadListaController.GetInstance().LoadForm<PalpacionItemListener>(dataGridView2);            
            FormSanidadListaController.GetInstance().LoadForm<PreñadoItemListener>(dataGridView3);
            FormSanidadListaController.GetInstance().LoadForm<VacunaItemListener>(dataGridView4);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            FormSanidadListaController.GetInstance().LoadForm<InseminacionItemListener>(dataGridView1);
            FormSanidadListaController.GetInstance().LoadForm<PalpacionItemListener>(dataGridView2);
            FormSanidadListaController.GetInstance().LoadForm<PreñadoItemListener>(dataGridView3);
            FormSanidadListaController.GetInstance().LoadForm<VacunaItemListener>(dataGridView4);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            FormSanidadListaController.GetInstance().Edit(tabControl1);            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            FormSanidadListaController.GetInstance().Delete(tabControl1);
            //var SelectedRow = (Int32)dataGV_Sanidad.SelectedRows[0].Cells[0].Value;
            //var message = MessageBox.Show("¿Está seguro de que quiere eliminar el bovino " + SelectedRow + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (message.Equals(DialogResult.Yes))
            //{
            //    FormSanidadListaController.GetInstance().DeleteItem(SelectedRow);
            //    FormSanidadListaController.GetInstance().LoadForm(dataGV_Sanidad);
            //}
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            FormSanidadListaController.GetInstance().New(tabControl1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            FactoriaAplicaciones<InseminacionItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<PalpacionItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<PreñadoItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<VacunaItemListener>.GetInstance().GetAplicacion().SetAll();
            MessageBox.Show("Los cambios han sido guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
