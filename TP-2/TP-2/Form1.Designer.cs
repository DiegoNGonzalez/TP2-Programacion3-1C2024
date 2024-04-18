namespace TP_2
{
    partial class FormInicio
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
            this.lblNombreInicio = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreInicio
            // 
            this.lblNombreInicio.AutoSize = true;
            this.lblNombreInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInicio.Location = new System.Drawing.Point(106, 27);
            this.lblNombreInicio.Name = "lblNombreInicio";
            this.lblNombreInicio.Size = new System.Drawing.Size(361, 55);
            this.lblNombreInicio.TabIndex = 0;
            this.lblNombreInicio.Text = "Soluciones inc.";
            this.lblNombreInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(221, 101);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(119, 32);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseMnemonic = false;
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(221, 151);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(119, 32);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(221, 199);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(119, 32);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.lblNombreInicio);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soluciones inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreInicio;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
    }
}

