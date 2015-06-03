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
    public partial class FormGanadoLista : Form
    {
        
        public FormGanadoLista()
        {
            InitializeComponent();
        }

        private void FormListaGanado_Load(object sender, EventArgs e)
        {
            FormGanadoListaController.GetInstance().LoadForm<MuertoItemListener>(dataGridView3);
            FormGanadoListaController.GetInstance().LoadForm<VendidoItemListener>(dataGridView4);            
            FormGanadoListaController.GetInstance().LoadForm<NacidoItemListener>(dataGridView1);
            FormGanadoListaController.GetInstance().LoadForm<CompradoItemListener>(dataGridView2);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            FormGanadoListaController.GetInstance().LoadForm<MuertoItemListener>(dataGridView3);
            FormGanadoListaController.GetInstance().LoadForm<VendidoItemListener>(dataGridView4);
            FormGanadoListaController.GetInstance().LoadForm<NacidoItemListener>(dataGridView1);
            FormGanadoListaController.GetInstance().LoadForm<CompradoItemListener>(dataGridView2);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            FormGanadoListaController.GetInstance().Edit(tabControl1);            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            FormGanadoListaController.GetInstance().Delete(tabControl1);
            //var SelectedRow = (Int32)dataGV_Ganado.SelectedRows[0].Cells[0].Value;
            //var message = MessageBox.Show("¿Está seguro de que quiere eliminar el bovino " + SelectedRow + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (message.Equals(DialogResult.Yes))
            //{
            //    FormGanadoListaController.GetInstance().DeleteItem(SelectedRow);
            //    FormGanadoListaController.GetInstance().LoadForm(dataGV_Ganado);
            //}
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            FormGanadoListaController.GetInstance().New();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selTab = (sender as TabControl).SelectedTab;

            if (selTab.Text.Equals("Nacidos") || selTab.Text.Equals("Comprados"))
            {
                btn_Eliminar.Text = "Eliminar"; 
            }

            if (selTab.Text.Equals("Muertos") || selTab.Text.Equals("Vendidos"))
            {
                btn_Eliminar.Text = "Restaurar";
            }

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().SetAll();
            FactoriaAplicaciones<TrazaItemListener>.GetInstance().GetAplicacion().SetAll();
            MessageBox.Show("Los cambios han sido guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
