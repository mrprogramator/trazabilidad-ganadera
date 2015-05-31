namespace Trazabilidad.App.Ganado.GUI
{
    partial class FormGanado
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
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.comboBx_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBx_Padre = new System.Windows.Forms.ComboBox();
            this.comboBx_Madre = new System.Windows.Forms.ComboBox();
            this.lbl_BovinoId = new System.Windows.Forms.Label();
            this.lbl_Salida = new System.Windows.Forms.Label();
            this.lbl_Padre = new System.Windows.Forms.Label();
            this.lbl_Madre = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Entrada = new System.Windows.Forms.Label();
            this.radioBtn_Macho = new System.Windows.Forms.RadioButton();
            this.radioBtn_Hembra = new System.Windows.Forms.RadioButton();
            this.checkBx_Estado = new System.Windows.Forms.CheckBox();
            this.dateTP_Salida = new System.Windows.Forms.DateTimePicker();
            this.dateTP_Entrada = new System.Windows.Forms.DateTimePicker();
            this.comboBx_BovinoId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.LayoutBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.LayoutMain.SuspendLayout();
            this.LayoutMiddle.SuspendLayout();
            this.LayoutBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.ColumnCount = 1;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Controls.Add(this.LayoutMiddle, 0, 1);
            this.LayoutMain.Controls.Add(this.lbl_Tittle, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutBottomButtons, 0, 2);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 3;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMain.Size = new System.Drawing.Size(414, 260);
            this.LayoutMain.TabIndex = 0;
            // 
            // LayoutMiddle
            // 
            this.LayoutMiddle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LayoutMiddle.ColumnCount = 5;
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMiddle.Controls.Add(this.comboBx_Categoria, 1, 2);
            this.LayoutMiddle.Controls.Add(this.comboBx_Padre, 1, 4);
            this.LayoutMiddle.Controls.Add(this.comboBx_Madre, 1, 3);
            this.LayoutMiddle.Controls.Add(this.lbl_BovinoId, 0, 0);
            this.LayoutMiddle.Controls.Add(this.lbl_Salida, 0, 5);
            this.LayoutMiddle.Controls.Add(this.lbl_Padre, 0, 4);
            this.LayoutMiddle.Controls.Add(this.lbl_Madre, 0, 3);
            this.LayoutMiddle.Controls.Add(this.lbl_Categoria, 0, 2);
            this.LayoutMiddle.Controls.Add(this.lbl_Entrada, 0, 1);
            this.LayoutMiddle.Controls.Add(this.radioBtn_Macho, 4, 4);
            this.LayoutMiddle.Controls.Add(this.radioBtn_Hembra, 4, 3);
            this.LayoutMiddle.Controls.Add(this.checkBx_Estado, 4, 2);
            this.LayoutMiddle.Controls.Add(this.dateTP_Salida, 1, 5);
            this.LayoutMiddle.Controls.Add(this.dateTP_Entrada, 1, 1);
            this.LayoutMiddle.Controls.Add(this.comboBx_BovinoId, 1, 0);
            this.LayoutMiddle.Controls.Add(this.button1, 2, 2);
            this.LayoutMiddle.Location = new System.Drawing.Point(23, 58);
            this.LayoutMiddle.Name = "LayoutMiddle";
            this.LayoutMiddle.RowCount = 6;
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.Size = new System.Drawing.Size(368, 165);
            this.LayoutMiddle.TabIndex = 4;
            // 
            // comboBx_Categoria
            // 
            this.comboBx_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_Categoria.FormattingEnabled = true;
            this.comboBx_Categoria.Location = new System.Drawing.Point(61, 56);
            this.comboBx_Categoria.Name = "comboBx_Categoria";
            this.comboBx_Categoria.Size = new System.Drawing.Size(100, 21);
            this.comboBx_Categoria.TabIndex = 12;
            // 
            // comboBx_Padre
            // 
            this.comboBx_Padre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_Padre.FormattingEnabled = true;
            this.comboBx_Padre.Location = new System.Drawing.Point(61, 112);
            this.comboBx_Padre.Name = "comboBx_Padre";
            this.comboBx_Padre.Size = new System.Drawing.Size(100, 21);
            this.comboBx_Padre.TabIndex = 11;
            // 
            // comboBx_Madre
            // 
            this.comboBx_Madre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_Madre.FormattingEnabled = true;
            this.comboBx_Madre.Location = new System.Drawing.Point(61, 85);
            this.comboBx_Madre.Name = "comboBx_Madre";
            this.comboBx_Madre.Size = new System.Drawing.Size(100, 21);
            this.comboBx_Madre.TabIndex = 11;
            // 
            // lbl_BovinoId
            // 
            this.lbl_BovinoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BovinoId.AutoSize = true;
            this.lbl_BovinoId.Location = new System.Drawing.Point(3, 7);
            this.lbl_BovinoId.Name = "lbl_BovinoId";
            this.lbl_BovinoId.Size = new System.Drawing.Size(52, 13);
            this.lbl_BovinoId.TabIndex = 4;
            this.lbl_BovinoId.Text = "Bovino Id";
            // 
            // lbl_Salida
            // 
            this.lbl_Salida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Salida.Location = new System.Drawing.Point(3, 136);
            this.lbl_Salida.Name = "lbl_Salida";
            this.lbl_Salida.Size = new System.Drawing.Size(52, 31);
            this.lbl_Salida.TabIndex = 2;
            this.lbl_Salida.Text = "Salida";
            // 
            // lbl_Padre
            // 
            this.lbl_Padre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Padre.AutoSize = true;
            this.lbl_Padre.Location = new System.Drawing.Point(3, 116);
            this.lbl_Padre.Name = "lbl_Padre";
            this.lbl_Padre.Size = new System.Drawing.Size(35, 13);
            this.lbl_Padre.TabIndex = 1;
            this.lbl_Padre.Text = "Padre";
            // 
            // lbl_Madre
            // 
            this.lbl_Madre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Madre.AutoSize = true;
            this.lbl_Madre.Location = new System.Drawing.Point(3, 89);
            this.lbl_Madre.Name = "lbl_Madre";
            this.lbl_Madre.Size = new System.Drawing.Size(37, 13);
            this.lbl_Madre.TabIndex = 1;
            this.lbl_Madre.Text = "Madre";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(3, 61);
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
            // radioBtn_Macho
            // 
            this.radioBtn_Macho.AutoCheck = false;
            this.radioBtn_Macho.AutoSize = true;
            this.radioBtn_Macho.Location = new System.Drawing.Point(301, 112);
            this.radioBtn_Macho.Name = "radioBtn_Macho";
            this.radioBtn_Macho.Size = new System.Drawing.Size(58, 17);
            this.radioBtn_Macho.TabIndex = 7;
            this.radioBtn_Macho.TabStop = true;
            this.radioBtn_Macho.Text = "Macho";
            this.radioBtn_Macho.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Hembra
            // 
            this.radioBtn_Hembra.AutoCheck = false;
            this.radioBtn_Hembra.AutoSize = true;
            this.radioBtn_Hembra.Location = new System.Drawing.Point(301, 85);
            this.radioBtn_Hembra.Name = "radioBtn_Hembra";
            this.radioBtn_Hembra.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_Hembra.TabIndex = 6;
            this.radioBtn_Hembra.TabStop = true;
            this.radioBtn_Hembra.Text = "Hembra";
            this.radioBtn_Hembra.UseVisualStyleBackColor = true;
            // 
            // checkBx_Estado
            // 
            this.checkBx_Estado.AutoCheck = false;
            this.checkBx_Estado.AutoSize = true;
            this.checkBx_Estado.Location = new System.Drawing.Point(301, 56);
            this.checkBx_Estado.Name = "checkBx_Estado";
            this.checkBx_Estado.Size = new System.Drawing.Size(47, 17);
            this.checkBx_Estado.TabIndex = 5;
            this.checkBx_Estado.Text = "Vivo";
            this.checkBx_Estado.UseVisualStyleBackColor = true;
            // 
            // dateTP_Salida
            // 
            this.dateTP_Salida.Location = new System.Drawing.Point(61, 139);
            this.dateTP_Salida.Name = "dateTP_Salida";
            this.dateTP_Salida.Size = new System.Drawing.Size(100, 20);
            this.dateTP_Salida.TabIndex = 8;
            this.dateTP_Salida.CloseUp += new System.EventHandler(this.dateTP_Salida_CloseUp);
            this.dateTP_Salida.ValueChanged += new System.EventHandler(this.dateTP_Salida_ValueChanged);
            // 
            // dateTP_Entrada
            // 
            this.dateTP_Entrada.Location = new System.Drawing.Point(61, 30);
            this.dateTP_Entrada.Name = "dateTP_Entrada";
            this.dateTP_Entrada.Size = new System.Drawing.Size(100, 20);
            this.dateTP_Entrada.TabIndex = 9;
            this.dateTP_Entrada.CloseUp += new System.EventHandler(this.dateTP_Entrada_CloseUp);
            this.dateTP_Entrada.ValueChanged += new System.EventHandler(this.dateTP_Entrada_ValueChanged);
            // 
            // comboBx_BovinoId
            // 
            this.comboBx_BovinoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_BovinoId.FormattingEnabled = true;
            this.comboBx_BovinoId.Location = new System.Drawing.Point(61, 3);
            this.comboBx_BovinoId.Name = "comboBx_BovinoId";
            this.comboBx_BovinoId.Size = new System.Drawing.Size(100, 21);
            this.comboBx_BovinoId.TabIndex = 10;
            this.comboBx_BovinoId.SelectedIndexChanged += new System.EventHandler(this.comboBx_BovinoId_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(167, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Manejar Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.Location = new System.Drawing.Point(3, 9);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(408, 37);
            this.lbl_Tittle.TabIndex = 5;
            this.lbl_Tittle.Text = "Editar Bovino";
            this.lbl_Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutBottomButtons
            // 
            this.LayoutBottomButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LayoutBottomButtons.ColumnCount = 2;
            this.LayoutBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutBottomButtons.Controls.Add(this.btn_Editar, 0, 0);
            this.LayoutBottomButtons.Controls.Add(this.btn_Cancelar, 1, 0);
            this.LayoutBottomButtons.Location = new System.Drawing.Point(3, 229);
            this.LayoutBottomButtons.Name = "LayoutBottomButtons";
            this.LayoutBottomButtons.RowCount = 1;
            this.LayoutBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottomButtons.Size = new System.Drawing.Size(408, 28);
            this.LayoutBottomButtons.TabIndex = 6;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Editar.Location = new System.Drawing.Point(249, 3);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 22);
            this.btn_Editar.TabIndex = 0;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(330, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 260);
            this.Controls.Add(this.LayoutMain);
            this.MaximizeBox = false;
            this.Name = "FormGanado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganado";
            this.Activated += new System.EventHandler(this.FormGanado_Load);
            this.Load += new System.EventHandler(this.FormGanado_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMain.PerformLayout();
            this.LayoutMiddle.ResumeLayout(false);
            this.LayoutMiddle.PerformLayout();
            this.LayoutBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutMiddle;
        private System.Windows.Forms.ComboBox comboBx_Categoria;
        private System.Windows.Forms.ComboBox comboBx_Padre;
        private System.Windows.Forms.ComboBox comboBx_Madre;
        private System.Windows.Forms.Label lbl_BovinoId;
        private System.Windows.Forms.Label lbl_Salida;
        private System.Windows.Forms.Label lbl_Padre;
        private System.Windows.Forms.Label lbl_Madre;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Entrada;
        private System.Windows.Forms.RadioButton radioBtn_Macho;
        private System.Windows.Forms.RadioButton radioBtn_Hembra;
        private System.Windows.Forms.CheckBox checkBx_Estado;
        private System.Windows.Forms.DateTimePicker dateTP_Salida;
        private System.Windows.Forms.DateTimePicker dateTP_Entrada;
        public System.Windows.Forms.ComboBox comboBx_BovinoId;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.TableLayoutPanel LayoutBottomButtons;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button button1;


    }
}

