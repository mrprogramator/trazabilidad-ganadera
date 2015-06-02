namespace Trazabilidad.App.Start
{
    partial class FormMain
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
            this.buttonGanado = new System.Windows.Forms.Button();
            this.buttonCategorias = new System.Windows.Forms.Button();
            this.buttonSanidad = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCategorias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSanidad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReportes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGanado, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonGanado
            // 
            this.buttonGanado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGanado.Location = new System.Drawing.Point(3, 3);
            this.buttonGanado.Name = "buttonGanado";
            this.buttonGanado.Size = new System.Drawing.Size(346, 170);
            this.buttonGanado.TabIndex = 0;
            this.buttonGanado.Text = "Ganado";
            this.buttonGanado.UseVisualStyleBackColor = true;
            this.buttonGanado.Click += new System.EventHandler(this.buttonGanado_Click);
            // 
            // buttonCategorias
            // 
            this.buttonCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategorias.Location = new System.Drawing.Point(355, 3);
            this.buttonCategorias.Name = "buttonCategorias";
            this.buttonCategorias.Size = new System.Drawing.Size(347, 170);
            this.buttonCategorias.TabIndex = 1;
            this.buttonCategorias.Text = "Categorias";
            this.buttonCategorias.UseVisualStyleBackColor = true;
            this.buttonCategorias.Click += new System.EventHandler(this.buttonCategorias_Click);
            // 
            // buttonSanidad
            // 
            this.buttonSanidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSanidad.Location = new System.Drawing.Point(3, 179);
            this.buttonSanidad.Name = "buttonSanidad";
            this.buttonSanidad.Size = new System.Drawing.Size(346, 170);
            this.buttonSanidad.TabIndex = 2;
            this.buttonSanidad.Text = "Sanidad";
            this.buttonSanidad.UseVisualStyleBackColor = true;
            this.buttonSanidad.Click += new System.EventHandler(this.buttonSanidad_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportes.Location = new System.Drawing.Point(355, 179);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(347, 170);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trazabilidad Ganadera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCategorias;
        private System.Windows.Forms.Button buttonSanidad;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonGanado;
    }
}

