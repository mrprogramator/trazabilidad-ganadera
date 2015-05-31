using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trazabilidad.App.Ganado.Aplicacion;
using Trazabilidad.App.Ganado.Servicios;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Categorias.GUI;

namespace Trazabilidad.App.Ganado.GUI
{
    public class FormEntradaController
    {
        private static FormEntradaController instance;

        private FormEntradaController()
        { 
        }
        public static FormEntradaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormEntradaController();
                var _PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var _PropertyListenerBovino = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                
                foreach (var bovino in _PropertyListenerBovino)
                {
                    _PropertyListenerCat.First(c => c.Nombre.Equals(bovino.Categoria.Nombre)).Existencia++; 
                } 

            }
            return instance;
        }

        public void LoadFormGanado(Object BovinoItemListener, ComboBox categoria, DateTimePicker fecha_entrada, RichTextBox obs, RadioButton nac, RadioButton compra, TextBox precio, ComboBox padre, ComboBox madre)
        {
            var selected = (BovinoItemListener as GanadoItemListener).Id;
            if (BovinoItemListener is NacidoItemListener)
            {
                var _PropertyListener = FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().GetAll();
                var bovino = _PropertyListener.Find(b => b.Id.Equals(selected));
                
                categoria.SelectedItem = bovino.Categoria;
                fecha_entrada.Value = bovino.Entrada;
                obs.Text = bovino.Observaciones;
                nac.Checked = true;
                padre.SelectedItem = bovino.Padre;
                madre.SelectedItem = bovino.Madre;
            }

            if (BovinoItemListener is CompradoItemListener)
            {
                var _PropertyListener2 = FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().GetAll();
                var bovino2 = _PropertyListener2.Find(b => b.Id.Equals(selected));

                categoria.SelectedItem = bovino2.Categoria;
                fecha_entrada.Value = bovino2.Entrada;
                obs.Text = bovino2.Observaciones;
                compra.Checked = true;
                precio.Text = bovino2.Precio.ToString();
            }
        }

        public void LoadComboBoxGanado(ComboBox _ComboBox, Object TipoBovino)
        {
            _ComboBox.Items.Clear();

            if (TipoBovino is NacidoItemListener)
            {
                var _PropertyListener = FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().GetAll();
                foreach (var bovino in _PropertyListener)
                {
                    _ComboBox.Items.Add(bovino.Id);
                }
            }

            if (TipoBovino is CompradoItemListener )
            {
                var _PropertyListener2 = FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().GetAll();
                foreach (var bovino in _PropertyListener2)
                {
                    _ComboBox.Items.Add(bovino.Id);
                }
            }

            if (TipoBovino is MuertoItemListener)
            {
                var _PropertyListener = FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().GetAll();
                foreach (var bovino in _PropertyListener)
                {
                    _ComboBox.Items.Add(bovino.Id);
                }
            }

            if (TipoBovino is VendidoItemListener)
            {
                var _PropertyListener = FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().GetAll();
                foreach (var bovino in _PropertyListener)
                {
                    _ComboBox.Items.Add(bovino.Id);
                }
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

        public bool AddItem(ComboBox categoria, DateTimePicker dateTP_Fecha, RichTextBox obs, TextBox precio, TableLayoutPanel LayoutTipoEntrada, ComboBox padre, ComboBox madre)
        {
            var selected = LayoutTipoEntrada.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            var PropertyListener = FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().GetAll();
            var PropertyListener2 = FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().GetAll();

            var PropertyListenerGanado = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();

            var max = PropertyListenerGanado.Count;

            if (selected.Text.Equals("Nacimiento"))
            {            
                var newId = max + 1;
                var item = new NacidoItemListener()
                {
                    Id = newId,
                    Categoria = categoria.SelectedItem.ToString()
                };

                var padre_id = padre.SelectedItem;

                if (padre_id != null)
                {
                    item.Padre = (Int32)padre_id;
                }

                var madre_id = madre.SelectedItem;

                if (madre_id != null)
                {
                    item.Madre = (Int32)madre_id;
                }

                item.Entrada = dateTP_Fecha.Value;

                if (obs != null)
                {
                    item.Observaciones = obs.Text;
                }

                var PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = PropertyListenerCat.Find(c => c.Nombre.Equals(item.Categoria));
                item.Sexo = cat.Sexo;

                PropertyListener.Add(item);
                PropertyListenerGanado.Add(item);
            }

            else 
            {                
                var newId = max + 1;
                var item = new CompradoItemListener()
                {
                    Id = newId,
                    Categoria = categoria.SelectedItem.ToString()
                };

                var padre_id = padre.SelectedItem;


                item.Entrada = dateTP_Fecha.Value;

                item.Precio = Convert.ToDecimal(precio.Text);

                if (obs != null)
                {
                    item.Observaciones = obs.Text;
                }

                var PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = PropertyListenerCat.Find(c => c.Nombre.Equals(item.Categoria));
                item.Sexo = cat.Sexo;

                PropertyListener2.Add(item);
                PropertyListenerGanado.Add(item);
            }

            return true;
        }

        public bool EditItem(Object BovinoItemListener,ComboBox categoria, DateTimePicker dateTP_Fecha, RichTextBox obs, TextBox precio, TableLayoutPanel LayoutTipoEntrada, ComboBox padre, ComboBox madre)
        {
            var selected = LayoutTipoEntrada.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
            var sel_id = (BovinoItemListener as GanadoItemListener).Id;

            var PropertyListenerGanado = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();

            if (BovinoItemListener is NacidoItemListener)
            {
                var lista_bovinos = FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().GetAll();
                lista_bovinos.Remove(BovinoItemListener as NacidoItemListener);
            }

            if (BovinoItemListener is CompradoItemListener)
            {
                var lista_bovinos = FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().GetAll();
                lista_bovinos.Remove(BovinoItemListener as CompradoItemListener);
            }

            PropertyListenerGanado.Remove(BovinoItemListener as GanadoItemListener);


            if (selected.Text.Equals("Nacimiento"))
            {
                var PropertyListener = FactoriaAplicaciones<NacidoItemListener>.GetInstance().GetAplicacion().GetAll();

                var item = new NacidoItemListener();

                item.Id = sel_id;

                item.Categoria = categoria.SelectedItem.ToString();

                var padre_id = padre.SelectedItem;

                if (padre_id != null)
                {
                    item.Padre = (Int32)padre_id;
                }

                var madre_id = madre.SelectedItem;

                if (madre_id != null)
                {
                    item.Madre = (Int32)madre_id;
                }

                item.Entrada = dateTP_Fecha.Value;

                if (obs != null)
                {
                    item.Observaciones = obs.Text;
                }

                var PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = PropertyListenerCat.Find(c => c.Nombre.Equals(item.Categoria));
                item.Sexo = cat.Sexo;

                PropertyListener.Add(item);

                PropertyListenerGanado.Add(item);
            }

            else
            {
                var PropertyListener = FactoriaAplicaciones<CompradoItemListener>.GetInstance().GetAplicacion().GetAll();
                var item = new CompradoItemListener();

                item.Id = sel_id;

                item.Categoria = categoria.SelectedItem.ToString();
                var padre_id = padre.SelectedItem;


                item.Entrada = dateTP_Fecha.Value;

                item.Precio = Convert.ToDecimal(precio.Text);

                if (obs != null)
                {
                    item.Observaciones = obs.Text;
                }

                var PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = PropertyListenerCat.Find(c => c.Nombre.Equals(item.Categoria));
                item.Sexo = cat.Sexo;
                PropertyListener.Add(item);
                PropertyListenerGanado.Add(item);
            }


            return true;
        }
        
        public void LoadFormCategoriaLista()
        {
            new FormCategoriaLista().ShowDialog();
        }
                
        public void LoadComboBoxPadre(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();

            var _PropertyListener = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {                
                if (bovino.Categoria.Equals("toro"))
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxPadre(ComboBox _ComboBox, Object tipoBovino)
        {
            _ComboBox.Items.Clear();

            var _PropertyListener = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                if (bovino.Categoria.Equals("toro") && bovino.Id != (tipoBovino as GanadoItemListener).Id)
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxMadre(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                if (bovino.Categoria.Equals("vaca"))
                    _ComboBox.Items.Add(bovino.Id);
            }
        }

        public void LoadComboBoxMadre(ComboBox _ComboBox, Object tipoBovino)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                if (bovino.Categoria.Equals("vaca") && bovino.Id != (tipoBovino as GanadoItemListener).Id)
                    _ComboBox.Items.Add(bovino.Id);
            }
        }
    }
}
