namespace TP_2
{
    partial class FormAbmImagenes
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
            this.pBoxAbmImagenes = new System.Windows.Forms.PictureBox();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAbmImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxAbmImagenes
            // 
            this.pBoxAbmImagenes.Location = new System.Drawing.Point(477, 12);
            this.pBoxAbmImagenes.Name = "pBoxAbmImagenes";
            this.pBoxAbmImagenes.Size = new System.Drawing.Size(195, 326);
            this.pBoxAbmImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAbmImagenes.TabIndex = 0;
            this.pBoxAbmImagenes.TabStop = false;
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.Location = new System.Drawing.Point(12, 12);
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.Size = new System.Drawing.Size(440, 326);
            this.dgvImagenes.TabIndex = 1;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(155, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(285, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormAbmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.pBoxAbmImagenes);
            this.Name = "FormAbmImagenes";
            this.Text = "FormAbmImagenes";
            this.Load += new System.EventHandler(this.FormAbmImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAbmImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxAbmImagenes;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}