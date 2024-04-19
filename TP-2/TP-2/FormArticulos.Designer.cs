namespace TP_2
{
    partial class FormArticulos
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
            this.lblArticulosFormArticulos = new System.Windows.Forms.Label();
            this.lvArticulosFormArticulos = new System.Windows.Forms.ListView();
            this.btnAgregarFormArticulos = new System.Windows.Forms.Button();
            this.btnModificarFormArticulos = new System.Windows.Forms.Button();
            this.btnEliminarFormArticulos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gpSeccionesFormArticulos = new System.Windows.Forms.GroupBox();
            this.gpSeccionesFormArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArticulosFormArticulos
            // 
            this.lblArticulosFormArticulos.AutoSize = true;
            this.lblArticulosFormArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosFormArticulos.Location = new System.Drawing.Point(274, 28);
            this.lblArticulosFormArticulos.Name = "lblArticulosFormArticulos";
            this.lblArticulosFormArticulos.Size = new System.Drawing.Size(207, 55);
            this.lblArticulosFormArticulos.TabIndex = 0;
            this.lblArticulosFormArticulos.Text = "Articulos";
            this.lblArticulosFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvArticulosFormArticulos
            // 
            this.lvArticulosFormArticulos.HideSelection = false;
            this.lvArticulosFormArticulos.Location = new System.Drawing.Point(237, 120);
            this.lvArticulosFormArticulos.Name = "lvArticulosFormArticulos";
            this.lvArticulosFormArticulos.Size = new System.Drawing.Size(281, 130);
            this.lvArticulosFormArticulos.TabIndex = 1;
            this.lvArticulosFormArticulos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarFormArticulos
            // 
            this.btnAgregarFormArticulos.Location = new System.Drawing.Point(12, 19);
            this.btnAgregarFormArticulos.Name = "btnAgregarFormArticulos";
            this.btnAgregarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFormArticulos.TabIndex = 2;
            this.btnAgregarFormArticulos.Text = "Agregar";
            this.btnAgregarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // btnModificarFormArticulos
            // 
            this.btnModificarFormArticulos.Location = new System.Drawing.Point(93, 19);
            this.btnModificarFormArticulos.Name = "btnModificarFormArticulos";
            this.btnModificarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnModificarFormArticulos.TabIndex = 3;
            this.btnModificarFormArticulos.Text = "Modificar";
            this.btnModificarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFormArticulos
            // 
            this.btnEliminarFormArticulos.Location = new System.Drawing.Point(174, 19);
            this.btnEliminarFormArticulos.Name = "btnEliminarFormArticulos";
            this.btnEliminarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFormArticulos.TabIndex = 4;
            this.btnEliminarFormArticulos.Text = "Eliminar";
            this.btnEliminarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gpSeccionesFormArticulos
            // 
            this.gpSeccionesFormArticulos.Controls.Add(this.btnAgregarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.button4);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnModificarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnEliminarFormArticulos);
            this.gpSeccionesFormArticulos.Location = new System.Drawing.Point(207, 300);
            this.gpSeccionesFormArticulos.Name = "gpSeccionesFormArticulos";
            this.gpSeccionesFormArticulos.Size = new System.Drawing.Size(341, 54);
            this.gpSeccionesFormArticulos.TabIndex = 6;
            this.gpSeccionesFormArticulos.TabStop = false;
            this.gpSeccionesFormArticulos.Text = "Secciones";
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpSeccionesFormArticulos);
            this.Controls.Add(this.lvArticulosFormArticulos);
            this.Controls.Add(this.lblArticulosFormArticulos);
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArticulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.gpSeccionesFormArticulos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulosFormArticulos;
        private System.Windows.Forms.ListView lvArticulosFormArticulos;
        private System.Windows.Forms.Button btnAgregarFormArticulos;
        private System.Windows.Forms.Button btnModificarFormArticulos;
        private System.Windows.Forms.Button btnEliminarFormArticulos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gpSeccionesFormArticulos;
    }
}