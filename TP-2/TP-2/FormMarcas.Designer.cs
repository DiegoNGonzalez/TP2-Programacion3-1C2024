namespace TP_2
{
    partial class FormMarcas
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
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lvMarcas = new System.Windows.Forms.ListView();
            this.gbxMarcas = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbxMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(272, 27);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(182, 55);
            this.lblMarcas.TabIndex = 0;
            this.lblMarcas.Text = "Marcas";
            // 
            // lvMarcas
            // 
            this.lvMarcas.HideSelection = false;
            this.lvMarcas.Location = new System.Drawing.Point(236, 121);
            this.lvMarcas.Name = "lvMarcas";
            this.lvMarcas.Size = new System.Drawing.Size(266, 178);
            this.lvMarcas.TabIndex = 1;
            this.lvMarcas.UseCompatibleStateImageBehavior = false;
            // 
            // gbxMarcas
            // 
            this.gbxMarcas.Controls.Add(this.button3);
            this.gbxMarcas.Controls.Add(this.button2);
            this.gbxMarcas.Controls.Add(this.btnAgregar);
            this.gbxMarcas.Location = new System.Drawing.Point(203, 338);
            this.gbxMarcas.Name = "gbxMarcas";
            this.gbxMarcas.Size = new System.Drawing.Size(324, 78);
            this.gbxMarcas.TabIndex = 2;
            this.gbxMarcas.TabStop = false;
            this.gbxMarcas.Text = "Secciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxMarcas);
            this.Controls.Add(this.lvMarcas);
            this.Controls.Add(this.lblMarcas);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            this.gbxMarcas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.ListView lvMarcas;
        private System.Windows.Forms.GroupBox gbxMarcas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}