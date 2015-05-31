namespace Trazabilidad.App.Categorias.GUI
{
    partial class FormCategoriaLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaLista));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutTopTittle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.LayoutTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dataGV_Categoria = new System.Windows.Forms.DataGridView();
            this.LayoutBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.LayoutMain.SuspendLayout();
            this.LayoutTopTittle.SuspendLayout();
            this.LayoutTopButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Categoria)).BeginInit();
            this.LayoutBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            resources.ApplyResources(this.LayoutMain, "LayoutMain");
            this.LayoutMain.Controls.Add(this.LayoutTopTittle, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutTopButtons, 0, 1);
            this.LayoutMain.Controls.Add(this.dataGV_Categoria, 0, 2);
            this.LayoutMain.Controls.Add(this.LayoutBottomButtons, 0, 3);
            this.LayoutMain.Name = "LayoutMain";
            // 
            // LayoutTopTittle
            // 
            resources.ApplyResources(this.LayoutTopTittle, "LayoutTopTittle");
            this.LayoutTopTittle.Controls.Add(this.lbl_Titulo, 0, 0);
            this.LayoutTopTittle.Name = "LayoutTopTittle";
            // 
            // lbl_Titulo
            // 
            resources.ApplyResources(this.lbl_Titulo, "lbl_Titulo");
            this.lbl_Titulo.Name = "lbl_Titulo";
            // 
            // LayoutTopButtons
            // 
            resources.ApplyResources(this.LayoutTopButtons, "LayoutTopButtons");
            this.LayoutTopButtons.Controls.Add(this.btn_Actualizar, 1, 0);
            this.LayoutTopButtons.Controls.Add(this.btn_Nuevo, 0, 0);
            this.LayoutTopButtons.Name = "LayoutTopButtons";
            // 
            // btn_Actualizar
            // 
            resources.ApplyResources(this.btn_Actualizar, "btn_Actualizar");
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Nuevo
            // 
            resources.ApplyResources(this.btn_Nuevo, "btn_Nuevo");
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dataGV_Categoria
            // 
            this.dataGV_Categoria.AllowUserToAddRows = false;
            this.dataGV_Categoria.AllowUserToDeleteRows = false;
            this.dataGV_Categoria.AllowUserToResizeColumns = false;
            this.dataGV_Categoria.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGV_Categoria, "dataGV_Categoria");
            this.dataGV_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Categoria.MultiSelect = false;
            this.dataGV_Categoria.Name = "dataGV_Categoria";
            this.dataGV_Categoria.ReadOnly = true;
            this.dataGV_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // LayoutBottomButtons
            // 
            resources.ApplyResources(this.LayoutBottomButtons, "LayoutBottomButtons");
            this.LayoutBottomButtons.Controls.Add(this.btn_Guardar, 0, 0);
            this.LayoutBottomButtons.Controls.Add(this.btn_Eliminar, 2, 0);
            this.LayoutBottomButtons.Controls.Add(this.btn_Editar, 1, 0);
            this.LayoutBottomButtons.Name = "LayoutBottomButtons";
            // 
            // btn_Guardar
            // 
            resources.ApplyResources(this.btn_Guardar, "btn_Guardar");
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            resources.ApplyResources(this.btn_Eliminar, "btn_Eliminar");
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            resources.ApplyResources(this.btn_Editar, "btn_Editar");
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // FormCategoriaLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutMain);
            this.Name = "FormCategoriaLista";
            this.Activated += new System.EventHandler(this.FormListaCategoria_Load);
            this.Load += new System.EventHandler(this.FormListaCategoria_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutTopTittle.ResumeLayout(false);
            this.LayoutTopTittle.PerformLayout();
            this.LayoutTopButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Categoria)).EndInit();
            this.LayoutBottomButtons.ResumeLayout(false);
            this.LayoutBottomButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.DataGridView dataGV_Categoria;
        private System.Windows.Forms.TableLayoutPanel LayoutTopButtons;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TableLayoutPanel LayoutBottomButtons;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TableLayoutPanel LayoutTopTittle;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}