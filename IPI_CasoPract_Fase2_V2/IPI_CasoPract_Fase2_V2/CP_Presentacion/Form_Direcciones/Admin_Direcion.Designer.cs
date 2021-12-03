
namespace CP_Presentacion.Form_Direcciones
{
    partial class Admin_Direcion
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.pnl_izq = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numero_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.txt_Barrio = new System.Windows.Forms.TextBox();
            this.txt_Distrito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.btn_NuevDire = new FontAwesome.Sharp.IconButton();
            this.pnl_Ctrls = new System.Windows.Forms.Panel();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.pnl_der = new System.Windows.Forms.Panel();
            this.dgv_direciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.pnl_izq.SuspendLayout();
            this.pnl_Ctrls.SuspendLayout();
            this.pnl_der.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.Location = new System.Drawing.Point(0, 28);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(200, 422);
            this.dgv_clientes.TabIndex = 0;
            this.dgv_clientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_clientes_CellMouseDoubleClick);
            // 
            // pnl_izq
            // 
            this.pnl_izq.Controls.Add(this.dgv_clientes);
            this.pnl_izq.Controls.Add(this.label8);
            this.pnl_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_izq.Location = new System.Drawing.Point(0, 0);
            this.pnl_izq.Name = "pnl_izq";
            this.pnl_izq.Size = new System.Drawing.Size(200, 450);
            this.pnl_izq.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Clientes Activos ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_numero_direccion
            // 
            this.txt_numero_direccion.Enabled = false;
            this.txt_numero_direccion.Location = new System.Drawing.Point(19, 105);
            this.txt_numero_direccion.Name = "txt_numero_direccion";
            this.txt_numero_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_direccion.TabIndex = 3;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(19, 67);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_cliente.TabIndex = 4;
            // 
            // txt_NumeroCliente
            // 
            this.txt_NumeroCliente.Enabled = false;
            this.txt_NumeroCliente.Location = new System.Drawing.Point(19, 26);
            this.txt_NumeroCliente.Name = "txt_NumeroCliente";
            this.txt_NumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_NumeroCliente.TabIndex = 5;
            // 
            // txt_Calle
            // 
            this.txt_Calle.Enabled = false;
            this.txt_Calle.Location = new System.Drawing.Point(19, 145);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(100, 20);
            this.txt_Calle.TabIndex = 6;
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.Enabled = false;
            this.txt_Barrio.Location = new System.Drawing.Point(19, 187);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.Size = new System.Drawing.Size(100, 20);
            this.txt_Barrio.TabIndex = 7;
            // 
            // txt_Distrito
            // 
            this.txt_Distrito.Enabled = false;
            this.txt_Distrito.Location = new System.Drawing.Point(19, 226);
            this.txt_Distrito.Name = "txt_Distrito";
            this.txt_Distrito.Size = new System.Drawing.Size(100, 20);
            this.txt_Distrito.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id de Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Barrio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Distrito";
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_editar.IconColor = System.Drawing.Color.Black;
            this.btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editar.Location = new System.Drawing.Point(220, 132);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(118, 23);
            this.btn_editar.TabIndex = 16;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_guardar.IconColor = System.Drawing.Color.Black;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.Location = new System.Drawing.Point(119, 263);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(78, 23);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_NuevDire
            // 
            this.btn_NuevDire.Enabled = false;
            this.btn_NuevDire.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_NuevDire.IconColor = System.Drawing.Color.Black;
            this.btn_NuevDire.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NuevDire.Location = new System.Drawing.Point(220, 101);
            this.btn_NuevDire.Name = "btn_NuevDire";
            this.btn_NuevDire.Size = new System.Drawing.Size(118, 23);
            this.btn_NuevDire.TabIndex = 19;
            this.btn_NuevDire.Text = "Nueva Direccion";
            this.btn_NuevDire.UseVisualStyleBackColor = true;
            this.btn_NuevDire.Click += new System.EventHandler(this.btn_NuevDire_Click);
            // 
            // pnl_Ctrls
            // 
            this.pnl_Ctrls.Controls.Add(this.btn_cancelar);
            this.pnl_Ctrls.Controls.Add(this.label1);
            this.pnl_Ctrls.Controls.Add(this.txt_numero_direccion);
            this.pnl_Ctrls.Controls.Add(this.txt_nombre_cliente);
            this.pnl_Ctrls.Controls.Add(this.txt_NumeroCliente);
            this.pnl_Ctrls.Controls.Add(this.btn_guardar);
            this.pnl_Ctrls.Controls.Add(this.txt_Calle);
            this.pnl_Ctrls.Controls.Add(this.label6);
            this.pnl_Ctrls.Controls.Add(this.txt_Barrio);
            this.pnl_Ctrls.Controls.Add(this.label5);
            this.pnl_Ctrls.Controls.Add(this.txt_Distrito);
            this.pnl_Ctrls.Controls.Add(this.label4);
            this.pnl_Ctrls.Controls.Add(this.label2);
            this.pnl_Ctrls.Controls.Add(this.label3);
            this.pnl_Ctrls.Location = new System.Drawing.Point(360, 101);
            this.pnl_Ctrls.Name = "pnl_Ctrls";
            this.pnl_Ctrls.Size = new System.Drawing.Size(205, 318);
            this.pnl_Ctrls.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.Location = new System.Drawing.Point(19, 263);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(78, 23);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // pnl_der
            // 
            this.pnl_der.Controls.Add(this.dgv_direciones);
            this.pnl_der.Controls.Add(this.label7);
            this.pnl_der.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_der.Location = new System.Drawing.Point(585, 0);
            this.pnl_der.Name = "pnl_der";
            this.pnl_der.Size = new System.Drawing.Size(291, 450);
            this.pnl_der.TabIndex = 22;
            // 
            // dgv_direciones
            // 
            this.dgv_direciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_direciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_direciones.Location = new System.Drawing.Point(0, 28);
            this.dgv_direciones.Name = "dgv_direciones";
            this.dgv_direciones.Size = new System.Drawing.Size(291, 422);
            this.dgv_direciones.TabIndex = 23;
            this.dgv_direciones.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_direciones_CellMouseDoubleClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Direciones del cliente ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 69);
            this.label9.TabIndex = 23;
            this.label9.Text = "DOBLE CLICK PARA SELECIONAR EL CLIENTE QUE DESEA ADMINISTAR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_Direcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnl_der);
            this.Controls.Add(this.pnl_Ctrls);
            this.Controls.Add(this.btn_NuevDire);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.pnl_izq);
            this.Name = "Admin_Direcion";
            this.Text = "Admin_Direcion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Direcion_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Direcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.pnl_izq.ResumeLayout(false);
            this.pnl_Ctrls.ResumeLayout(false);
            this.pnl_Ctrls.PerformLayout();
            this.pnl_der.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Panel pnl_izq;
        private System.Windows.Forms.TextBox txt_numero_direccion;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_NumeroCliente;
        private System.Windows.Forms.TextBox txt_Calle;
        private System.Windows.Forms.TextBox txt_Barrio;
        private System.Windows.Forms.TextBox txt_Distrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private FontAwesome.Sharp.IconButton btn_NuevDire;
        private System.Windows.Forms.Panel pnl_Ctrls;
        private System.Windows.Forms.Panel pnl_der;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_direciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.Label label9;
    }
}