namespace Trazabilidad.App.Sanidad.GUI
{
    partial class FormSanidadLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanidadLista));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutTopTittle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.LayoutTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.LayoutBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.LayoutMain.SuspendLayout();
            this.LayoutTopTittle.SuspendLayout();
            this.LayoutTopButtons.SuspendLayout();
            this.LayoutBottomButtons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            resources.ApplyResources(this.LayoutMain, "LayoutMain");
            this.LayoutMain.Controls.Add(this.LayoutTopTittle, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutTopButtons, 0, 1);
            this.LayoutMain.Controls.Add(this.LayoutBottomButtons, 0, 3);
            this.LayoutMain.Controls.Add(this.tabControl1, 0, 2);
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
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView3, "dataGridView3");
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView4, "dataGridView4");
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // FormSanidadLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutMain);
            this.Name = "FormSanidadLista";
            this.Activated += new System.EventHandler(this.FormListaSanidad_Load);
            this.Load += new System.EventHandler(this.FormListaSanidad_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutTopTittle.ResumeLayout(false);
            this.LayoutTopTittle.PerformLayout();
            this.LayoutTopButtons.ResumeLayout(false);
            this.LayoutBottomButtons.ResumeLayout(false);
            this.LayoutBottomButtons.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutTopButtons;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TableLayoutPanel LayoutBottomButtons;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TableLayoutPanel LayoutTopTittle;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}