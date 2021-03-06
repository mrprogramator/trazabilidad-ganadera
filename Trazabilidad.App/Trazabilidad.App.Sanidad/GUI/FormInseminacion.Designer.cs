﻿namespace Trazabilidad.App.Sanidad.GUI
{
    partial class FormInseminacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInseminacion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.richTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.dateTPEntrada = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSanidadId = new System.Windows.Forms.Label();
            this.textBoxSanidadId = new System.Windows.Forms.TextBox();
            this.groupBoxBovino = new System.Windows.Forms.GroupBox();
            this.LayoutBovino = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPadre = new System.Windows.Forms.ComboBox();
            this.comboBoxBovino = new System.Windows.Forms.ComboBox();
            this.labelBovino = new System.Windows.Forms.Label();
            this.labelPadre = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 352);
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
            this.groupBoxEntrada.Size = new System.Drawing.Size(521, 134);
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
            this.tableLayoutPanel2.Controls.Add(this.labelObservaciones, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxObservaciones, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTPEntrada, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 109);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(3, 26);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(78, 13);
            this.labelObservaciones.TabIndex = 2;
            this.labelObservaciones.Text = "Observaciones";
            // 
            // richTextBoxObservaciones
            // 
            this.richTextBoxObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxObservaciones.Location = new System.Drawing.Point(87, 29);
            this.richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            this.richTextBoxObservaciones.Size = new System.Drawing.Size(413, 77);
            this.richTextBoxObservaciones.TabIndex = 6;
            this.richTextBoxObservaciones.Text = "";
            // 
            // dateTPEntrada
            // 
            this.dateTPEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTPEntrada.Location = new System.Drawing.Point(87, 3);
            this.dateTPEntrada.Name = "dateTPEntrada";
            this.dateTPEntrada.Size = new System.Drawing.Size(215, 20);
            this.dateTPEntrada.TabIndex = 4;
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 317);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(521, 32);
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
            this.groupBoxBovino.Location = new System.Drawing.Point(3, 198);
            this.groupBoxBovino.Name = "groupBoxBovino";
            this.groupBoxBovino.Size = new System.Drawing.Size(521, 90);
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
            this.LayoutBovino.Controls.Add(this.comboBoxPadre, 1, 1);
            this.LayoutBovino.Controls.Add(this.comboBoxBovino, 1, 0);
            this.LayoutBovino.Controls.Add(this.labelBovino, 0, 0);
            this.LayoutBovino.Controls.Add(this.labelPadre, 0, 1);
            this.LayoutBovino.Location = new System.Drawing.Point(3, 11);
            this.LayoutBovino.Name = "LayoutBovino";
            this.LayoutBovino.RowCount = 2;
            this.LayoutBovino.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.LayoutBovino.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.LayoutBovino.Size = new System.Drawing.Size(512, 56);
            this.LayoutBovino.TabIndex = 0;
            // 
            // comboBoxPadre
            // 
            this.comboBoxPadre.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPadre.FormattingEnabled = true;
            this.comboBoxPadre.Location = new System.Drawing.Point(95, 28);
            this.comboBoxPadre.Name = "comboBoxPadre";
            this.comboBoxPadre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPadre.Sorted = true;
            this.comboBoxPadre.TabIndex = 2;
            // 
            // comboBoxBovino
            // 
            this.comboBoxBovino.BackColor = System.Drawing.SystemColors.Window;
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
            this.labelBovino.Location = new System.Drawing.Point(3, 6);
            this.labelBovino.Name = "labelBovino";
            this.labelBovino.Size = new System.Drawing.Size(86, 13);
            this.labelBovino.TabIndex = 0;
            this.labelBovino.Text = "Madre";
            // 
            // labelPadre
            // 
            this.labelPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPadre.AutoSize = true;
            this.labelPadre.Location = new System.Drawing.Point(3, 34);
            this.labelPadre.Name = "labelPadre";
            this.labelPadre.Size = new System.Drawing.Size(86, 13);
            this.labelPadre.TabIndex = 2;
            this.labelPadre.Text = "Padre";
            // 
            // FormInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(527, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormInseminacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inseminación";
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
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.DateTimePicker dateTPEntrada;
        private System.Windows.Forms.RichTextBox richTextBoxObservaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelSanidadId;
        private System.Windows.Forms.TextBox textBoxSanidadId;
        private System.Windows.Forms.GroupBox groupBoxBovino;
        private System.Windows.Forms.TableLayoutPanel LayoutBovino;
        private System.Windows.Forms.ComboBox comboBoxPadre;
        private System.Windows.Forms.ComboBox comboBoxBovino;
        private System.Windows.Forms.Label labelBovino;
        private System.Windows.Forms.Label labelPadre;
    }
}