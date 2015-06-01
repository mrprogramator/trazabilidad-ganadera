using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Sanidad.Aplicacion;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;
using Trazabilidad.App.Ganado.GUI;

namespace Trazabilidad.App.Sanidad.GUI
{
    public class FormInseminacionController
    {
        private static FormInseminacionController instance;

        private FormInseminacionController()
        { 
        }
        public static FormInseminacionController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormInseminacionController();
            }
            return instance;
        }

        public void LoadFormSanidad(Object itemListener, TextBox sanidadId, DateTimePicker fecha, RichTextBox obs, ComboBox bovino, ComboBox padre)
        {

            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxMadre(bovino);
            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxPadre(padre);

            if (itemListener is InseminacionItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = itemListener as InseminacionItemListener;

                sanidadId.Text = item.Id.ToString();
                fecha.Value = item.Fecha;
                obs.Text = item.Observaciones;
                
                bovino.SelectedItem = item.Madre;
                padre.SelectedItem = item.Padre;
            }
        }

        public void Update(Object itemListener, TextBox sanidadId, DateTimePicker fecha, RichTextBox obs, ComboBox bovino, ComboBox padre)
        {
            var lista = FactoriaAplicaciones<InseminacionItemListener>.GetInstance().GetAplicacion().GetAll();

            if (itemListener is InseminacionItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = lista.FirstOrDefault(x => x.Id.Equals(selected));

                item.Fecha = fecha.Value;
                item.Observaciones = obs.Text;
                item.Madre = (Int32)bovino.SelectedItem;
                item.Padre = (Int32)padre.SelectedItem;
            }
            else
            {
                var item = new InseminacionItemListener();
                item.Id = lista.Count + 1;
                item.Fecha = fecha.Value;
                item.Observaciones = obs.Text;
                item.Madre = (Int32)bovino.SelectedItem;
                item.Padre = (Int32)padre.SelectedItem;
                lista.Add(item);
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

            var _PropertyListener = FactoriaAplicaciones<SanidadItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {                
                _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxPadre(ComboBox _ComboBox, Object tipoBovino)
        {
            _ComboBox.Items.Clear();

            var _PropertyListener = FactoriaAplicaciones<SanidadItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
               // if (bovino.Categoria.Equals("toro") && bovino.Id != (tipoBovino as SanidadItemListener).Id)
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxMadre(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = FactoriaAplicaciones<SanidadItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                //if (bovino.Categoria.Equals("vaca"))
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxMadre(ComboBox _ComboBox, Object tipoBovino)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = FactoriaAplicaciones<SanidadItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                //if (bovino.Categoria.Equals("vaca") && bovino.Id != (tipoBovino as SanidadItemListener).Id)
                    _ComboBox.Items.Add(bovino.Id);
            }
        }
    }
}
