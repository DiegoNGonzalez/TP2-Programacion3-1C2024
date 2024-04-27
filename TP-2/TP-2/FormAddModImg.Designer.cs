namespace TP_2
{
    partial class FormAddModImg
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
            this.txtAddModImg = new System.Windows.Forms.TextBox();
            this.btnCancelarImg = new System.Windows.Forms.Button();
            this.btnAceptarImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddModImg
            // 
            this.txtAddModImg.Location = new System.Drawing.Point(104, 127);
            this.txtAddModImg.Multiline = true;
            this.txtAddModImg.Name = "txtAddModImg";
            this.txtAddModImg.Size = new System.Drawing.Size(108, 42);
            this.txtAddModImg.TabIndex = 0;
            // 
            // btnCancelarImg
            // 
            this.btnCancelarImg.Image = global::TP_2.Properties.Resources.boton_eliminar;
            this.btnCancelarImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarImg.Location = new System.Drawing.Point(182, 218);
            this.btnCancelarImg.Name = "btnCancelarImg";
            this.btnCancelarImg.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarImg.TabIndex = 2;
            this.btnCancelarImg.Text = "Cancelar";
            this.btnCancelarImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarImg.UseVisualStyleBackColor = true;
            // 
            // btnAceptarImg
            // 
            this.btnAceptarImg.Image = global::TP_2.Properties.Resources.bien;
            this.btnAceptarImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarImg.Location = new System.Drawing.Point(58, 218);
            this.btnAceptarImg.Name = "btnAceptarImg";
            this.btnAceptarImg.Size = new System.Drawing.Size(75, 33);
            this.btnAceptarImg.TabIndex = 1;
            this.btnAceptarImg.Text = "Aceptar";
            this.btnAceptarImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarImg.UseVisualStyleBackColor = true;
            // 
            // FormAddModImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 305);
            this.Controls.Add(this.btnCancelarImg);
            this.Controls.Add(this.btnAceptarImg);
            this.Controls.Add(this.txtAddModImg);
            this.Name = "FormAddModImg";
            this.Text = "FormAddModImg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddModImg;
        private System.Windows.Forms.Button btnAceptarImg;
        private System.Windows.Forms.Button btnCancelarImg;
    }
}