namespace TP_2
{
    partial class FormAddCategoria
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
            this.txtbAddCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarAddCategoria = new System.Windows.Forms.Button();
            this.btnCancelarAddCategoria = new System.Windows.Forms.Button();
            this.lblCategoriasAddCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbAddCategoria
            // 
            this.txtbAddCategoria.Location = new System.Drawing.Point(97, 152);
            this.txtbAddCategoria.Name = "txtbAddCategoria";
            this.txtbAddCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtbAddCategoria.TabIndex = 0;
            // 
            // btnAgregarAddCategoria
            // 
            this.btnAgregarAddCategoria.Image = global::TP_2.Properties.Resources.agregar;
            this.btnAgregarAddCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAddCategoria.Location = new System.Drawing.Point(46, 193);
            this.btnAgregarAddCategoria.Name = "btnAgregarAddCategoria";
            this.btnAgregarAddCategoria.Size = new System.Drawing.Size(75, 29);
            this.btnAgregarAddCategoria.TabIndex = 1;
            this.btnAgregarAddCategoria.Text = "Agregar";
            this.btnAgregarAddCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarAddCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarAddCategoria.Click += new System.EventHandler(this.btnAgregarAddCategoria_Click);
            // 
            // btnCancelarAddCategoria
            // 
            this.btnCancelarAddCategoria.Image = global::TP_2.Properties.Resources.incorrecto;
            this.btnCancelarAddCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAddCategoria.Location = new System.Drawing.Point(163, 193);
            this.btnCancelarAddCategoria.Name = "btnCancelarAddCategoria";
            this.btnCancelarAddCategoria.Size = new System.Drawing.Size(75, 29);
            this.btnCancelarAddCategoria.TabIndex = 2;
            this.btnCancelarAddCategoria.Text = "Cancelar";
            this.btnCancelarAddCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarAddCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarAddCategoria.Click += new System.EventHandler(this.btnCancelarAddCategoria_Click);
            // 
            // lblCategoriasAddCategoria
            // 
            this.lblCategoriasAddCategoria.AutoSize = true;
            this.lblCategoriasAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasAddCategoria.Location = new System.Drawing.Point(18, 153);
            this.lblCategoriasAddCategoria.Name = "lblCategoriasAddCategoria";
            this.lblCategoriasAddCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriasAddCategoria.TabIndex = 3;
            this.lblCategoriasAddCategoria.Text = "Categoria";
            // 
            // FormAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 314);
            this.Controls.Add(this.lblCategoriasAddCategoria);
            this.Controls.Add(this.btnCancelarAddCategoria);
            this.Controls.Add(this.btnAgregarAddCategoria);
            this.Controls.Add(this.txtbAddCategoria);
            this.Name = "FormAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbAddCategoria;
        private System.Windows.Forms.Button btnAgregarAddCategoria;
        private System.Windows.Forms.Button btnCancelarAddCategoria;
        private System.Windows.Forms.Label lblCategoriasAddCategoria;
    }
}