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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            this.lblArticulosFormArticulos = new System.Windows.Forms.Label();
            this.btnAgregarFormArticulos = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnModificarFormArticulos = new System.Windows.Forms.Button();
            this.btnEliminarFormArticulos = new System.Windows.Forms.Button();
            this.gBoxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.btnBuscarFiltrado = new System.Windows.Forms.Button();
            this.txtBuscarFiltrado = new System.Windows.Forms.TextBox();
            this.cBoxCriterio = new System.Windows.Forms.ComboBox();
            this.cBoxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pBoxArticulosFormArticulos = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBoxBusquedaRapida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulosFormArticulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArticulosFormArticulos
            // 
            this.lblArticulosFormArticulos.AutoSize = true;
            this.lblArticulosFormArticulos.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosFormArticulos.Location = new System.Drawing.Point(348, 19);
            this.lblArticulosFormArticulos.Name = "lblArticulosFormArticulos";
            this.lblArticulosFormArticulos.Size = new System.Drawing.Size(220, 49);
            this.lblArticulosFormArticulos.TabIndex = 0;
            this.lblArticulosFormArticulos.Text = "Articulos";
            this.lblArticulosFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarFormArticulos
            // 
            this.btnAgregarFormArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnAgregarFormArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarFormArticulos.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFormArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAgregarFormArticulos.Image = global::TP_2.Properties.Resources.mas;
            this.btnAgregarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFormArticulos.Location = new System.Drawing.Point(21, 16);
            this.btnAgregarFormArticulos.Name = "btnAgregarFormArticulos";
            this.btnAgregarFormArticulos.Size = new System.Drawing.Size(113, 31);
            this.btnAgregarFormArticulos.TabIndex = 2;
            this.btnAgregarFormArticulos.Text = "Agregar";
            this.btnAgregarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarFormArticulos.UseVisualStyleBackColor = false;
            this.btnAgregarFormArticulos.Click += new System.EventHandler(this.btnAgregarFormArticulos_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDetalles.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnVerDetalles.Image = global::TP_2.Properties.Resources.informacion;
            this.btnVerDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalles.Location = new System.Drawing.Point(21, 129);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(113, 33);
            this.btnVerDetalles.TabIndex = 5;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnModificarFormArticulos
            // 
            this.btnModificarFormArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnModificarFormArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarFormArticulos.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFormArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnModificarFormArticulos.Image = global::TP_2.Properties.Resources.martillos_cruzados;
            this.btnModificarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFormArticulos.Location = new System.Drawing.Point(21, 53);
            this.btnModificarFormArticulos.Name = "btnModificarFormArticulos";
            this.btnModificarFormArticulos.Size = new System.Drawing.Size(113, 31);
            this.btnModificarFormArticulos.TabIndex = 3;
            this.btnModificarFormArticulos.Text = "Modificar";
            this.btnModificarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarFormArticulos.UseVisualStyleBackColor = false;
            this.btnModificarFormArticulos.Click += new System.EventHandler(this.btnModificarFormArticulos_Click);
            // 
            // btnEliminarFormArticulos
            // 
            this.btnEliminarFormArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnEliminarFormArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarFormArticulos.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFormArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEliminarFormArticulos.Image = global::TP_2.Properties.Resources.borrarDefinitivo;
            this.btnEliminarFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFormArticulos.Location = new System.Drawing.Point(21, 90);
            this.btnEliminarFormArticulos.Name = "btnEliminarFormArticulos";
            this.btnEliminarFormArticulos.Size = new System.Drawing.Size(113, 33);
            this.btnEliminarFormArticulos.TabIndex = 4;
            this.btnEliminarFormArticulos.Text = "Eliminar";
            this.btnEliminarFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFormArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarFormArticulos.UseVisualStyleBackColor = false;
            this.btnEliminarFormArticulos.Click += new System.EventHandler(this.btnEliminarFormArticulos_Click);
            // 
            // gBoxBusquedaRapida
            // 
            this.gBoxBusquedaRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gBoxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gBoxBusquedaRapida.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBusquedaRapida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gBoxBusquedaRapida.Location = new System.Drawing.Point(18, 307);
            this.gBoxBusquedaRapida.Name = "gBoxBusquedaRapida";
            this.gBoxBusquedaRapida.Size = new System.Drawing.Size(151, 57);
            this.gBoxBusquedaRapida.TabIndex = 7;
            this.gBoxBusquedaRapida.TabStop = false;
            this.gBoxBusquedaRapida.Text = "Busqueda rapida";
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBusquedaRapida.Location = new System.Drawing.Point(6, 21);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(128, 23);
            this.txtBusquedaRapida.TabIndex = 0;
            this.txtBusquedaRapida.TextChanged += new System.EventHandler(this.txtBusquedaRapida_TextChanged);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnLimpiarFiltro.Image = global::TP_2.Properties.Resources.escoba;
            this.btnLimpiarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(242, 76);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 29);
            this.btnLimpiarFiltro.TabIndex = 7;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // btnBuscarFiltrado
            // 
            this.btnBuscarFiltrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBuscarFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFiltrado.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFiltrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnBuscarFiltrado.Image = global::TP_2.Properties.Resources.lupa;
            this.btnBuscarFiltrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFiltrado.Location = new System.Drawing.Point(154, 76);
            this.btnBuscarFiltrado.Name = "btnBuscarFiltrado";
            this.btnBuscarFiltrado.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarFiltrado.TabIndex = 6;
            this.btnBuscarFiltrado.Text = "Buscar";
            this.btnBuscarFiltrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFiltrado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarFiltrado.UseVisualStyleBackColor = false;
            this.btnBuscarFiltrado.Click += new System.EventHandler(this.btnBuscarFiltrado_Click);
            // 
            // txtBuscarFiltrado
            // 
            this.txtBuscarFiltrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBuscarFiltrado.Location = new System.Drawing.Point(359, 36);
            this.txtBuscarFiltrado.Name = "txtBuscarFiltrado";
            this.txtBuscarFiltrado.Size = new System.Drawing.Size(121, 20);
            this.txtBuscarFiltrado.TabIndex = 5;
            // 
            // cBoxCriterio
            // 
            this.cBoxCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCriterio.FormattingEnabled = true;
            this.cBoxCriterio.Location = new System.Drawing.Point(186, 36);
            this.cBoxCriterio.Name = "cBoxCriterio";
            this.cBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cBoxCriterio.TabIndex = 4;
            // 
            // cBoxCampo
            // 
            this.cBoxCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCampo.FormattingEnabled = true;
            this.cBoxCampo.Location = new System.Drawing.Point(13, 36);
            this.cBoxCampo.Name = "cBoxCampo";
            this.cBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.cBoxCampo.TabIndex = 3;
            this.cBoxCampo.SelectedIndexChanged += new System.EventHandler(this.cBoxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblFiltro.Location = new System.Drawing.Point(356, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(64, 17);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCriterio.Location = new System.Drawing.Point(183, 9);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(80, 17);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCampo.Location = new System.Drawing.Point(10, 9);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(56, 17);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.Location = new System.Drawing.Point(197, 102);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(471, 262);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pBoxArticulosFormArticulos
            // 
            this.pBoxArticulosFormArticulos.Location = new System.Drawing.Point(694, 102);
            this.pBoxArticulosFormArticulos.Name = "pBoxArticulosFormArticulos";
            this.pBoxArticulosFormArticulos.Size = new System.Drawing.Size(229, 262);
            this.pBoxArticulosFormArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxArticulosFormArticulos.TabIndex = 9;
            this.pBoxArticulosFormArticulos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarFiltrado);
            this.panel1.Controls.Add(this.btnLimpiarFiltro);
            this.panel1.Controls.Add(this.lblCampo);
            this.panel1.Controls.Add(this.lblCriterio);
            this.panel1.Controls.Add(this.btnBuscarFiltrado);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.cBoxCampo);
            this.panel1.Controls.Add(this.cBoxCriterio);
            this.panel1.Location = new System.Drawing.Point(175, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 116);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarFormArticulos);
            this.panel2.Controls.Add(this.btnEliminarFormArticulos);
            this.panel2.Controls.Add(this.btnVerDetalles);
            this.panel2.Controls.Add(this.btnModificarFormArticulos);
            this.panel2.Location = new System.Drawing.Point(18, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 178);
            this.panel2.TabIndex = 12;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(932, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pBoxArticulosFormArticulos);
            this.Controls.Add(this.gBoxBusquedaRapida);
            this.Controls.Add(this.lblArticulosFormArticulos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.gBoxBusquedaRapida.ResumeLayout(false);
            this.gBoxBusquedaRapida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulosFormArticulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulosFormArticulos;
        private System.Windows.Forms.Button btnAgregarFormArticulos;
        private System.Windows.Forms.Button btnModificarFormArticulos;
        private System.Windows.Forms.Button btnEliminarFormArticulos;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.GroupBox gBoxBusquedaRapida;
        private System.Windows.Forms.TextBox txtBusquedaRapida;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}