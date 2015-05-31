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
    public class FormSalidaController
    {
        private static FormSalidaController instance;

        private FormSalidaController()
        { 
        }
        public static FormSalidaController GetInstance()
        {
            if (instance == null)
            {
                instance = new FormSalidaController();
            }
            return instance;
        }

        public bool Register(Object BovinoItemListener, DateTimePicker fecha_salida, RichTextBox obs, TableLayoutPanel layoutTipo, TextBox precio, TextBox destino)
        {
            var tipo = layoutTipo.Controls.OfType<RadioButton>().First(r => r.Checked);
            
            var bov = (BovinoItemListener as GanadoItemListener);

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

            if (BovinoItemListener is MuertoItemListener)
            {
                var lista_bovinos = FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().GetAll();
                lista_bovinos.Remove(BovinoItemListener as MuertoItemListener);
            }

            if (BovinoItemListener is VendidoItemListener)
            {
                var lista_bovinos = FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().GetAll();
                lista_bovinos.Remove(BovinoItemListener as VendidoItemListener);
            }

            if (tipo.Text.Equals("Muerte"))
            {
                var lista_muertos = FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().GetAll();

                var muerto = new MuertoItemListener()
                {
                    Id = bov.Id,
                    Categoria = bov.Categoria,
                    Sexo = bov.Sexo
                };

                muerto.Salida = fecha_salida.Value;
                muerto.Causa = obs.Text;

                lista_muertos.Add(muerto);
            }
            else 
            {
                var lista_vendidos = FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().GetAll();

                var vendido = new VendidoItemListener()
                {
                    Id = bov.Id,
                    Categoria = bov.Categoria,
                    Sexo = bov.Sexo
                };

                vendido.Salida = fecha_salida.Value;
                    
                if (obs.Text != "")
                {
                    vendido.Observaciones = obs.Text;
                }

                vendido.Destino = destino.Text;
                vendido.Precio = Convert.ToDecimal(precio.Text);

                if (BovinoItemListener is VendidoItemListener)
                {
                    lista_vendidos.Remove(BovinoItemListener as VendidoItemListener);
                }

                lista_vendidos.Add(vendido);
            }
          
            return true; 
        }

        public void LoadFormSalida(Object BovinoItemListener, DateTimePicker fecha_salida, RichTextBox obs, RadioButton muerte, RadioButton venta, TextBox precio, TextBox destino )
        {
            if (BovinoItemListener is MuertoItemListener)
            {
                var _PropertyListener = FactoriaAplicaciones<MuertoItemListener>.GetInstance().GetAplicacion().GetAll();
                
                fecha_salida.Value = (BovinoItemListener as MuertoItemListener).Salida;
                obs.Text = (BovinoItemListener as MuertoItemListener).Causa;
                muerte.Checked = true;
            }

            if (BovinoItemListener is VendidoItemListener)
            {
                var _PropertyListener2 = FactoriaAplicaciones<VendidoItemListener>.GetInstance().GetAplicacion().GetAll();

                fecha_salida.Value = (BovinoItemListener as VendidoItemListener).Salida;
                obs.Text = (BovinoItemListener as VendidoItemListener).Observaciones;
                venta.Checked = true;
                destino.Text = (BovinoItemListener as VendidoItemListener).Destino;
                precio.Text = (BovinoItemListener as VendidoItemListener).Precio.ToString();
            }
        }

        public void LoadComboBoxGanado<T>(ComboBox _ComboBox)
        {
            _ComboBox.Items.Clear();
            var _PropertyListener = FactoriaAplicaciones<T>.GetInstance().GetAplicacion().GetAll();
            foreach (var bovino in _PropertyListener)
            {
                _ComboBox.Items.Add((bovino as GanadoItemListener).Id);
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

        public bool AddItem(ComboBox comboBoxSelected, ComboBox categoria, DateTimePicker dateTP_Fecha, RichTextBox obs, TextBox precio, TableLayoutPanel LayoutTipoEntrada, ComboBox padre, ComboBox madre)
        {
            var selected = LayoutTipoEntrada.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
                         
            if (selected.Text.Equals("Muerte"))
            {            
                var newId = comboBoxSelected.SelectedItem;
                var item = new MuertoItemListener()
                {
                    Id = (Int32)newId,
                    Categoria = categoria.SelectedItem.ToString()
                };

                

                var PropertyListenerCat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = PropertyListenerCat.Find(c => c.Nombre.Equals(item.Categoria));
                item.Sexo = cat.Sexo;

                //PropertyListener.Add(item);

            }

            else 
            {                
                var newId = 1;
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

                //PropertyListener2.Add(item);
            }

            return true;
        }

        public bool EditItem(ComboBox bovinoId,TextBox destino, DateTimePicker dateTP_Fecha, RichTextBox obs, TextBox precio, TableLayoutPanel LayoutTipoSalida)
        {
            var selected = LayoutTipoSalida.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (selected.Text.Equals("Muerte"))
            {
                var PropertyListener = FactoriaAplicaciones<MuertoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll();
                var sel_id = (Int32)bovinoId.SelectedItem;

                var itemToDelete = PropertyListener.Find(x => x.Id.Equals(sel_id));
                var item = itemToDelete;
                if (PropertyListener.Exists(x => x.Id.Equals(sel_id)))
                {
                    item.Salida = dateTP_Fecha.Value;
                    item.Causa = obs.Text;
                    
                    PropertyListener.Remove(itemToDelete);
                    PropertyListener.Add(item);
                }                
            }

            else
            {
                var PropertyListener = FactoriaAplicaciones<VendidoItemListener>
                                        .GetInstance().GetAplicacion()
                                        .GetAll();
                
                var sel_id = bovinoId.SelectedItem;

                var itemToDelete = PropertyListener.Find(x => x.Id.Equals(sel_id));
                var item = itemToDelete;
                if (PropertyListener.Exists(x => x.Id.Equals(sel_id)))
                {
                    item.Salida = dateTP_Fecha.Value;

                    item.Precio = Convert.ToDecimal(precio.Text);

                    if (obs != null)
                    {
                        item.Observaciones = obs.Text;
                    }

                    if (destino != null)
                    {
                        item.Observaciones = destino.Text;
                    }

                    PropertyListener.Remove(itemToDelete);
                    PropertyListener.Add(item);
                }              
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
                    if (bovino.Categoria.Equals("toro") )
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
    }
}
