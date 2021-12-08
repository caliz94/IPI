
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_Ctrls = new System.Windows.Forms.Panel();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.txt_Calle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Barrio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Distrito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NuevDire = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_der = new System.Windows.Forms.Panel();
            this.dgv_direciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_izq = new System.Windows.Forms.Panel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_Ctrls.SuspendLayout();
            this.pnl_der.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direciones)).BeginInit();
            this.pnl_izq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 592);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1082, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 592);
            this.panel2.TabIndex = 1;
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
            this.iconButton1.Location = new System.Drawing.Point(19, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(55, 592);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 48);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 40);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.pnl_Ctrls);
            this.panel5.Controls.Add(this.btn_NuevDire);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.pnl_der);
            this.panel5.Controls.Add(this.pnl_izq);
            this.panel5.Controls.Add(this.btn_editar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(50, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1032, 504);
            this.panel5.TabIndex = 4;
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
            this.pnl_Ctrls.Location = new System.Drawing.Point(433, 138);
            this.pnl_Ctrls.Name = "pnl_Ctrls";
            this.pnl_Ctrls.Size = new System.Drawing.Size(205, 318);
            this.pnl_Ctrls.TabIndex = 27;
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
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Direccion";
            // 
            // txt_numero_direccion
            // 
            this.txt_numero_direccion.Enabled = false;
            this.txt_numero_direccion.Location = new System.Drawing.Point(19, 105);
            this.txt_numero_direccion.Name = "txt_numero_direccion";
            this.txt_numero_direccion.Size = new System.Drawing.Size(168, 20);
            this.txt_numero_direccion.TabIndex = 3;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(19, 67);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(168, 20);
            this.txt_nombre_cliente.TabIndex = 4;
            // 
            // txt_NumeroCliente
            // 
            this.txt_NumeroCliente.Enabled = false;
            this.txt_NumeroCliente.Location = new System.Drawing.Point(19, 26);
            this.txt_NumeroCliente.Name = "txt_NumeroCliente";
            this.txt_NumeroCliente.Size = new System.Drawing.Size(168, 20);
            this.txt_NumeroCliente.TabIndex = 5;
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
            // txt_Calle
            // 
            this.txt_Calle.Enabled = false;
            this.txt_Calle.Location = new System.Drawing.Point(19, 145);
            this.txt_Calle.Name = "txt_Calle";
            this.txt_Calle.Size = new System.Drawing.Size(168, 20);
            this.txt_Calle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Distrito";
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.Enabled = false;
            this.txt_Barrio.Location = new System.Drawing.Point(19, 187);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.Size = new System.Drawing.Size(168, 20);
            this.txt_Barrio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Barrio";
            // 
            // txt_Distrito
            // 
            this.txt_Distrito.Enabled = false;
            this.txt_Distrito.Location = new System.Drawing.Point(19, 226);
            this.txt_Distrito.Name = "txt_Distrito";
            this.txt_Distrito.Size = new System.Drawing.Size(168, 20);
            this.txt_Distrito.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Calle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id de Cliente";
            // 
            // btn_NuevDire
            // 
            this.btn_NuevDire.FlatAppearance.BorderSize = 0;
            this.btn_NuevDire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevDire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_NuevDire.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_NuevDire.IconColor = System.Drawing.Color.White;
            this.btn_NuevDire.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NuevDire.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_NuevDire.Location = new System.Drawing.Point(308, 138);
            this.btn_NuevDire.Name = "btn_NuevDire";
            this.btn_NuevDire.Size = new System.Drawing.Size(64, 52);
            this.btn_NuevDire.TabIndex = 26;
            this.btn_NuevDire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_NuevDire.UseVisualStyleBackColor = true;
            this.btn_NuevDire.Click += new System.EventHandler(this.btn_NuevDire_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(541, 69);
            this.label9.TabIndex = 29;
            this.label9.Text = "SELECIONAR EL CLIENTE QUE DESEA ADMINISTAR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_der
            // 
            this.pnl_der.Controls.Add(this.dgv_direciones);
            this.pnl_der.Controls.Add(this.label7);
            this.pnl_der.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_der.Location = new System.Drawing.Point(741, 0);
            this.pnl_der.Name = "pnl_der";
            this.pnl_der.Size = new System.Drawing.Size(291, 504);
            this.pnl_der.TabIndex = 28;
            // 
            // dgv_direciones
            // 
            this.dgv_direciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_direciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_direciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_direciones.Location = new System.Drawing.Point(0, 28);
            this.dgv_direciones.Name = "dgv_direciones";
            this.dgv_direciones.ReadOnly = true;
            this.dgv_direciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_direciones.Size = new System.Drawing.Size(291, 476);
            this.dgv_direciones.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            // pnl_izq
            // 
            this.pnl_izq.Controls.Add(this.dgv_clientes);
            this.pnl_izq.Controls.Add(this.label8);
            this.pnl_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_izq.Location = new System.Drawing.Point(0, 0);
            this.pnl_izq.Name = "pnl_izq";
            this.pnl_izq.Size = new System.Drawing.Size(200, 504);
            this.pnl_izq.TabIndex = 24;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.Location = new System.Drawing.Point(0, 28);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(200, 476);
            this.dgv_clientes.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
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
            // btn_editar
            // 
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_editar.IconColor = System.Drawing.Color.White;
            this.btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(308, 208);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(64, 56);
            this.btn_editar.TabIndex = 25;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Admin_Direcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1156, 592);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Direcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin_Direcion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Direcion_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Direcion_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnl_Ctrls.ResumeLayout(false);
            this.pnl_Ctrls.PerformLayout();
            this.pnl_der.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_direciones)).EndInit();
            this.pnl_izq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_Ctrls;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero_direccion;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_NumeroCliente;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.TextBox txt_Calle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Barrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Distrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_NuevDire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_der;
        private System.Windows.Forms.DataGridView dgv_direciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_izq;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btn_editar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}