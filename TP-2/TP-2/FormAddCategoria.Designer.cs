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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCategoria));
            this.txtbAddCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoriasAddCategoria = new System.Windows.Forms.Label();
            this.btnCancelarAddCategoria = new System.Windows.Forms.Button();
            this.btnAgregarAddCategoria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbAddCategoria
            // 
            this.txtbAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtbAddCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbAddCategoria.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAddCategoria.Location = new System.Drawing.Point(101, 22);
            this.txtbAddCategoria.Name = "txtbAddCategoria";
            this.txtbAddCategoria.Size = new System.Drawing.Size(123, 20);
            this.txtbAddCategoria.TabIndex = 0;
            // 
            // lblCategoriasAddCategoria
            // 
            this.lblCategoriasAddCategoria.AutoSize = true;
            this.lblCategoriasAddCategoria.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasAddCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCategoriasAddCategoria.Location = new System.Drawing.Point(15, 22);
            this.lblCategoriasAddCategoria.Name = "lblCategoriasAddCategoria";
            this.lblCategoriasAddCategoria.Size = new System.Drawing.Size(80, 17);
            this.lblCategoriasAddCategoria.TabIndex = 3;
            this.lblCategoriasAddCategoria.Text = "Categoria";
            // 
            // btnCancelarAddCategoria
            // 
            this.btnCancelarAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCancelarAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAddCategoria.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAddCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancelarAddCategoria.Image = global::TP_2.Properties.Resources.boton_eliminar;
            this.btnCancelarAddCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAddCategoria.Location = new System.Drawing.Point(148, 57);
            this.btnCancelarAddCategoria.Name = "btnCancelarAddCategoria";
            this.btnCancelarAddCategoria.Size = new System.Drawing.Size(86, 29);
            this.btnCancelarAddCategoria.TabIndex = 2;
            this.btnCancelarAddCategoria.Text = "Cancelar";
            this.btnCancelarAddCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarAddCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarAddCategoria.Click += new System.EventHandler(this.btnCancelarAddCategoria_Click);
            // 
            // btnAgregarAddCategoria
            // 
            this.btnAgregarAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAgregarAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAddCategoria.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAddCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAgregarAddCategoria.Image = global::TP_2.Properties.Resources.bien;
            this.btnAgregarAddCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAddCategoria.Location = new System.Drawing.Point(34, 57);
            this.btnAgregarAddCategoria.Name = "btnAgregarAddCategoria";
            this.btnAgregarAddCategoria.Size = new System.Drawing.Size(86, 29);
            this.btnAgregarAddCategoria.TabIndex = 1;
            this.btnAgregarAddCategoria.Text = "Aceptar";
            this.btnAgregarAddCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarAddCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarAddCategoria.Click += new System.EventHandler(this.btnAceptarAddCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategoriasAddCategoria);
            this.panel1.Controls.Add(this.txtbAddCategoria);
            this.panel1.Controls.Add(this.btnCancelarAddCategoria);
            this.panel1.Controls.Add(this.btnAgregarAddCategoria);
            this.panel1.Location = new System.Drawing.Point(53, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 106);
            this.panel1.TabIndex = 4;
            // 
            // FormAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(372, 273);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbAddCategoria;
        private System.Windows.Forms.Button btnAgregarAddCategoria;
        private System.Windows.Forms.Button btnCancelarAddCategoria;
        private System.Windows.Forms.Label lblCategoriasAddCategoria;
        private System.Windows.Forms.Panel panel1;
    }
}