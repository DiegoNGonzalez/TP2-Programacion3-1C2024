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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            this.lblArticulosFormArticulos = new System.Windows.Forms.Label();
            this.gpSeccionesFormArticulos = new System.Windows.Forms.GroupBox();
            this.btnAgregarFormArticulos = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnModificarFormArticulos = new System.Windows.Forms.Button();
            this.btnEliminarFormArticulos = new System.Windows.Forms.Button();
            this.gBoxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gBoxFiltrado = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.btnBuscarFiltrado = new System.Windows.Forms.Button();
            this.txtBuscarFiltrado = new System.Windows.Forms.TextBox();
            this.cBoxCriterio = new System.Windows.Forms.ComboBox();
            this.cBoxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAnteriorImg = new System.Windows.Forms.Button();
            this.btnSiguienteImg = new System.Windows.Forms.Button();
            this.pBoxArticulosFormArticulos = new System.Windows.Forms.PictureBox();
            this.gpSeccionesFormArticulos.SuspendLayout();
            this.gBoxBusquedaRapida.SuspendLayout();
            this.gBoxFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulosFormArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulosFormArticulos
            // 
            this.lblArticulosFormArticulos.AutoSize = true;
            this.lblArticulosFormArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosFormArticulos.Location = new System.Drawing.Point(420, 9);
            this.lblArticulosFormArticulos.Name = "lblArticulosFormArticulos";
            this.lblArticulosFormArticulos.Size = new System.Drawing.Size(207, 55);
            this.lblArticulosFormArticulos.TabIndex = 0;
            this.lblArticulosFormArticulos.Text = "Articulos";
            this.lblArticulosFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpSeccionesFormArticulos
            // 
            this.gpSeccionesFormArticulos.Controls.Add(this.btnAgregarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnVerDetalles);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnModificarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnEliminarFormArticulos);
            this.gpSeccionesFormArticulos.Location = new System.Drawing.Point(18, 102);
            this.gpSeccionesFormArticulos.Name = "gpSeccionesFormArticulos";
            this.gpSeccionesFormArticulos.Size = new System.Drawing.Size(143, 179);
            this.gpSeccionesFormArticulos.TabIndex = 6;
            this.gpSeccionesFormArticulos.TabStop = false;
            this.gpSeccionesFormArticulos.Text = "Secciones";
            // 
            // btnAgregarFormArticulos
            // 
            this.btnAgregarFormArticulos.Image = global::TP_2.Properties.Resources.mas;
            this.btnAgregarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFormArticulos.Location = new System.Drawing.Point(21, 27);
            this.btnAgregarFormArticulos.Name = "btnAgregarFormArticulos";
            this.btnAgregarFormArticulos.Size = new System.Drawing.Size(100, 31);
            this.btnAgregarFormArticulos.TabIndex = 2;
            this.btnAgregarFormArticulos.Text = "Agregar";
            this.btnAgregarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarFormArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarFormArticulos.Click += new System.EventHandler(this.btnAgregarFormArticulos_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Image = global::TP_2.Properties.Resources.informacion;
            this.btnVerDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalles.Location = new System.Drawing.Point(21, 140);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(100, 33);
            this.btnVerDetalles.TabIndex = 5;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            // 
            // btnModificarFormArticulos
            // 
            this.btnModificarFormArticulos.Image = global::TP_2.Properties.Resources.martillos_cruzados;
            this.btnModificarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFormArticulos.Location = new System.Drawing.Point(21, 64);
            this.btnModificarFormArticulos.Name = "btnModificarFormArticulos";
            this.btnModificarFormArticulos.Size = new System.Drawing.Size(100, 31);
            this.btnModificarFormArticulos.TabIndex = 3;
            this.btnModificarFormArticulos.Text = "Modificar";
            this.btnModificarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarFormArticulos.UseVisualStyleBackColor = true;
            this.btnModificarFormArticulos.Click += new System.EventHandler(this.btnModificarFormArticulos_Click);
            // 
            // btnEliminarFormArticulos
            // 
            this.btnEliminarFormArticulos.Image = global::TP_2.Properties.Resources.borrarDefinitivo;
            this.btnEliminarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFormArticulos.Location = new System.Drawing.Point(21, 101);
            this.btnEliminarFormArticulos.Name = "btnEliminarFormArticulos";
            this.btnEliminarFormArticulos.Size = new System.Drawing.Size(100, 33);
            this.btnEliminarFormArticulos.TabIndex = 4;
            this.btnEliminarFormArticulos.Text = "Eliminar";
            this.btnEliminarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarFormArticulos.UseVisualStyleBackColor = true;
            this.btnEliminarFormArticulos.Click += new System.EventHandler(this.btnEliminarFormArticulos_Click);
            // 
            // gBoxBusquedaRapida
            // 
            this.gBoxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gBoxBusquedaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBusquedaRapida.Location = new System.Drawing.Point(18, 287);
            this.gBoxBusquedaRapida.Name = "gBoxBusquedaRapida";
            this.gBoxBusquedaRapida.Size = new System.Drawing.Size(143, 57);
            this.gBoxBusquedaRapida.TabIndex = 7;
            this.gBoxBusquedaRapida.TabStop = false;
            this.gBoxBusquedaRapida.Text = "Busqueda rapida";
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Location = new System.Drawing.Point(6, 21);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(128, 22);
            this.txtBusquedaRapida.TabIndex = 0;
            this.txtBusquedaRapida.TextChanged += new System.EventHandler(this.txtBusquedaRapida_TextChanged);
            // 
            // gBoxFiltrado
            // 
            this.gBoxFiltrado.Controls.Add(this.btnLimpiarFiltro);
            this.gBoxFiltrado.Controls.Add(this.btnBuscarFiltrado);
            this.gBoxFiltrado.Controls.Add(this.txtBuscarFiltrado);
            this.gBoxFiltrado.Controls.Add(this.cBoxCriterio);
            this.gBoxFiltrado.Controls.Add(this.cBoxCampo);
            this.gBoxFiltrado.Controls.Add(this.lblFiltro);
            this.gBoxFiltrado.Controls.Add(this.lblCriterio);
            this.gBoxFiltrado.Controls.Add(this.lblCampo);
            this.gBoxFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFiltrado.Location = new System.Drawing.Point(294, 432);
            this.gBoxFiltrado.Name = "gBoxFiltrado";
            this.gBoxFiltrado.Size = new System.Drawing.Size(501, 128);
            this.gBoxFiltrado.TabIndex = 8;
            this.gBoxFiltrado.TabStop = false;
            this.gBoxFiltrado.Text = "Filtrar";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Image = global::TP_2.Properties.Resources.escoba;
            this.btnLimpiarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(249, 93);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 29);
            this.btnLimpiarFiltro.TabIndex = 7;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFiltrado
            // 
            this.btnBuscarFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFiltrado.Image = global::TP_2.Properties.Resources.lupa;
            this.btnBuscarFiltrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFiltrado.Location = new System.Drawing.Point(161, 93);
            this.btnBuscarFiltrado.Name = "btnBuscarFiltrado";
            this.btnBuscarFiltrado.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarFiltrado.TabIndex = 6;
            this.btnBuscarFiltrado.Text = "Buscar";
            this.btnBuscarFiltrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFiltrado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarFiltrado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarFiltrado
            // 
            this.txtBuscarFiltrado.Location = new System.Drawing.Point(374, 50);
            this.txtBuscarFiltrado.Name = "txtBuscarFiltrado";
            this.txtBuscarFiltrado.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarFiltrado.TabIndex = 5;
            // 
            // cBoxCriterio
            // 
            this.cBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCriterio.FormattingEnabled = true;
            this.cBoxCriterio.Location = new System.Drawing.Point(203, 50);
            this.cBoxCriterio.Name = "cBoxCriterio";
            this.cBoxCriterio.Size = new System.Drawing.Size(121, 24);
            this.cBoxCriterio.TabIndex = 4;
            // 
            // cBoxCampo
            // 
            this.cBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCampo.FormattingEnabled = true;
            this.cBoxCampo.Location = new System.Drawing.Point(28, 50);
            this.cBoxCampo.Name = "cBoxCampo";
            this.cBoxCampo.Size = new System.Drawing.Size(121, 24);
            this.cBoxCampo.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(371, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(200, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(57, 16);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(25, 26);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 16);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(221, 102);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(646, 315);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAnteriorImg
            // 
            this.btnAnteriorImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorImg.Location = new System.Drawing.Point(956, 423);
            this.btnAnteriorImg.Name = "btnAnteriorImg";
            this.btnAnteriorImg.Size = new System.Drawing.Size(44, 23);
            this.btnAnteriorImg.TabIndex = 11;
            this.btnAnteriorImg.Text = "<";
            this.btnAnteriorImg.UseVisualStyleBackColor = true;
            this.btnAnteriorImg.Click += new System.EventHandler(this.btnAnteriorImg_Click);
            // 
            // btnSiguienteImg
            // 
            this.btnSiguienteImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteImg.Location = new System.Drawing.Point(1058, 423);
            this.btnSiguienteImg.Name = "btnSiguienteImg";
            this.btnSiguienteImg.Size = new System.Drawing.Size(44, 23);
            this.btnSiguienteImg.TabIndex = 12;
            this.btnSiguienteImg.Text = ">";
            this.btnSiguienteImg.UseVisualStyleBackColor = true;
            this.btnSiguienteImg.Click += new System.EventHandler(this.btnSiguienteImg_Click);
            // 
            // pBoxArticulosFormArticulos
            // 
            this.pBoxArticulosFormArticulos.Location = new System.Drawing.Point(895, 102);
            this.pBoxArticulosFormArticulos.Name = "pBoxArticulosFormArticulos";
            this.pBoxArticulosFormArticulos.Size = new System.Drawing.Size(265, 315);
            this.pBoxArticulosFormArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxArticulosFormArticulos.TabIndex = 9;
            this.pBoxArticulosFormArticulos.TabStop = false;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 607);
            this.Controls.Add(this.btnSiguienteImg);
            this.Controls.Add(this.btnAnteriorImg);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pBoxArticulosFormArticulos);
            this.Controls.Add(this.gBoxFiltrado);
            this.Controls.Add(this.gBoxBusquedaRapida);
            this.Controls.Add(this.gpSeccionesFormArticulos);
            this.Controls.Add(this.lblArticulosFormArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.gpSeccionesFormArticulos.ResumeLayout(false);
            this.gBoxBusquedaRapida.ResumeLayout(false);
            this.gBoxBusquedaRapida.PerformLayout();
            this.gBoxFiltrado.ResumeLayout(false);
            this.gBoxFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulosFormArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulosFormArticulos;
        private System.Windows.Forms.Button btnAgregarFormArticulos;
        private System.Windows.Forms.Button btnModificarFormArticulos;
        private System.Windows.Forms.Button btnEliminarFormArticulos;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.GroupBox gpSeccionesFormArticulos;
        private System.Windows.Forms.GroupBox gBoxBusquedaRapida;
        private System.Windows.Forms.TextBox txtBusquedaRapida;
        private System.Windows.Forms.GroupBox gBoxFiltrado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtBuscarFiltrado;
        private System.Windows.Forms.ComboBox cBoxCriterio;
        private System.Windows.Forms.ComboBox cBoxCampo;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnBuscarFiltrado;
        private System.Windows.Forms.PictureBox pBoxArticulosFormArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAnteriorImg;
        private System.Windows.Forms.Button btnSiguienteImg;
    }
}