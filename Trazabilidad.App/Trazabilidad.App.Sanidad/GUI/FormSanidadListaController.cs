using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Sanidad.Aplicacion;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace Trazabilidad.App.Sanidad.GUI
{
    public class FormSanidadListaController
    {
        private static FormSanidadListaController instance;

        private FormSanidadListaController()
        { 
        }

        public static FormSanidadListaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormSanidadListaController();
            }

            return instance;
        }

        public void New(TabControl tab)
        {
            var activeTab = tab.SelectedTab;

            if (activeTab.Text.Equals("Inseminación"))
            {
                new FormInseminacion().ShowDialog();
            }

            if (activeTab.Text.Equals("Palpación"))
            {
                new FormPalpacion().ShowDialog();
            }

            if (activeTab.Text.Equals("Preñado"))
            {
                new FormPreñado().ShowDialog();
            }

            if (activeTab.Text.Equals("Vacunas"))
            {
                new FormVacuna().ShowDialog();
            }
        }

        public void Delete(TabControl tab)
        {
            //var FormSalida = new FormSalida();

            //var activeTab = tab.SelectedTab;
            //var selectedId = (Int32)activeTab.Controls
            //                .OfType<DataGridView>()
            //                .First()
            //                .SelectedRows[0].Cells["Id"].Value;


            //if (activeTab.Text.Equals("Inseminacion"))
            //{
            //    FormSalida.TipoSanidad = FactoriaAplicaciones<InseminacionItemListener>
            //                            .GetInstance().GetAplicacion()
            //                            .GetAll()
            //                            .Find(b => b.Id.Equals(selectedId));
            //    FormSalida.ShowDialog();
            //    return;
            //}

            //if (activeTab.Text.Equals("Palpacion"))
            //{
            //    FormSalida.TipoSanidad = FactoriaAplicaciones<PalpacionItemListener>
            //                            .GetInstance().GetAplicacion()
            //                            .GetAll()
            //                            .Find(b => b.Id.Equals(selectedId));
            //    FormSalida.ShowDialog();
            //    return;
            //}

            //var FormEntrada = new FormEntrada();

            //if (activeTab.Text.Equals("Preñado"))
            //{
            //    FormEntrada.TipoSanidad = FactoriaAplicaciones<PreñadoItemListener>
            //                            .GetInstance().GetAplicacion()
            //                            .GetAll()
            //                            .Find(b => b.Id.Equals(selectedId));

            //}

            //if (activeTab.Text.Equals("Vacunas"))
            //{
            //    FormEntrada.TipoSanidad = FactoriaAplicaciones<VacunaItemListener>
            //                            .GetInstance().GetAplicacion()
            //                            .GetAll()
            //                            .Find(b => b.Id.Equals(selectedId));
            //}

            //FormEntrada.ShowDialog();
        }

        public void Edit(TabControl tab)
        {
            var activeTab = tab.SelectedTab;

            if (activeTab.Controls.OfType<DataGridView>().FirstOrDefault().Rows.Count == 0)
            {
                return;
            }
            var selectedId = (Int32)activeTab.Controls
                            .OfType<DataGridView>()
                            .FirstOrDefault()
                            .SelectedRows[0].Cells["Id"].Value;

            if (selectedId == 0)
            {
                return;
            }

            if (activeTab.Text.Equals("Inseminación"))
            {
                var FormInseminacion = new FormInseminacion();
                FormInseminacion.TipoSanidad = FactoriaAplicaciones<InseminacionItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                FormInseminacion.ShowDialog();
            }

            if (activeTab.Text.Equals("Palpación"))
            {
                var FormPalpacion = new FormPalpacion();
                FormPalpacion.TipoSanidad = FactoriaAplicaciones<PalpacionItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));
                
                FormPalpacion.ShowDialog();
            }
            if (activeTab.Text.Equals("Preñado"))
            {
                var FormPreñado = new FormPreñado();
                FormPreñado.TipoSanidad = FactoriaAplicaciones<PreñadoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));

                FormPreñado.ShowDialog();
            }

            if (activeTab.Text.Equals("Vacunas"))
            {
                var FormVacuna = new FormVacuna();
                FormVacuna.TipoSanidad = FactoriaAplicaciones<VacunaItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll()
                                        .Find(b => b.Id.Equals(selectedId));

                FormVacuna.ShowDialog();
            }
        }

        public void LoadForm<T>(DataGridView dataGV_ListaSanidad)
        {
            var PropertyListener = FactoriaAplicaciones<T>.GetInstance().GetAplicacion().GetAll();
            var bl = new BindingList<T>(PropertyListener);
            var source = new BindingSource(bl, null);
            dataGV_ListaSanidad.DataSource = source;

            dataGV_ListaSanidad.Columns["Id"].DisplayIndex = 0;
            dataGV_ListaSanidad.Columns["Fecha"].DisplayIndex = 1;
        }

        public bool DeleteItem(Int32 Id)
        {
            //var PropertyListener = SanidadPropertyListenerAdaptador.GetInstance().GetAll();
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
