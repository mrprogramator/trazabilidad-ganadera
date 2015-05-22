namespace Trazabilidad.App.Ganado.GUI
{
    partial class Form1
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Salida = new System.Windows.Forms.Label();
            this.lbl_Padre = new System.Windows.Forms.Label();
            this.lbl_Madre = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Entrada = new System.Windows.Forms.Label();
            this.txtBx_Categoria = new System.Windows.Forms.TextBox();
            this.txtBx_Madre = new System.Windows.Forms.TextBox();
            this.txtBx_Padre = new System.Windows.Forms.TextBox();
            this.radioBtn_Macho = new System.Windows.Forms.RadioButton();
            this.radioBtn_Hembra = new System.Windows.Forms.RadioButton();
            this.checkBx_Estado = new System.Windows.Forms.CheckBox();
            this.dateTP_Salida = new System.Windows.Forms.DateTimePicker();
            this.dateTP_Entrada = new System.Windows.Forms.DateTimePicker();
            this.lbl_BovinoId = new System.Windows.Forms.Label();
            this.comboBx_BovinoId = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_BovinoId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Salida, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Padre, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Madre, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Categoria, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Entrada, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBx_Categoria, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBx_Madre, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtBx_Padre, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.radioBtn_Macho, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.radioBtn_Hembra, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBx_Estado, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.dateTP_Salida, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.dateTP_Entrada, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBx_BovinoId, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(81, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 157);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lbl_Salida
            // 
            this.lbl_Salida.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Salida.AutoSize = true;
            this.lbl_Salida.Location = new System.Drawing.Point(3, 137);
            this.lbl_Salida.Name = "lbl_Salida";
            this.lbl_Salida.Size = new System.Drawing.Size(36, 13);
            this.lbl_Salida.TabIndex = 2;
            this.lbl_Salida.Text = "Salida";
            // 
            // lbl_Padre
            // 
            this.lbl_Padre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Padre.AutoSize = true;
            this.lbl_Padre.Location = new System.Drawing.Point(3, 111);
            this.lbl_Padre.Name = "lbl_Padre";
            this.lbl_Padre.Size = new System.Drawing.Size(35, 13);
            this.lbl_Padre.TabIndex = 1;
            this.lbl_Padre.Text = "Padre";
            // 
            // lbl_Madre
            // 
            this.lbl_Madre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Madre.AutoSize = true;
            this.lbl_Madre.Location = new System.Drawing.Point(3, 85);
            this.lbl_Madre.Name = "lbl_Madre";
            this.lbl_Madre.Size = new System.Drawing.Size(37, 13);
            this.lbl_Madre.TabIndex = 1;
            this.lbl_Madre.Text = "Madre";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(3, 59);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_Categoria.TabIndex = 1;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Entrada
            // 
            this.lbl_Entrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Entrada.AutoSize = true;
            this.lbl_Entrada.Location = new System.Drawing.Point(3, 33);
            this.lbl_Entrada.Name = "lbl_Entrada";
            this.lbl_Entrada.Size = new System.Drawing.Size(44, 13);
            this.lbl_Entrada.TabIndex = 0;
            this.lbl_Entrada.Text = "Entrada";
            // 
            // txtBx_Categoria
            // 
            this.txtBx_Categoria.Location = new System.Drawing.Point(84, 56);
            this.txtBx_Categoria.Name = "txtBx_Categoria";
            this.txtBx_Categoria.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Categoria.TabIndex = 2;
            // 
            // txtBx_Madre
            // 
            this.txtBx_Madre.Location = new System.Drawing.Point(84, 82);
            this.txtBx_Madre.Name = "txtBx_Madre";
            this.txtBx_Madre.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Madre.TabIndex = 3;
            // 
            // txtBx_Padre
            // 
            this.txtBx_Padre.Location = new System.Drawing.Point(84, 108);
            this.txtBx_Padre.Name = "txtBx_Padre";
            this.txtBx_Padre.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Padre.TabIndex = 4;
            // 
            // radioBtn_Macho
            // 
            this.radioBtn_Macho.AutoSize = true;
            this.radioBtn_Macho.Location = new System.Drawing.Point(232, 108);
            this.radioBtn_Macho.Name = "radioBtn_Macho";
            this.radioBtn_Macho.Size = new System.Drawing.Size(58, 17);
            this.radioBtn_Macho.TabIndex = 7;
            this.radioBtn_Macho.TabStop = true;
            this.radioBtn_Macho.Text = "Macho";
            this.radioBtn_Macho.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Hembra
            // 
            this.radioBtn_Hembra.AutoSize = true;
            this.radioBtn_Hembra.Location = new System.Drawing.Point(232, 82);
            this.radioBtn_Hembra.Name = "radioBtn_Hembra";
            this.radioBtn_Hembra.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_Hembra.TabIndex = 6;
            this.radioBtn_Hembra.TabStop = true;
            this.radioBtn_Hembra.Text = "Hembra";
            this.radioBtn_Hembra.UseVisualStyleBackColor = true;
            // 
            // checkBx_Estado
            // 
            this.checkBx_Estado.AutoSize = true;
            this.checkBx_Estado.Location = new System.Drawing.Point(232, 56);
            this.checkBx_Estado.Name = "checkBx_Estado";
            this.checkBx_Estado.Size = new System.Drawing.Size(47, 17);
            this.checkBx_Estado.TabIndex = 5;
            this.checkBx_Estado.Text = "Vivo";
            this.checkBx_Estado.UseVisualStyleBackColor = true;
            // 
            // dateTP_Salida
            // 
            this.dateTP_Salida.Location = new System.Drawing.Point(84, 134);
            this.dateTP_Salida.Name = "dateTP_Salida";
            this.dateTP_Salida.Size = new System.Drawing.Size(100, 20);
            this.dateTP_Salida.TabIndex = 8;
            // 
            // dateTP_Entrada
            // 
            this.dateTP_Entrada.Location = new System.Drawing.Point(84, 30);
            this.dateTP_Entrada.Name = "dateTP_Entrada";
            this.dateTP_Entrada.Size = new System.Drawing.Size(100, 20);
            this.dateTP_Entrada.TabIndex = 9;
            // 
            // lbl_BovinoId
            // 
            this.lbl_BovinoId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_BovinoId.AutoSize = true;
            this.lbl_BovinoId.Location = new System.Drawing.Point(3, 7);
            this.lbl_BovinoId.Name = "lbl_BovinoId";
            this.lbl_BovinoId.Size = new System.Drawing.Size(52, 13);
            this.lbl_BovinoId.TabIndex = 4;
            this.lbl_BovinoId.Text = "Bovino Id";
            // 
            // comboBx_BovinoId
            // 
            this.comboBx_BovinoId.FormattingEnabled = true;
            this.comboBx_BovinoId.Location = new System.Drawing.Point(84, 3);
            this.comboBx_BovinoId.Name = "comboBx_BovinoId";
            this.comboBx_BovinoId.Size = new System.Drawing.Size(100, 21);
            this.comboBx_BovinoId.TabIndex = 10;
            this.comboBx_BovinoId.SelectedIndexChanged += new System.EventHandler(this.comboBx_BovinoId_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 295);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_BovinoId;
        private System.Windows.Forms.Label lbl_Salida;
        private System.Windows.Forms.Label lbl_Padre;
        private System.Windows.Forms.Label lbl_Madre;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Entrada;
        private System.Windows.Forms.TextBox txtBx_Categoria;
        private System.Windows.Forms.TextBox txtBx_Madre;
        private System.Windows.Forms.TextBox txtBx_Padre;
        private System.Windows.Forms.RadioButton radioBtn_Macho;
        private System.Windows.Forms.RadioButton radioBtn_Hembra;
        private System.Windows.Forms.CheckBox checkBx_Estado;
        private System.Windows.Forms.DateTimePicker dateTP_Salida;
        private System.Windows.Forms.DateTimePicker dateTP_Entrada;
        private System.Windows.Forms.ComboBox comboBx_BovinoId;

    }
}

