using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Categorias.Aplicacion;

namespace Trazabilidad.App.Categorias.GUI
{
    public class FormCategoriaController
    {
        private static FormCategoriaController instance;

        private FormCategoriaController()
        { 
        }
        public static FormCategoriaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormCategoriaController();
            }
            return instance;
        }

        public void LoadForm(ComboBox comboBx_Nombre, RichTextBox textBx_Descripcion,TableLayoutPanel LayoutSex)
        {
            var Selected = comboBx_Nombre.SelectedItem.ToString();
            var _PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            var cat = _PropertyListener.Find(x => x.Nombre.Equals(Selected));
            
            if (cat.Descripcion != null)
            {
                textBx_Descripcion.Text = cat.Descripcion;
            }

            if (cat.Sexo != null)
            {
                var radSex = LayoutSex.Controls
                    .OfType<RadioButton>()
                    .Where(r => r.Text.Contains(cat.Sexo))
                    .FirstOrDefault();

                radSex.Checked = true;
            }
                
        }

        public void LoadComboBoxCategoria(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var cat in _PropertyListener)
            {
                _ComboBox.Items.Add(cat.Nombre);
            }           
        }

        public void LoadComboBoxCategoria(ComboBox _ComboBox, CategoriaItemListener CIL)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var cat in _PropertyListener)
            {
                if (cat.Sexo.Equals(CIL.Sexo))
                    _ComboBox.Items.Add(cat.Nombre);
            }
        }

        public bool EditItem(ComboBox comboBx_Nombre, RichTextBox textBx_Descripcion, TableLayoutPanel LayoutSex)
        {
            var Selected = comboBx_Nombre.SelectedItem.ToString();
            var PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            
            var radSex = LayoutSex.Controls
                    .OfType<RadioButton>()
                    .Where(r => r.Checked)
                    .FirstOrDefault();

            if (PropertyListener.Exists(x => x.Nombre.Equals(Selected)))
            {
                var item = new CategoriaItemListener()
                {
                    Nombre = Selected,                    
                    Sexo = radSex.Text.ToString()
                };

                if (textBx_Descripcion.Text != null)
                {
                    item.Descripcion = textBx_Descripcion.Text; 
                }

                var itemToDelete = PropertyListener.Find(x => x.Nombre.Equals(Selected));
                item.Id = itemToDelete.Id;
                PropertyListener.Remove(itemToDelete);
                PropertyListener.Add(item);
                return true;
            }
            return false;
        }

        public bool AddItem(ComboBox comboBx_Nombre, RichTextBox textBx_Descripcion, TableLayoutPanel LayoutSex)
        {
            var Selected = comboBx_Nombre.Text;            
            
            if (Selected == null)
                return false;

            var PropertyListener = CategoriaPropertyListenerAdaptador.GetInstance().GetAll();

            if (PropertyListener.Exists(x => x.Nombre.Equals(Selected)))
            {
                MessageBox.Show("La categoría " + Selected + " ya existe. Intente otro nombre.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var maxIndex = PropertyListener.FindLast(x => x.Nombre.Equals(x.Nombre));
            var newId = maxIndex.Id + 1;

            var radSex = LayoutSex.Controls
                    .OfType<RadioButton>()
                    .Where(r => r.Checked)
                    .FirstOrDefault();
            var item = new CategoriaItemListener()
            {
                Id = newId,
                Nombre = Selected,
                Sexo = radSex.Text.ToString()
            };

            if (textBx_Descripcion.Text != null)
            {
                item.Descripcion = textBx_Descripcion.Text;
            }

            PropertyListener.Add(item);

            return true;
        }
    }
}
