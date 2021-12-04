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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Fabrica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Fabrica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // tboxIdFabrica
            // 
            this.tboxIdFabrica.Enabled = false;
            this.tboxIdFabrica.Location = new System.Drawing.Point(137, 87);
            this.tboxIdFabrica.Name = "tboxIdFabrica";
            this.tboxIdFabrica.Size = new System.Drawing.Size(43, 20);
            this.tboxIdFabrica.TabIndex = 3;
            this.tboxIdFabrica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxIdFabrica_KeyUp);
            // 
            // tboxNombreFabrica
            // 
            this.tboxNombreFabrica.Enabled = false;
            this.tboxNombreFabrica.Location = new System.Drawing.Point(137, 118);
            this.tboxNombreFabrica.Name = "tboxNombreFabrica";
            this.tboxNombreFabrica.Size = new System.Drawing.Size(323, 20);
            this.tboxNombreFabrica.TabIndex = 4;
            this.tboxNombreFabrica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxNombreFabrica_KeyUp);
            // 
            // chk_Estado
            // 
            this.chk_Estado.AutoSize = true;
            this.chk_Estado.Enabled = false;
            this.chk_Estado.Location = new System.Drawing.Point(566, 92);
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
            this.pnlBusqueda.Location = new System.Drawing.Point(189, 78);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(271, 34);
            this.pnlBusqueda.TabIndex = 7;
            // 
            // chkBuscaNombre
            // 
            this.chkBuscaNombre.AutoSize = true;
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
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar Por:";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Enabled = false;
            this.tboxTelefono.Location = new System.Drawing.Point(567, 117);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(188, 20);
            this.tboxTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "Actualizar Proveedor";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 144);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(776, 220);
            this.dgvProveedores.TabIndex = 11;
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizarCliente.Enabled = false;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnActualizarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCliente.Location = new System.Drawing.Point(371, 370);
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
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(512, 370);
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
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(653, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 68);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CP_ActualizarFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.chk_Estado);
            this.Controls.Add(this.tboxNombreFabrica);
            this.Controls.Add(this.tboxIdFabrica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CP_ActualizarFabrica";
            this.Text = "CP_ActualizarFabrica";
            this.Load += new System.EventHandler(this.CP_ActualizarFabrica_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}