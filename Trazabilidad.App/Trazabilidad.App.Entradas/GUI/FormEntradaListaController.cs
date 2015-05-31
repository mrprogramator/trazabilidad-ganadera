using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Aplicacion;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace Trazabilidad.App.Entradas.GUI
{
    public class FormEntradasListaController
    {
        private static FormEntradasListaController instance;

        private FormEntradasListaController()
        { 
        }

        public static FormEntradasListaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormEntradasListaController();
            }

            return instance;
        }

        public void LoadForm(DataGridView dataGV_ListaEntradas)
        {
            var PropertyListener = EntradaPropertyListenerAdaptador.GetInstance().GetAll();
            var bl = new BindingList<EntradaItemListener>(PropertyListener);
            var source = new BindingSource(bl, null);
            dataGV_ListaEntradas.DataSource = source;
        }

        public bool DeleteItem(DateTime Fecha)
        {
            var PropertyListener = EntradaPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var item in PropertyListener)
            {
                if (item.Fecha.Equals(Fecha))
                {
                    PropertyListener.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}
