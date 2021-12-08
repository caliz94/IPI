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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxDirecciones = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarVenta = new FontAwesome.Sharp.IconButton();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarCarrito = new FontAwesome.Sharp.IconButton();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxExistencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxNombreProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxNombreCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1014, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 630);
            this.panel1.TabIndex = 29;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Crimson;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnSalir.IconColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 60;
            this.btnSalir.Location = new System.Drawing.Point(17, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 630);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar Ventana De Ventas");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 630);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cboxDirecciones);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGenerarVenta);
            this.panel3.Controls.Add(this.dgvVentas);
            this.panel3.Controls.Add(this.btn_AgregarCarrito);
            this.panel3.Controls.Add(this.tboxPrecio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.numCantidad);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxExistencias);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboxNombreProducto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboxNombreCliente);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(68, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 494);
            this.panel3.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(371, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Dirección Entrega:";
            // 
            // cboxDirecciones
            // 
            this.cboxDirecciones.FormattingEnabled = true;
            this.cboxDirecciones.Location = new System.Drawing.Point(535, 103);
            this.cboxDirecciones.Name = "cboxDirecciones";
            this.cboxDirecciones.Size = new System.Drawing.Size(288, 21);
            this.cboxDirecciones.TabIndex = 44;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(731, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 68);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerarVenta.FlatAppearance.BorderSize = 0;
            this.btnGenerarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnGenerarVenta.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnGenerarVenta.IconColor = System.Drawing.Color.White;
            this.btnGenerarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarVenta.Location = new System.Drawing.Point(590, 417);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(135, 68);
            this.btnGenerarVenta.TabIndex = 42;
            this.btnGenerarVenta.Text = "GENERAR VENTA";
            this.btnGenerarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
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
            this.Eliminar,
            this.Direccion});
            this.dgvVentas.Location = new System.Drawing.Point(19, 136);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(850, 275);
            this.dgvVentas.TabIndex = 41;
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
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // btn_AgregarCarrito
            // 
            this.btn_AgregarCarrito.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarCarrito.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_AgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AgregarCarrito.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_AgregarCarrito.IconColor = System.Drawing.Color.White;
            this.btn_AgregarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarCarrito.IconSize = 35;
            this.btn_AgregarCarrito.Location = new System.Drawing.Point(832, 97);
            this.btn_AgregarCarrito.Name = "btn_AgregarCarrito";
            this.btn_AgregarCarrito.Size = new System.Drawing.Size(34, 33);
            this.btn_AgregarCarrito.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btn_AgregarCarrito, "Agregar Producto al Carrito");
            this.btn_AgregarCarrito.UseVisualStyleBackColor = false;
            this.btn_AgregarCarrito.Click += new System.EventHandler(this.btn_AgregarCarrito_Click);
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Enabled = false;
            this.tboxPrecio.Location = new System.Drawing.Point(251, 103);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.ReadOnly = true;
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(181, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Precio:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(110, 103);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(41, 20);
            this.numCantidad.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cantidad:";
            // 
            // tboxExistencias
            // 
            this.tboxExistencias.Enabled = false;
            this.tboxExistencias.Location = new System.Drawing.Point(816, 65);
            this.tboxExistencias.Name = "tboxExistencias";
            this.tboxExistencias.ReadOnly = true;
            this.tboxExistencias.Size = new System.Drawing.Size(49, 20);
            this.tboxExistencias.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(705, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Existencias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(402, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Producto:";
            // 
            // cboxNombreProducto
            // 
            this.cboxNombreProducto.FormattingEnabled = true;
            this.cboxNombreProducto.Location = new System.Drawing.Point(494, 65);
            this.cboxNombreProducto.Name = "cboxNombreProducto";
            this.cboxNombreProducto.Size = new System.Drawing.Size(206, 21);
            this.cboxNombreProducto.TabIndex = 32;
            this.cboxNombreProducto.DropDownClosed += new System.EventHandler(this.cboxNombreProducto_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre Cliente:";
            // 
            // cboxNombreCliente
            // 
            this.cboxNombreCliente.FormattingEnabled = true;
            this.cboxNombreCliente.Location = new System.Drawing.Point(161, 65);
            this.cboxNombreCliente.Name = "cboxNombreCliente";
            this.cboxNombreCliente.Size = new System.Drawing.Size(235, 21);
            this.cboxNombreCliente.TabIndex = 30;
            this.cboxNombreCliente.DropDownClosed += new System.EventHandler(this.cboxNombreCliente_DropDownClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(382, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ventas";
            // 
            // CP_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1092, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_NuevaVenta";
            this.Text = "CP_NuevaVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevaVenta_FormClosed);
            this.Load += new System.EventHandler(this.CP_NuevaVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxDirecciones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGenerarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private FontAwesome.Sharp.IconButton btn_AgregarCarrito;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxExistencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}