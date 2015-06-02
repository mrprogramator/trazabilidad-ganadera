namespace Trazabilidad.App.Sanidad.GUI
{
    partial class FormVacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVacuna));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.dateTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDosis = new System.Windows.Forms.Label();
            this.textBoxDosis = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSanidadId = new System.Windows.Forms.Label();
            this.textBoxSanidadId = new System.Windows.Forms.TextBox();
            this.groupBoxBovino = new System.Windows.Forms.GroupBox();
            this.LayoutBovino = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBovino = new System.Windows.Forms.ComboBox();
            this.labelBovino = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxEntrada.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBoxBovino.SuspendLayout();
            this.LayoutBovino.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEntrada, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxBovino, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.7561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.2439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEntrada.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxEntrada.Location = new System.Drawing.Point(3, 36);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(521, 129);
            this.groupBoxEntrada.TabIndex = 1;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Sanidad";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTPEntrada, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelDosis, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDosis, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(3, 26);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // dateTPEntrada
            // 
            this.dateTPEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTPEntrada.Location = new System.Drawing.Point(53, 3);
            this.dateTPEntrada.Name = "dateTPEntrada";
            this.dateTPEntrada.Size = new System.Drawing.Size(215, 20);
            this.dateTPEntrada.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(53, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // labelDosis
            // 
            this.labelDosis.AutoSize = true;
            this.labelDosis.Location = new System.Drawing.Point(3, 49);
            this.labelDosis.Name = "labelDosis";
            this.labelDosis.Size = new System.Drawing.Size(33, 13);
            this.labelDosis.TabIndex = 6;
            this.labelDosis.Text = "Dosis";
            // 
            // textBoxDosis
            // 
            this.textBoxDosis.Location = new System.Drawing.Point(53, 52);
            this.textBoxDosis.Name = "textBoxDosis";
            this.textBoxDosis.Size = new System.Drawing.Size(100, 20);
            this.textBoxDosis.TabIndex = 8;
            this.textBoxDosis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBxPrecio_KeyPress);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(521, 35);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(443, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(362, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.labelSanidadId, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxSanidadId, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(521, 27);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // labelSanidadId
            // 
            this.labelSanidadId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSanidadId.Location = new System.Drawing.Point(3, 0);
            this.labelSanidadId.Name = "labelSanidadId";
            this.labelSanidadId.Size = new System.Drawing.Size(91, 23);
            this.labelSanidadId.TabIndex = 0;
            this.labelSanidadId.Text = "Sanidad Id";
            this.labelSanidadId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSanidadId
            // 
            this.textBoxSanidadId.Location = new System.Drawing.Point(100, 3);
            this.textBoxSanidadId.Name = "textBoxSanidadId";
            this.textBoxSanidadId.ReadOnly = true;
            this.textBoxSanidadId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSanidadId.TabIndex = 1;
            // 
            // groupBoxBovino
            // 
            this.groupBoxBovino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBovino.Controls.Add(this.LayoutBovino);
            this.groupBoxBovino.Location = new System.Drawing.Point(3, 196);
            this.groupBoxBovino.Name = "groupBoxBovino";
            this.groupBoxBovino.Size = new System.Drawing.Size(521, 81);
            this.groupBoxBovino.TabIndex = 6;
            this.groupBoxBovino.TabStop = false;
            this.groupBoxBovino.Text = "Bovino";
            // 
            // LayoutBovino
            // 
            this.LayoutBovino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutBovino.ColumnCount = 2;
            this.LayoutBovino.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.96875F));
            this.LayoutBovino.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.03125F));
            this.LayoutBovino.Controls.Add(this.comboBoxBovino, 1, 0);
            this.LayoutBovino.Controls.Add(this.labelBovino, 0, 0);
            this.LayoutBovino.Location = new System.Drawing.Point(3, 19);
            this.LayoutBovino.Name = "LayoutBovino";
            this.LayoutBovino.RowCount = 1;
            this.LayoutBovino.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.LayoutBovino.Size = new System.Drawing.Size(512, 35);
            this.LayoutBovino.TabIndex = 0;
            // 
            // comboBoxBovino
            // 
            this.comboBoxBovino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBovino.FormattingEnabled = true;
            this.comboBoxBovino.Location = new System.Drawing.Point(95, 3);
            this.comboBoxBovino.Name = "comboBoxBovino";
            this.comboBoxBovino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBovino.Sorted = true;
            this.comboBoxBovino.TabIndex = 2;
            // 
            // labelBovino
            // 
            this.labelBovino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBovino.AutoSize = true;
            this.labelBovino.Location = new System.Drawing.Point(3, 11);
            this.labelBovino.Name = "labelBovino";
            this.labelBovino.Size = new System.Drawing.Size(86, 13);
            this.labelBovino.TabIndex = 0;
            this.labelBovino.Text = "Bovino";
            // 
            // FormVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacuna";
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxEntrada.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBoxBovino.ResumeLayout(false);
            this.LayoutBovino.ResumeLayout(false);
            this.LayoutBovino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.DateTimePicker dateTPEntrada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelSanidadId;
        private System.Windows.Forms.TextBox textBoxSanidadId;
        private System.Windows.Forms.GroupBox groupBoxBovino;
        private System.Windows.Forms.TableLayoutPanel LayoutBovino;
        private System.Windows.Forms.ComboBox comboBoxBovino;
        private System.Windows.Forms.Label labelBovino;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDosis;
        private System.Windows.Forms.TextBox textBoxDosis;
    }
}