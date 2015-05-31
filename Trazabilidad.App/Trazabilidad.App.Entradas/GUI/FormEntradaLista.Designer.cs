namespace Trazabilidad.App.Entradas.GUI
{
    partial class FormEntradasLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradasLista));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutTopTittle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.LayoutTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.dataGV_Entrada = new System.Windows.Forms.DataGridView();
            this.LayoutBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LayoutMain.SuspendLayout();
            this.LayoutTopTittle.SuspendLayout();
            this.LayoutTopButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Entrada)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            resources.ApplyResources(this.LayoutMain, "LayoutMain");
            this.LayoutMain.Controls.Add(this.LayoutTopTittle, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutTopButtons, 0, 1);
            this.LayoutMain.Controls.Add(this.dataGV_Entrada, 0, 2);
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
            this.LayoutTopButtons.Name = "LayoutTopButtons";
            // 
            // btn_Actualizar
            // 
            resources.ApplyResources(this.btn_Actualizar, "btn_Actualizar");
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // dataGV_Entrada
            // 
            this.dataGV_Entrada.AllowUserToAddRows = false;
            this.dataGV_Entrada.AllowUserToDeleteRows = false;
            this.dataGV_Entrada.AllowUserToResizeColumns = false;
            this.dataGV_Entrada.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGV_Entrada, "dataGV_Entrada");
            this.dataGV_Entrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Entrada.MultiSelect = false;
            this.dataGV_Entrada.Name = "dataGV_Entrada";
            this.dataGV_Entrada.ReadOnly = true;
            this.dataGV_Entrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // LayoutBottomButtons
            // 
            resources.ApplyResources(this.LayoutBottomButtons, "LayoutBottomButtons");
            this.LayoutBottomButtons.Name = "LayoutBottomButtons";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.entradaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacimientosToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            resources.ApplyResources(this.verToolStripMenuItem, "verToolStripMenuItem");
            // 
            // nacimientosToolStripMenuItem
            // 
            this.nacimientosToolStripMenuItem.Name = "nacimientosToolStripMenuItem";
            resources.ApplyResources(this.nacimientosToolStripMenuItem, "nacimientosToolStripMenuItem");
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            resources.ApplyResources(this.comprasToolStripMenuItem, "comprasToolStripMenuItem");
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            resources.ApplyResources(this.entradaToolStripMenuItem, "entradaToolStripMenuItem");
            // 
            // FormEntradasLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEntradasLista";
            this.Activated += new System.EventHandler(this.FormListaEntrada_Load);
            this.Load += new System.EventHandler(this.FormListaEntrada_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutTopTittle.ResumeLayout(false);
            this.LayoutTopTittle.PerformLayout();
            this.LayoutTopButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Entrada)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.DataGridView dataGV_Entrada;
        private System.Windows.Forms.TableLayoutPanel LayoutTopButtons;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TableLayoutPanel LayoutBottomButtons;
        private System.Windows.Forms.TableLayoutPanel LayoutTopTittle;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
    }
}