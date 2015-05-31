using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Aplicacion;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace Trazabilidad.App.Ganado.GUI
{
    public class FormGanadoListaController
    {
        private static FormGanadoListaController instance;

        private FormGanadoListaController()
        { 
        }

        public static FormGanadoListaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormGanadoListaController();
            }

            return instance;
        }

        public void New()
        {
            new FormEntrada().ShowDialog();
        }

        public void Delete(TabControl tab)
        {
            var FormSalida = new FormSalida();

            var activeTab = tab.SelectedTab;
            var selectedId = (Int32)activeTab.Controls
                            .OfType<DataGridView>()
                            .First()
                            .SelectedRows[0].Cells["Id"].Value;


            if (activeTab.Text.Equals("Nacidos"))
            {
                FormSalida.TipoBovino = FactoriaAplicaciones<NacidoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                FormSalida.ShowDialog();
                return;
            }

            if (activeTab.Text.Equals("Comprados"))
            {
                FormSalida.TipoBovino = FactoriaAplicaciones<CompradoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                FormSalida.ShowDialog();
                return;
            }

            var FormEntrada = new FormEntrada();

            if (activeTab.Text.Equals("Muertos"))
            {
                FormEntrada.TipoBovino = FactoriaAplicaciones<MuertoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));

            }

            if (activeTab.Text.Equals("Vendidos"))
            {
                FormEntrada.TipoBovino = FactoriaAplicaciones<VendidoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
            }

            FormEntrada.ShowDialog();
        }

        public void Edit(TabControl tab)
        {
            var FormEntrada = new FormEntrada();

            var activeTab = tab.SelectedTab;

            var selectedId = (Int32)activeTab.Controls
                            .OfType<DataGridView>()
                            .First()
                            .SelectedRows[0].Cells["Id"].Value;

            if (activeTab.Text.Equals("Nacidos"))
            {
                FormEntrada.TipoBovino = FactoriaAplicaciones<NacidoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                FormEntrada.ShowDialog();
                return;
            }

            if (activeTab.Text.Equals("Comprados"))
            {
                FormEntrada.TipoBovino = FactoriaAplicaciones<CompradoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                FormEntrada.ShowDialog();
                return;
            }
            
            var FormSalida = new FormSalida();

            if (activeTab.Text.Equals("Muertos"))
            {
                FormSalida.TipoBovino = FactoriaAplicaciones<MuertoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));

            }

            if (activeTab.Text.Equals("Vendidos"))
            {
                FormSalida.TipoBovino = FactoriaAplicaciones<VendidoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
            }
            FormSalida.ShowDialog();
        }

        public void LoadForm<T>(DataGridView dataGV_ListaGanado)
        {
            var PropertyListener = FactoriaAplicaciones<T>.GetInstance().GetAplicacion().GetAll();
            var bl = new BindingList<T>(PropertyListener);
            var source = new BindingSource(bl, null);
            dataGV_ListaGanado.DataSource = source;

            dataGV_ListaGanado.Columns["Id"].DisplayIndex = 0;
            dataGV_ListaGanado.Columns["Categoria"].DisplayIndex = 1;
            dataGV_ListaGanado.Columns["Sexo"].DisplayIndex = 2;
        }

        public bool DeleteItem(Int32 Id)
        {
            //var PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            //foreach (var item in PropertyListener)
            //{
            //    if (item.Id.Equals(Id))
            //    {
            //        PropertyListener.Remove(item);
            //        return true;
            //    }
            //}
            return false;
        }
    }
}
