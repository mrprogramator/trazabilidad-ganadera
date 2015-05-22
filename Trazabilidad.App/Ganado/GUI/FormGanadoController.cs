using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Aplicacion;
using System.Windows.Forms;

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

        public void LoadForm(String Id, TextBox madre, TextBox padre, Label entrada,
            DateTimePicker entrada_fecha, Label salida, DateTimePicker salida_fecha,
            TextBox categoria, RadioButton hembra, RadioButton macho, CheckBox estado)
        {
            var _PropertyListener = PropertyListenerAdaptador.GetInstance().GetAll();
            var bovino = _PropertyListener.Find(x => x.Id.Equals(Id));

            if (bovino.Sexo.Equals("H"))
            {
                hembra.Checked = true;
                macho.Checked = false;
                estado.Text = "Viva";
            }
            else 
            {
                hembra.Checked = false;
                macho.Checked = true;
                estado.Text = "Vivo";
            }

            estado.Checked = bovino.Estado;

            categoria.Text = bovino.Categoria;

            if (bovino.MadreId != null)
            {
                madre.Text = bovino.MadreId;
            }

            if (bovino.PadreId != null)
            {
                padre.Text = bovino.PadreId;
            }

            if (entrada_fecha.MinDate <= bovino.Entrada && bovino.Entrada <= entrada_fecha.MaxDate)
            {
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

        public void LoadComboBox(ComboBox _ComboBox)
        {
            var _PropertyListener = PropertyListenerAdaptador.GetInstance().GetAll();
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
    }
}
