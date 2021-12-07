namespace CP_Presentacion.Form_Ventas
{
    partial class CP_NuevaVenta
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxNombreCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxNombreProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxExistencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.btn_AgregarCarrito = new FontAwesome.Sharp.IconButton();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarVenta = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxDirecciones = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Cliente:";
            // 
            // cboxNombreCliente
            // 
            this.cboxNombreCliente.FormattingEnabled = true;
            this.cboxNombreCliente.Location = new System.Drawing.Point(154, 63);
            this.cboxNombreCliente.Name = "cboxNombreCliente";
            this.cboxNombreCliente.Size = new System.Drawing.Size(235, 21);
            this.cboxNombreCliente.TabIndex = 12;
            this.cboxNombreCliente.DropDownClosed += new System.EventHandler(this.cboxNombreCliente_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // cboxNombreProducto
            // 
            this.cboxNombreProducto.FormattingEnabled = true;
            this.cboxNombreProducto.Location = new System.Drawing.Point(487, 63);
            this.cboxNombreProducto.Name = "cboxNombreProducto";
            this.cboxNombreProducto.Size = new System.Drawing.Size(206, 21);
            this.cboxNombreProducto.TabIndex = 14;
            this.cboxNombreProducto.DropDownClosed += new System.EventHandler(this.cboxNombreProducto_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Existencias:";
            // 
            // tboxExistencias
            // 
            this.tboxExistencias.Location = new System.Drawing.Point(809, 63);
            this.tboxExistencias.Name = "tboxExistencias";
            this.tboxExistencias.ReadOnly = true;
            this.tboxExistencias.Size = new System.Drawing.Size(49, 20);
            this.tboxExistencias.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(103, 101);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(41, 20);
            this.numCantidad.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio:";
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(244, 101);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.ReadOnly = true;
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 21;
            // 
            // btn_AgregarCarrito
            // 
            this.btn_AgregarCarrito.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_AgregarCarrito.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_AgregarCarrito.IconColor = System.Drawing.Color.Black;
            this.btn_AgregarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarCarrito.IconSize = 16;
            this.btn_AgregarCarrito.Location = new System.Drawing.Point(825, 95);
            this.btn_AgregarCarrito.Name = "btn_AgregarCarrito";
            this.btn_AgregarCarrito.Size = new System.Drawing.Size(34, 33);
            this.btn_AgregarCarrito.TabIndex = 22;
            this.btn_AgregarCarrito.UseVisualStyleBackColor = false;
            this.btn_AgregarCarrito.Click += new System.EventHandler(this.btn_AgregarCarrito_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.NoArticulo,
            this.DescripcionArticulo,
            this.Cantidad,
            this.PrecioUnitario,
            this.Total,
            this.FechaPedido,
            this.Eliminar});
            this.dgvVentas.Location = new System.Drawing.Point(12, 134);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(850, 275);
            this.dgvVentas.TabIndex = 23;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // NoArticulo
            // 
            this.NoArticulo.HeaderText = "NoArticulo";
            this.NoArticulo.Name = "NoArticulo";
            this.NoArticulo.ReadOnly = true;
            // 
            // DescripcionArticulo
            // 
            this.DescripcionArticulo.HeaderText = "Descripción";
            this.DescripcionArticulo.Name = "DescripcionArticulo";
            this.DescripcionArticulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FechaPedido
            // 
            this.FechaPedido.HeaderText = "Fecha";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(724, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 68);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerarVenta.FlatAppearance.BorderSize = 0;
            this.btnGenerarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenerarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.Navy;
            this.btnGenerarVenta.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnGenerarVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarVenta.Location = new System.Drawing.Point(583, 424);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(135, 68);
            this.btnGenerarVenta.TabIndex = 24;
            this.btnGenerarVenta.Text = "GENERAR VENTA";
            this.btnGenerarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Dirección Entrega:";
            // 
            // cboxDirecciones
            // 
            this.cboxDirecciones.FormattingEnabled = true;
            this.cboxDirecciones.Location = new System.Drawing.Point(528, 101);
            this.cboxDirecciones.Name = "cboxDirecciones";
            this.cboxDirecciones.Size = new System.Drawing.Size(288, 21);
            this.cboxDirecciones.TabIndex = 27;
            // 
            // CP_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 504);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxDirecciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btn_AgregarCarrito);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxExistencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxNombreCliente);
            this.Controls.Add(this.label6);
            this.Name = "CP_NuevaVenta";
            this.Text = "CP_NuevaVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevaVenta_FormClosed);
            this.Load += new System.EventHandler(this.CP_NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxExistencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPrecio;
        private FontAwesome.Sharp.IconButton btn_AgregarCarrito;
        private System.Windows.Forms.DataGridView dgvVentas;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGenerarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxDirecciones;
    }
}