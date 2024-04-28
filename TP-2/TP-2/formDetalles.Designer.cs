namespace TP_2
{
    partial class formDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetalles));
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblValorPrecio = new System.Windows.Forms.Label();
            this.lblValorCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblValorCategoria = new System.Windows.Forms.Label();
            this.lblValorDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblValorMarca = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnteriorImg = new System.Windows.Forms.Button();
            this.btnSiguienteImg = new System.Windows.Forms.Button();
            this.pbxDetallles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetallles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnVolver.Location = new System.Drawing.Point(262, 383);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 28);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.lblCodigoArticulo);
            this.panel1.Controls.Add(this.lblValorPrecio);
            this.panel1.Controls.Add(this.lblValorCodigo);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblValorCategoria);
            this.panel1.Controls.Add(this.lblValorDescripcion);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.lblValorMarca);
            this.panel1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 309);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(58, 70);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(73, 21);
            this.lblCodigoArticulo.TabIndex = 39;
            this.lblCodigoArticulo.Text = "Código:";
            // 
            // lblValorPrecio
            // 
            this.lblValorPrecio.AutoSize = true;
            this.lblValorPrecio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblValorPrecio.Location = new System.Drawing.Point(150, 220);
            this.lblValorPrecio.Name = "lblValorPrecio";
            this.lblValorPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblValorPrecio.TabIndex = 48;
            this.lblValorPrecio.Text = "label11";
            // 
            // lblValorCodigo
            // 
            this.lblValorCodigo.AutoSize = true;
            this.lblValorCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblValorCodigo.Location = new System.Drawing.Point(150, 69);
            this.lblValorCodigo.Name = "lblValorCodigo";
            this.lblValorCodigo.Size = new System.Drawing.Size(64, 21);
            this.lblValorCodigo.TabIndex = 40;
            this.lblValorCodigo.Text = "label3";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPrecio.Location = new System.Drawing.Point(58, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblPrecio.TabIndex = 47;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(118, 21);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblValorCategoria
            // 
            this.lblValorCategoria.AutoSize = true;
            this.lblValorCategoria.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblValorCategoria.Location = new System.Drawing.Point(150, 184);
            this.lblValorCategoria.Name = "lblValorCategoria";
            this.lblValorCategoria.Size = new System.Drawing.Size(64, 21);
            this.lblValorCategoria.TabIndex = 46;
            this.lblValorCategoria.Text = "label9";
            // 
            // lblValorDescripcion
            // 
            this.lblValorDescripcion.AutoSize = true;
            this.lblValorDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblValorDescripcion.Location = new System.Drawing.Point(150, 111);
            this.lblValorDescripcion.Name = "lblValorDescripcion";
            this.lblValorDescripcion.Size = new System.Drawing.Size(64, 21);
            this.lblValorDescripcion.TabIndex = 42;
            this.lblValorDescripcion.Text = "label5";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCategoria.Location = new System.Drawing.Point(31, 185);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 21);
            this.lblCategoria.TabIndex = 45;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblMarca.Location = new System.Drawing.Point(67, 150);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 21);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca:";
            // 
            // lblValorMarca
            // 
            this.lblValorMarca.AutoSize = true;
            this.lblValorMarca.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblValorMarca.Location = new System.Drawing.Point(150, 149);
            this.lblValorMarca.Name = "lblValorMarca";
            this.lblValorMarca.Size = new System.Drawing.Size(64, 21);
            this.lblValorMarca.TabIndex = 44;
            this.lblValorMarca.Text = "label7";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNombreArticulo.Location = new System.Drawing.Point(297, 9);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(111, 35);
            this.lblNombreArticulo.TabIndex = 28;
            this.lblNombreArticulo.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAnteriorImg);
            this.panel2.Controls.Add(this.btnSiguienteImg);
            this.panel2.Controls.Add(this.pbxDetallles);
            this.panel2.Location = new System.Drawing.Point(392, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 309);
            this.panel2.TabIndex = 42;
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.BackgroundImage = global::TP_2.Properties.Resources.flechaIzq;
            this.btnAnteriorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnteriorImg.FlatAppearance.BorderSize = 0;
            this.btnAnteriorImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnteriorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorImg.Location = new System.Drawing.Point(86, 259);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(44, 28);
            this.btnAnteriorImg.TabIndex = 44;
            this.btnAnteriorImg.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguienteImg.BackgroundImage = global::TP_2.Properties.Resources.flechaDer2;
            this.btnSiguienteImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguienteImg.FlatAppearance.BorderSize = 0;
            this.btnSiguienteImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSiguienteImg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguienteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteImg.Location = new System.Drawing.Point(155, 259);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(44, 28);
            this.btnSiguienteImg.TabIndex = 43;
            this.btnSiguienteImg.UseVisualStyleBackColor = false;
            // 
            // pbxDetallles
            // 
            this.pbxDetallles.Location = new System.Drawing.Point(46, 22);
            this.pbxDetallles.Name = "pbxDetallles";
            this.pbxDetallles.Size = new System.Drawing.Size(191, 221);
            this.pbxDetallles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetallles.TabIndex = 42;
            this.pbxDetallles.TabStop = false;
            // 
            // formDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(704, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetallles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblValorPrecio;
        private System.Windows.Forms.Label lblValorCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblValorCategoria;
        private System.Windows.Forms.Label lblValorDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblValorMarca;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnteriorImg;
        private System.Windows.Forms.Button btnSiguienteImg;
        private System.Windows.Forms.PictureBox pbxDetallles;
    }
}