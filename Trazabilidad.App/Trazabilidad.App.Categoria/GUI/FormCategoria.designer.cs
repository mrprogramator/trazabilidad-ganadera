namespace Trazabilidad.App.Categorias.GUI
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_CatNombre = new System.Windows.Forms.Label();
            this.comboBx_Nombre = new System.Windows.Forms.ComboBox();
            this.richTextBx_Descripcion = new System.Windows.Forms.RichTextBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.LayoutSex = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtn_Hembra = new System.Windows.Forms.RadioButton();
            this.radioBtn_Macho = new System.Windows.Forms.RadioButton();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.LayoutBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.LayoutMain.SuspendLayout();
            this.LayoutMiddle.SuspendLayout();
            this.LayoutSex.SuspendLayout();
            this.LayoutBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.LayoutMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayoutMain.BackgroundImage")));
            this.LayoutMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LayoutMain.ColumnCount = 1;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Controls.Add(this.LayoutMiddle, 0, 1);
            this.LayoutMain.Controls.Add(this.lbl_Tittle, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutBottomButtons, 0, 2);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 3;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMain.Size = new System.Drawing.Size(414, 278);
            this.LayoutMain.TabIndex = 0;
            // 
            // LayoutMiddle
            // 
            this.LayoutMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutMiddle.ColumnCount = 2;
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutMiddle.Controls.Add(this.lbl_Descripcion, 0, 2);
            this.LayoutMiddle.Controls.Add(this.lbl_CatNombre, 0, 0);
            this.LayoutMiddle.Controls.Add(this.comboBx_Nombre, 1, 0);
            this.LayoutMiddle.Controls.Add(this.richTextBx_Descripcion, 1, 2);
            this.LayoutMiddle.Controls.Add(this.lbl_Sexo, 0, 1);
            this.LayoutMiddle.Controls.Add(this.LayoutSex, 1, 1);
            this.LayoutMiddle.Location = new System.Drawing.Point(3, 63);
            this.LayoutMiddle.Name = "LayoutMiddle";
            this.LayoutMiddle.RowCount = 3;
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMiddle.Size = new System.Drawing.Size(408, 178);
            this.LayoutMiddle.TabIndex = 4;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(3, 56);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(107, 13);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_CatNombre
            // 
            this.lbl_CatNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CatNombre.AutoSize = true;
            this.lbl_CatNombre.Location = new System.Drawing.Point(3, 7);
            this.lbl_CatNombre.Name = "lbl_CatNombre";
            this.lbl_CatNombre.Size = new System.Drawing.Size(107, 13);
            this.lbl_CatNombre.TabIndex = 4;
            this.lbl_CatNombre.Text = "Nombre de Categoria";
            // 
            // comboBx_Nombre
            // 
            this.comboBx_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBx_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_Nombre.FormattingEnabled = true;
            this.comboBx_Nombre.Location = new System.Drawing.Point(116, 3);
            this.comboBx_Nombre.Name = "comboBx_Nombre";
            this.comboBx_Nombre.Size = new System.Drawing.Size(289, 21);
            this.comboBx_Nombre.TabIndex = 10;
            this.comboBx_Nombre.SelectedIndexChanged += new System.EventHandler(this.comboBx_BovinoId_SelectedIndexChanged);
            // 
            // richTextBx_Descripcion
            // 
            this.richTextBx_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBx_Descripcion.Location = new System.Drawing.Point(116, 59);
            this.richTextBx_Descripcion.Name = "richTextBx_Descripcion";
            this.richTextBx_Descripcion.Size = new System.Drawing.Size(289, 116);
            this.richTextBx_Descripcion.TabIndex = 11;
            this.richTextBx_Descripcion.Text = "";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(3, 35);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(107, 13);
            this.lbl_Sexo.TabIndex = 5;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // LayoutSex
            // 
            this.LayoutSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LayoutSex.ColumnCount = 2;
            this.LayoutSex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutSex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutSex.Controls.Add(this.radioBtn_Hembra, 0, 0);
            this.LayoutSex.Controls.Add(this.radioBtn_Macho, 1, 0);
            this.LayoutSex.Location = new System.Drawing.Point(116, 30);
            this.LayoutSex.Name = "LayoutSex";
            this.LayoutSex.RowCount = 1;
            this.LayoutSex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutSex.Size = new System.Drawing.Size(289, 23);
            this.LayoutSex.TabIndex = 12;
            // 
            // radioBtn_Hembra
            // 
            this.radioBtn_Hembra.AutoSize = true;
            this.radioBtn_Hembra.BackColor = System.Drawing.Color.White;
            this.radioBtn_Hembra.Checked = true;
            this.radioBtn_Hembra.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_Hembra.Name = "radioBtn_Hembra";
            this.radioBtn_Hembra.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_Hembra.TabIndex = 0;
            this.radioBtn_Hembra.TabStop = true;
            this.radioBtn_Hembra.Text = "Hembra";
            this.radioBtn_Hembra.UseVisualStyleBackColor = false;
            // 
            // radioBtn_Macho
            // 
            this.radioBtn_Macho.AutoSize = true;
            this.radioBtn_Macho.Location = new System.Drawing.Point(147, 3);
            this.radioBtn_Macho.Name = "radioBtn_Macho";
            this.radioBtn_Macho.Size = new System.Drawing.Size(58, 17);
            this.radioBtn_Macho.TabIndex = 1;
            this.radioBtn_Macho.Text = "Macho";
            this.radioBtn_Macho.UseVisualStyleBackColor = true;
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.Location = new System.Drawing.Point(3, 11);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(408, 37);
            this.lbl_Tittle.TabIndex = 5;
            this.lbl_Tittle.Text = "Editar Categoria";
            this.lbl_Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutBottomButtons
            // 
            this.LayoutBottomButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutBottomButtons.ColumnCount = 2;
            this.LayoutBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutBottomButtons.Controls.Add(this.btn_Guardar, 0, 0);
            this.LayoutBottomButtons.Controls.Add(this.btn_Cancelar, 1, 0);
            this.LayoutBottomButtons.Location = new System.Drawing.Point(3, 247);
            this.LayoutBottomButtons.Name = "LayoutBottomButtons";
            this.LayoutBottomButtons.RowCount = 1;
            this.LayoutBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottomButtons.Size = new System.Drawing.Size(408, 28);
            this.LayoutBottomButtons.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(249, 3);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 22);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(330, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 22);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 278);
            this.Controls.Add(this.LayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(434, 320);
            this.Name = "FormCategoria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMain.PerformLayout();
            this.LayoutMiddle.ResumeLayout(false);
            this.LayoutMiddle.PerformLayout();
            this.LayoutSex.ResumeLayout(false);
            this.LayoutSex.PerformLayout();
            this.LayoutBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutMiddle;
        private System.Windows.Forms.Label lbl_CatNombre;
        public System.Windows.Forms.ComboBox comboBx_Nombre;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.TableLayoutPanel LayoutBottomButtons;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.RichTextBox richTextBx_Descripcion;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.TableLayoutPanel LayoutSex;
        private System.Windows.Forms.RadioButton radioBtn_Hembra;
        private System.Windows.Forms.RadioButton radioBtn_Macho;


    }
}

