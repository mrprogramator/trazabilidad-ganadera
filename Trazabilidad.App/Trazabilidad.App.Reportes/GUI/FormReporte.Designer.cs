namespace Trazabilidad.App.Reporte.GUI
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutTopTittle = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ganadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteoGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inseminaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palpaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preñadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteoPorCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LayoutMain.SuspendLayout();
            this.LayoutTopTittle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LayoutMain, "LayoutMain");
            this.LayoutMain.Controls.Add(this.LayoutTopTittle, 0, 0);
            this.LayoutMain.Controls.Add(this.webBrowser1, 0, 2);
            this.LayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.LayoutMain.Name = "LayoutMain";
            // 
            // LayoutTopTittle
            // 
            resources.ApplyResources(this.LayoutTopTittle, "LayoutTopTittle");
            this.LayoutTopTittle.Controls.Add(this.buttonSalir, 0, 0);
            this.LayoutTopTittle.Controls.Add(this.lbl_Titulo, 1, 0);
            this.LayoutTopTittle.Name = "LayoutTopTittle";
            // 
            // buttonSalir
            // 
            resources.ApplyResources(this.buttonSalir, "buttonSalir");
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // lbl_Titulo
            // 
            resources.ApplyResources(this.lbl_Titulo, "lbl_Titulo");
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Name = "lbl_Titulo";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ganadoToolStripMenuItem,
            this.sanidadToolStripMenuItem,
            this.categoríaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ganadoToolStripMenuItem
            // 
            this.ganadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteoGeneralToolStripMenuItem,
            this.trazabilidadToolStripMenuItem});
            this.ganadoToolStripMenuItem.Name = "ganadoToolStripMenuItem";
            resources.ApplyResources(this.ganadoToolStripMenuItem, "ganadoToolStripMenuItem");
            // 
            // conteoGeneralToolStripMenuItem
            // 
            this.conteoGeneralToolStripMenuItem.Name = "conteoGeneralToolStripMenuItem";
            resources.ApplyResources(this.conteoGeneralToolStripMenuItem, "conteoGeneralToolStripMenuItem");
            this.conteoGeneralToolStripMenuItem.Click += new System.EventHandler(this.conteoGeneralToolStripMenuItem_Click);
            // 
            // sanidadToolStripMenuItem
            // 
            this.sanidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inseminaciónToolStripMenuItem,
            this.palpaciónToolStripMenuItem,
            this.preñadoToolStripMenuItem,
            this.vacunasToolStripMenuItem});
            this.sanidadToolStripMenuItem.Name = "sanidadToolStripMenuItem";
            resources.ApplyResources(this.sanidadToolStripMenuItem, "sanidadToolStripMenuItem");
            // 
            // inseminaciónToolStripMenuItem
            // 
            this.inseminaciónToolStripMenuItem.Name = "inseminaciónToolStripMenuItem";
            resources.ApplyResources(this.inseminaciónToolStripMenuItem, "inseminaciónToolStripMenuItem");
            this.inseminaciónToolStripMenuItem.Click += new System.EventHandler(this.inseminaciónToolStripMenuItem_Click);
            // 
            // palpaciónToolStripMenuItem
            // 
            this.palpaciónToolStripMenuItem.Name = "palpaciónToolStripMenuItem";
            resources.ApplyResources(this.palpaciónToolStripMenuItem, "palpaciónToolStripMenuItem");
            this.palpaciónToolStripMenuItem.Click += new System.EventHandler(this.palpaciónToolStripMenuItem_Click);
            // 
            // preñadoToolStripMenuItem
            // 
            this.preñadoToolStripMenuItem.Name = "preñadoToolStripMenuItem";
            resources.ApplyResources(this.preñadoToolStripMenuItem, "preñadoToolStripMenuItem");
            this.preñadoToolStripMenuItem.Click += new System.EventHandler(this.preñadoToolStripMenuItem_Click);
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            resources.ApplyResources(this.vacunasToolStripMenuItem, "vacunasToolStripMenuItem");
            this.vacunasToolStripMenuItem.Click += new System.EventHandler(this.vacunasToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteoPorCategoríaToolStripMenuItem});
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            resources.ApplyResources(this.categoríaToolStripMenuItem, "categoríaToolStripMenuItem");
            // 
            // conteoPorCategoríaToolStripMenuItem
            // 
            this.conteoPorCategoríaToolStripMenuItem.Name = "conteoPorCategoríaToolStripMenuItem";
            resources.ApplyResources(this.conteoPorCategoríaToolStripMenuItem, "conteoPorCategoríaToolStripMenuItem");
            this.conteoPorCategoríaToolStripMenuItem.Click += new System.EventHandler(this.conteoPorCategoríaToolStripMenuItem_Click);
            // 
            // trazabilidadToolStripMenuItem
            // 
            this.trazabilidadToolStripMenuItem.Name = "trazabilidadToolStripMenuItem";
            resources.ApplyResources(this.trazabilidadToolStripMenuItem, "trazabilidadToolStripMenuItem");
            this.trazabilidadToolStripMenuItem.Click += new System.EventHandler(this.trazabilidadToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Sorted = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReporte
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayoutMain);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutTopTittle.ResumeLayout(false);
            this.LayoutTopTittle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutTopTittle;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ganadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteoGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inseminaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palpaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preñadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteoPorCategoríaToolStripMenuItem;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem trazabilidadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}