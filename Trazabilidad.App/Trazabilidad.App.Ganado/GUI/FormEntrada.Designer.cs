namespace Trazabilidad.App.Ganado.GUI
{
    partial class FormEntrada
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.LayoutTipo = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnNacimiento = new System.Windows.Forms.RadioButton();
            this.radioBtnCompra = new System.Windows.Forms.RadioButton();
            this.richTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.dateTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.buttonCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBovinoId = new System.Windows.Forms.Label();
            this.textBoxBovinoId = new System.Windows.Forms.TextBox();
            this.groupBoxDescendencia = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxMadre = new System.Windows.Forms.ComboBox();
            this.comboBoxPadre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxEntrada.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LayoutTipo.SuspendLayout();
            this.groupBoxCategoria.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBoxDescendencia.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEntrada, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCategoria, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDescendencia, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.92746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.057F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.01554F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 458);
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
            this.groupBoxEntrada.Size = new System.Drawing.Size(521, 172);
            this.groupBoxEntrada.TabIndex = 1;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Entrada";
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
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelPrecio, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LayoutTipo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxObservaciones, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTPEntrada, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPrecio, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 136);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de entrada";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observaciones";
            // 
            // labelPrecio
            // 
            this.labelPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(3, 116);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(82, 13);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // LayoutTipo
            // 
            this.LayoutTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutTipo.ColumnCount = 2;
            this.LayoutTipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTipo.Controls.Add(this.radioBtnNacimiento, 0, 0);
            this.LayoutTipo.Controls.Add(this.radioBtnCompra, 1, 0);
            this.LayoutTipo.Location = new System.Drawing.Point(91, 29);
            this.LayoutTipo.Name = "LayoutTipo";
            this.LayoutTipo.RowCount = 1;
            this.LayoutTipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTipo.Size = new System.Drawing.Size(409, 25);
            this.LayoutTipo.TabIndex = 5;
            // 
            // radioBtnNacimiento
            // 
            this.radioBtnNacimiento.AutoSize = true;
            this.radioBtnNacimiento.Location = new System.Drawing.Point(3, 3);
            this.radioBtnNacimiento.Name = "radioBtnNacimiento";
            this.radioBtnNacimiento.Size = new System.Drawing.Size(78, 17);
            this.radioBtnNacimiento.TabIndex = 0;
            this.radioBtnNacimiento.Text = "Nacimiento";
            this.radioBtnNacimiento.UseVisualStyleBackColor = true;
            this.radioBtnNacimiento.CheckedChanged += new System.EventHandler(this.radioBtnNacimiento_CheckedChanged);
            // 
            // radioBtnCompra
            // 
            this.radioBtnCompra.AutoSize = true;
            this.radioBtnCompra.Checked = true;
            this.radioBtnCompra.Location = new System.Drawing.Point(87, 3);
            this.radioBtnCompra.Name = "radioBtnCompra";
            this.radioBtnCompra.Size = new System.Drawing.Size(61, 17);
            this.radioBtnCompra.TabIndex = 1;
            this.radioBtnCompra.TabStop = true;
            this.radioBtnCompra.Text = "Compra";
            this.radioBtnCompra.UseVisualStyleBackColor = true;
            // 
            // richTextBoxObservaciones
            // 
            this.richTextBoxObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxObservaciones.Location = new System.Drawing.Point(91, 60);
            this.richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            this.richTextBoxObservaciones.Size = new System.Drawing.Size(409, 47);
            this.richTextBoxObservaciones.TabIndex = 6;
            this.richTextBoxObservaciones.Text = "";
            // 
            // dateTPEntrada
            // 
            this.dateTPEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTPEntrada.Location = new System.Drawing.Point(91, 3);
            this.dateTPEntrada.Name = "dateTPEntrada";
            this.dateTPEntrada.Size = new System.Drawing.Size(215, 20);
            this.dateTPEntrada.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(91, 113);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 7;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBxPrecio_KeyPress);
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCategoria.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxCategoria.Location = new System.Drawing.Point(3, 214);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(521, 80);
            this.groupBoxCategoria.TabIndex = 2;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoria";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxCategoria, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCategoria, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 30);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(91, 3);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(283, 21);
            this.comboBoxCategoria.TabIndex = 1;
            // 
            // buttonCategoria
            // 
            this.buttonCategoria.AutoSize = true;
            this.buttonCategoria.Location = new System.Drawing.Point(380, 3);
            this.buttonCategoria.Name = "buttonCategoria";
            this.buttonCategoria.Size = new System.Drawing.Size(97, 23);
            this.buttonCategoria.TabIndex = 2;
            this.buttonCategoria.Text = "Nueva Categoria";
            this.buttonCategoria.UseVisualStyleBackColor = true;
            this.buttonCategoria.Click += new System.EventHandler(this.buttonCategoria_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 408);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(521, 47);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(362, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.labelBovinoId, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxBovinoId, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(521, 27);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // labelBovinoId
            // 
            this.labelBovinoId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBovinoId.Location = new System.Drawing.Point(3, 0);
            this.labelBovinoId.Name = "labelBovinoId";
            this.labelBovinoId.Size = new System.Drawing.Size(91, 23);
            this.labelBovinoId.TabIndex = 0;
            this.labelBovinoId.Text = "Bovino Id";
            this.labelBovinoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBovinoId
            // 
            this.textBoxBovinoId.Location = new System.Drawing.Point(100, 3);
            this.textBoxBovinoId.Name = "textBoxBovinoId";
            this.textBoxBovinoId.ReadOnly = true;
            this.textBoxBovinoId.Size = new System.Drawing.Size(100, 20);
            this.textBoxBovinoId.TabIndex = 1;
            // 
            // groupBoxDescendencia
            // 
            this.groupBoxDescendencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescendencia.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxDescendencia.Location = new System.Drawing.Point(3, 301);
            this.groupBoxDescendencia.Name = "groupBoxDescendencia";
            this.groupBoxDescendencia.Size = new System.Drawing.Size(521, 100);
            this.groupBoxDescendencia.TabIndex = 6;
            this.groupBoxDescendencia.TabStop = false;
            this.groupBoxDescendencia.Text = "Descendencia";
            this.groupBoxDescendencia.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.96875F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.03125F));
            this.tableLayoutPanel4.Controls.Add(this.comboBoxMadre, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxPadre, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(512, 56);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // comboBoxMadre
            // 
            this.comboBoxMadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMadre.FormattingEnabled = true;
            this.comboBoxMadre.Location = new System.Drawing.Point(95, 28);
            this.comboBoxMadre.Name = "comboBoxMadre";
            this.comboBoxMadre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMadre.TabIndex = 2;
            // 
            // comboBoxPadre
            // 
            this.comboBoxPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPadre.FormattingEnabled = true;
            this.comboBoxPadre.Location = new System.Drawing.Point(95, 3);
            this.comboBoxPadre.Name = "comboBoxPadre";
            this.comboBoxPadre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPadre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Padre";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Madre";
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(543, 496);
            this.Name = "FormEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Activated += new System.EventHandler(this.FormEntrada_Activated);
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxEntrada.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LayoutTipo.ResumeLayout(false);
            this.LayoutTipo.PerformLayout();
            this.groupBoxCategoria.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBoxDescendencia.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.DateTimePicker dateTPEntrada;
        private System.Windows.Forms.TableLayoutPanel LayoutTipo;
        private System.Windows.Forms.RadioButton radioBtnNacimiento;
        private System.Windows.Forms.RadioButton radioBtnCompra;
        private System.Windows.Forms.RichTextBox richTextBoxObservaciones;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button buttonCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelBovinoId;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBoxDescendencia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxMadre;
        private System.Windows.Forms.ComboBox comboBoxPadre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBovinoId;
    }
}