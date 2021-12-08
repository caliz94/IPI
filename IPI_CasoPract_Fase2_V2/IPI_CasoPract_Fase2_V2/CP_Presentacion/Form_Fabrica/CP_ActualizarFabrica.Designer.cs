namespace CP_Presentacion.Form_Fabrica
{
    partial class CP_ActualizarFabrica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxIdFabrica = new System.Windows.Forms.TextBox();
            this.tboxNombreFabrica = new System.Windows.Forms.TextBox();
            this.chk_Estado = new System.Windows.Forms.CheckBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.chkBuscaNombre = new System.Windows.Forms.CheckBox();
            this.chkBuscaId = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnActualizarCliente = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(257, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Fabrica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(229, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Fabrica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(700, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // tboxIdFabrica
            // 
            this.tboxIdFabrica.Enabled = false;
            this.tboxIdFabrica.Location = new System.Drawing.Point(320, 148);
            this.tboxIdFabrica.Name = "tboxIdFabrica";
            this.tboxIdFabrica.Size = new System.Drawing.Size(43, 20);
            this.tboxIdFabrica.TabIndex = 3;
            this.tboxIdFabrica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxIdFabrica_KeyUp);
            // 
            // tboxNombreFabrica
            // 
            this.tboxNombreFabrica.Enabled = false;
            this.tboxNombreFabrica.Location = new System.Drawing.Point(320, 179);
            this.tboxNombreFabrica.Name = "tboxNombreFabrica";
            this.tboxNombreFabrica.Size = new System.Drawing.Size(323, 20);
            this.tboxNombreFabrica.TabIndex = 4;
            this.tboxNombreFabrica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxNombreFabrica_KeyUp);
            // 
            // chk_Estado
            // 
            this.chk_Estado.AutoSize = true;
            this.chk_Estado.Enabled = false;
            this.chk_Estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chk_Estado.Location = new System.Drawing.Point(749, 153);
            this.chk_Estado.Name = "chk_Estado";
            this.chk_Estado.Size = new System.Drawing.Size(56, 17);
            this.chk_Estado.TabIndex = 5;
            this.chk_Estado.Text = "Activo";
            this.chk_Estado.UseVisualStyleBackColor = true;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.chkBuscaNombre);
            this.pnlBusqueda.Controls.Add(this.chkBuscaId);
            this.pnlBusqueda.Controls.Add(this.label4);
            this.pnlBusqueda.Location = new System.Drawing.Point(372, 139);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(271, 34);
            this.pnlBusqueda.TabIndex = 7;
            // 
            // chkBuscaNombre
            // 
            this.chkBuscaNombre.AutoSize = true;
            this.chkBuscaNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBuscaNombre.Location = new System.Drawing.Point(155, 9);
            this.chkBuscaNombre.Name = "chkBuscaNombre";
            this.chkBuscaNombre.Size = new System.Drawing.Size(101, 17);
            this.chkBuscaNombre.TabIndex = 9;
            this.chkBuscaNombre.Text = "Nombre Fabrica";
            this.chkBuscaNombre.UseVisualStyleBackColor = true;
            this.chkBuscaNombre.CheckedChanged += new System.EventHandler(this.chkBuscaNombre_CheckedChanged);
            // 
            // chkBuscaId
            // 
            this.chkBuscaId.AutoSize = true;
            this.chkBuscaId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBuscaId.Location = new System.Drawing.Point(76, 9);
            this.chkBuscaId.Name = "chkBuscaId";
            this.chkBuscaId.Size = new System.Drawing.Size(73, 17);
            this.chkBuscaId.TabIndex = 8;
            this.chkBuscaId.Text = "Id Fabrica";
            this.chkBuscaId.UseVisualStyleBackColor = true;
            this.chkBuscaId.CheckedChanged += new System.EventHandler(this.chkBuscaId_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar Por:";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Enabled = false;
            this.tboxTelefono.Location = new System.Drawing.Point(750, 178);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(188, 20);
            this.tboxTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(691, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(390, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Actualizar Proveedor";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProveedores.Location = new System.Drawing.Point(195, 205);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(776, 220);
            this.dgvProveedores.TabIndex = 11;
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizarCliente.Enabled = false;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnActualizarCliente.IconColor = System.Drawing.Color.White;
            this.btnActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCliente.Location = new System.Drawing.Point(554, 431);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(135, 68);
            this.btnActualizarCliente.TabIndex = 13;
            this.btnActualizarCliente.Text = "ACTUALIZAR";
            this.btnActualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(695, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 68);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(836, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 68);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProveedores);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnActualizarCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxIdFabrica);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tboxNombreFabrica);
            this.panel1.Controls.Add(this.tboxTelefono);
            this.panel1.Controls.Add(this.chk_Estado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnlBusqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 584);
            this.panel1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1089, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 584);
            this.panel4.TabIndex = 17;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Crimson;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.iconButton1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(21, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(58, 584);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CP_ActualizarFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1168, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_ActualizarFabrica";
            this.Text = "CP_ActualizarFabrica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarFabrica_FormClosed);
            this.Load += new System.EventHandler(this.CP_ActualizarFabrica_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxIdFabrica;
        private System.Windows.Forms.TextBox tboxNombreFabrica;
        private System.Windows.Forms.CheckBox chk_Estado;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.CheckBox chkBuscaNombre;
        private System.Windows.Forms.CheckBox chkBuscaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private FontAwesome.Sharp.IconButton btnActualizarCliente;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}