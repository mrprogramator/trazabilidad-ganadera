using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Aplicacion;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace Trazabilidad.App.Categorias.GUI
{
    public class FormCategoriaListaController
    {
        private static FormCategoriaListaController instance;

        private FormCategoriaListaController()
        { 
        }

        public static FormCategoriaListaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormCategoriaListaController();
            }

            return instance;
        }

        public void LoadForm(DataGridView dataGV_ListaCategoria)
        {
            var PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            var bl = new BindingList<CategoriaItemListener>(PropertyListener);
            var source = new BindingSource(bl, null);
            dataGV_ListaCategoria.DataSource = source;

            dataGV_ListaCategoria.Columns[0].Visible = false;
           
            dataGV_ListaCategoria.Columns[4].Visible = false;
            
        }

        public bool DeleteItem(String NombreCat)
        {
            var Selected = NombreCat;
            var PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();

            if (PropertyListener.Exists(x => x.Nombre.Equals(Selected)))
            {
                var item = PropertyListener.Find(x => x.Nombre.Equals(Selected));

                if (item.Existencia == 0)
                {
                    PropertyListener.Remove(item);
                    return true;
                }            
            }
            return false;
        }
    }
}
