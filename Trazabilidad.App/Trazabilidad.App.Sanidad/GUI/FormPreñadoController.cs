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
    public class FormPreñadoController
    {
        private static FormPreñadoController instance;

        private FormPreñadoController()
        { 
            
        }
        public static FormPreñadoController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormPreñadoController();
            }
            return instance;
        }

        public void LoadFormSanidad(Object itemListener, TextBox sanidadId, DateTimePicker fecha, RichTextBox obs, ComboBox bovino)
        {

            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxMadre(bovino);

            if (itemListener is PreñadoItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = itemListener as PreñadoItemListener;

                sanidadId.Text = item.Id.ToString();
                fecha.Value = item.Fecha;
                obs.Text = item.Observaciones;

                bovino.SelectedItem = item.Bovino;
            }
        }

        public void Update(Object itemListener, TextBox sanidadId, DateTimePicker fecha, RichTextBox obs, ComboBox bovino)
        {
            var lista = FactoriaAplicaciones<PreñadoItemListener>.GetInstance().GetAplicacion().GetAll();

            if (itemListener is PreñadoItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = lista.FirstOrDefault(x => x.Id.Equals(selected));

                item.Fecha = fecha.Value;
                item.Observaciones = obs.Text;
                item.Bovino = (Int32)bovino.SelectedItem;
            }
            else
            {
                var item = new PreñadoItemListener();
                item.Id = lista.Count + 1;
                item.Fecha = fecha.Value;
                item.Observaciones = obs.Text;
                item.Bovino = (Int32)bovino.SelectedItem;
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
