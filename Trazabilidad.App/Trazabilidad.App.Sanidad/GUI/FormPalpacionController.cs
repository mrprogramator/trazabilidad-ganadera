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
    public class FormPalpacionController
    {
        private static FormPalpacionController instance;

        private FormPalpacionController()
        { 
        }
        public static FormPalpacionController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormPalpacionController();
            }
            return instance;
        }

        public void LoadFormSanidad(Object itemListener, TextBox sanidadId, DateTimePicker fecha, TextBox numero, TextBox mes, CheckBox estado, ComboBox bovino)
        {

            Ganado.GUI.FormEntradaController.GetInstance().LoadComboBoxMadre(bovino);

            if (itemListener is PalpacionItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = itemListener as PalpacionItemListener;

                sanidadId.Text = item.Id.ToString();
                fecha.Value = item.Fecha;
                numero.Text = item.Numero.ToString();
                mes.Text = item.MesGestacion.ToString();
                estado.Checked = item.Preñada;
                
                bovino.SelectedItem = item.Bovino;
            }
        }

        public void Update(Object itemListener, TextBox sanidadId, DateTimePicker fecha, TextBox numero, TextBox mes, CheckBox estado, ComboBox bovino)
        {
            var lista = FactoriaAplicaciones<PalpacionItemListener>.GetInstance().GetAplicacion().GetAll();

            if (itemListener is PalpacionItemListener)
            {
                var selected = (itemListener as SanidadItemListener).Id;

                var item = lista.FirstOrDefault(x => x.Id.Equals(selected));

                item.Fecha = fecha.Value;
                item.Numero = Convert.ToInt32(numero.Text);
                item.MesGestacion = Convert.ToInt32(mes.Text);
                item.Preñada = estado.Checked;

                item.Bovino = (Int32)bovino.SelectedItem;
            }
            else
            {
                var item = new PalpacionItemListener();
                item.Id = lista.Count + 1;
                item.Fecha = fecha.Value;
                item.Numero = Convert.ToInt32(numero.Text);
                item.MesGestacion = Convert.ToInt32(mes.Text);
                item.Preñada = estado.Checked;

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
