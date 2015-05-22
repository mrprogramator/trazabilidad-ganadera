using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Aplicacion;
using System.Windows.Forms;

namespace Trazabilidad.App.Ganado.GUI
{
    public class FormMainController
    {
        private static FormMainController instance;

        private FormMainController()
        { 
        }
        public static FormMainController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormMainController();
            }
            return instance;
        }

        public void cargarForm(String Id, TextBox madre, TextBox padre, Label entrada,DateTimePicker entrada_fecha, Label salida, DateTimePicker salida_fecha, TextBox categoria, RadioButton hembra, RadioButton macho, CheckBox estado)
        {
            var pl_ganado = PropertyListenerAdaptador.GetInstance().GetAllGanado();
            var bovino = pl_ganado.Find(x => x[0].Equals(Id));

            if (bovino[1].Equals("H"))
            {
                hembra.Checked = true;
                macho.Checked = false;
            }
            else 
            {
                hembra.Checked = false;
                macho.Checked = true;
            }
            
            if (bovino[2].Equals("True"))
            {
                estado.Checked = true;
            }
            else
            {
                estado.Checked = false;
            }

            //madre.Text = bovino[3];
            //padre.Text = bovino[4];

            categoria.Text = bovino[3];

            //entrada_fecha.Text = bovino[6];

            //entrada.Text = bovino[7];

            //salida_fecha.Text = bovino[6];

            //salida.Text = bovino[7];
        }

        public void cargarComboBox(ComboBox _comboBox)
        {
            var pl_ganado = PropertyListenerAdaptador.GetInstance().GetAllGanado();
            foreach (var bovino in pl_ganado)
            {
                _comboBox.Items.Add(bovino[0]);
            }
           
        }
    }
}
