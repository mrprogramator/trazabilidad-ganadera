using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Ganado.Aplicacion;
using Trazabilidad.App.Categorias.GUI;

namespace Trazabilidad.App.Ganado.GUI
{
    public class FormGanadoController
    {
        private static FormGanadoController instance;

        private FormGanadoController()
        { 
        }
        public static FormGanadoController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormGanadoController();
            }
            return instance;
        }

        public void LoadFormGanado(ComboBox comboBx_BovinoId, ComboBox madre, ComboBox padre, Label entrada,
            DateTimePicker entrada_fecha, Label salida, DateTimePicker salida_fecha,
            ComboBox categoria, RadioButton hembra, RadioButton macho, CheckBox estado)
        {
            var Id = (Int32)comboBx_BovinoId.SelectedItem;
            var _PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            var bovino = _PropertyListener.Find(x => x.Id.Equals(Id));

            if (bovino.Sexo.Equals("H"))
            {
                hembra.Checked = true;
                macho.Checked = false;
                estado.Text = "Activa";
                FormCategoriaController.GetInstance().LoadComboBoxCategoria(categoria);
                categoria.Items.Remove("toro");
                categoria.Items.Remove("novillo");
            }
            else 
            {
                macho.Checked = true;
                hembra.Checked = false;
                estado.Text = "Activo";
                FormCategoriaController.GetInstance().LoadComboBoxCategoria(categoria);
                categoria.Items.Remove("vaca");
                categoria.Items.Remove("vaquilla");
            }

            estado.Checked = bovino.Activo;

            categoria.SelectedItem = bovino.Categoria;

            LoadComboBoxMadre(madre);

            if (bovino.MadreId != null)
            {                
                madre.SelectedItem = bovino.MadreId;                
            }
            else
            {
                madre.SelectedItem = null;
            }

            madre.Items.Remove(bovino.Id);

            LoadComboBoxPadre(padre);

            if (bovino.PadreId != null)
            {                
                padre.SelectedItem = bovino.PadreId;                
            }
            else
            {
                padre.SelectedItem = null;
            }

            padre.Items.Remove(bovino.Id);

            if (entrada_fecha.MinDate <= bovino.Entrada && bovino.Entrada <= entrada_fecha.MaxDate)
            {
                SetDateTimePickerFormat(entrada_fecha);
                entrada_fecha.Value = bovino.Entrada;
            }
            else 
            {
                EmptyDateTimePickerFormat(entrada_fecha);
            }

            if (bovino.TipoEntrada != null)
            {
                entrada.Text = bovino.TipoEntrada;
            }

            if (salida_fecha.MinDate <=bovino.Salida && bovino.Salida <= salida_fecha.MaxDate)
            {
                SetDateTimePickerFormat(salida_fecha);                
                salida_fecha.Value = bovino.Salida;
            }
            else
            {
                EmptyDateTimePickerFormat(salida_fecha);
            }

            if (bovino.TipoSalida != null)
            {
                salida.Text = bovino.TipoSalida;
            }        
            
        }

        public void LoadComboBoxGanado(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                _ComboBox.Items.Add(bovino.Id);
            }           
        }              

        public void SetDateTimePickerFormat(DateTimePicker _DateTimePicker)
        {
            _DateTimePicker.CustomFormat = "MMM, yyyy";
            _DateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        public void EmptyDateTimePickerFormat(DateTimePicker _DateTimePicker)
        {
            _DateTimePicker.CustomFormat = " ";
            _DateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        public void LoadComboBoxPadre(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                if(bovino.Categoria.Equals("toro"))
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxMadre(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                if (bovino.Categoria.Equals("vaca"))
                    _ComboBox.Items.Add(bovino.Id);
            }
        }
        public bool EditItem(ComboBox comboBx_BovinoId, ComboBox madre, ComboBox padre, Label entrada,
            DateTimePicker entrada_fecha, Label salida, DateTimePicker salida_fecha,
            ComboBox categoria, RadioButton hembra, RadioButton macho, CheckBox estado)
        {
            var PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();
            
            var sel_id = (Int32)comboBx_BovinoId.SelectedItem;
            
            if (PropertyListener.Exists(x => x.Id.Equals(sel_id)))
            {
                var item = new GanadoItemListener()
                {
                    Id = (Int32)comboBx_BovinoId.SelectedItem,
                    Categoria = categoria.SelectedItem.ToString(),
                    Activo = estado.Checked,                    
                };

                if (madre.SelectedItem != null)
                {
                    item.MadreId = madre.SelectedItem.ToString(); 
                }

                if (padre.SelectedItem != null)
                {
                    item.PadreId = padre.SelectedItem.ToString();
                }

                if (entrada_fecha.Value != null)
                {
                    item.Entrada = entrada_fecha.Value;
                    item.TipoEntrada = entrada.Text;                    
                }

                if (salida_fecha.Value != null)
                {
                    item.Salida = salida_fecha.Value;
                    item.TipoSalida = salida.Text;
                }

                if (hembra.Checked)
                {
                    item.Sexo = "H";
                }
                else 
                {
                    item.Sexo = "M";
                }
                var itemToDelete = PropertyListener.Find(x => x.Id.Equals(sel_id));
                PropertyListener.Remove(itemToDelete);
                PropertyListener.Add(item);
                return true;
            }
            return false;
        }

        public bool AddItem(ComboBox madre, ComboBox padre, Label entrada,
            DateTimePicker entrada_fecha, Label salida, DateTimePicker salida_fecha,
            ComboBox categoria, RadioButton hembra, RadioButton macho, CheckBox estado)
        {
            var PropertyListener = GanadoPropertyListenerAdaptador.GetInstance().GetAll();

            var maxIndex = PropertyListener.FindLast(x => x.Id.Equals(x.Id));
            var newId = maxIndex.Id + 1;
            var item = new GanadoItemListener()
            {
                Id = newId,
                Categoria = categoria.SelectedItem.ToString(),
                Activo = estado.Checked,
            };

            if (madre.SelectedItem != null)
            {
                item.MadreId = madre.SelectedItem.ToString();
            }

            if (padre.SelectedItem != null)
            {
                item.PadreId = padre.SelectedItem.ToString();
            }

            if (entrada_fecha.Value != null && !entrada.Text.Equals("Entrada"))
            {
                item.Entrada = entrada_fecha.Value;
                item.TipoEntrada = entrada.Text;
            }

            if (salida_fecha.Value != null &&  !salida.Text.Equals("Salida"))
            {
                item.Salida = salida_fecha.Value;
                item.TipoSalida = salida.Text;
            }

            if (hembra.Checked)
            {
                item.Sexo = "H";
            }
            else
            {
                item.Sexo = "M";
            }
           
            PropertyListener.Add(item);
            return true;
        }

        public void LoadFormCategoria()
        {
            new FormCategoriaLista().Show();
        }
    }
}
