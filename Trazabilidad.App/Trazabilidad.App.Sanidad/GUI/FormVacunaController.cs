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
    public class FormVacunaController
    {
        private static FormVacunaController instance;

        private FormVacunaController()
        { 
        }
        public static FormVacunaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormVacunaController();
            }
            return instance;
        }

        public void LoadFormSanidad(Object itemListener, TextBox sanidadId, DateTimePicker fecha, TextBox nombre, TextBox dosis, ComboBox bovino)
        {

            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxGanado(bovino,null);

            if (itemListener is VacunaItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = itemListener as VacunaItemListener;

                sanidadId.Text = item.Id.ToString();
                fecha.Value = item.Fecha;
                nombre.Text = item.Nombre;
                dosis.Text = item.Dosis.ToString();
                
                bovino.SelectedItem = item.Bovino;
            }
        }

        public void Update(Object itemListener, TextBox sanidadId, DateTimePicker fecha, TextBox nombre, TextBox dosis, ComboBox bovino)
        {
            var lista = FactoriaAplicaciones<VacunaItemListener>.GetInstance().GetAplicacion().GetAll();

            if (itemListener is VacunaItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = lista.FirstOrDefault(x => x.Id.Equals(selected));

                item.Fecha = fecha.Value;
                item.Nombre = nombre.Text;
                item.Dosis = Convert.ToDecimal(dosis.Text);

                item.Bovino = (Int32)bovino.SelectedItem;
            }
            else
            {
                var item = new VacunaItemListener();
                item.Id = lista.Count + 1;
                item.Fecha = fecha.Value;
                item.Nombre = nombre.Text;
                item.Dosis = Convert.ToDecimal(dosis.Text);

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
