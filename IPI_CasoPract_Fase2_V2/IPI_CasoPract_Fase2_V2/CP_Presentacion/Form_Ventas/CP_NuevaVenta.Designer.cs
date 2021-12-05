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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnActualizarCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Cliente:";
            // 
            // cboxNombreCliente
            // 
            this.cboxNombreCliente.FormattingEnabled = true;
            this.cboxNombreCliente.Location = new System.Drawing.Point(154, 61);
            this.cboxNombreCliente.Name = "cboxNombreCliente";
            this.cboxNombreCliente.Size = new System.Drawing.Size(288, 21);
            this.cboxNombreCliente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // cboxNombreProducto
            // 
            this.cboxNombreProducto.FormattingEnabled = true;
            this.cboxNombreProducto.Location = new System.Drawing.Point(542, 64);
            this.cboxNombreProducto.Name = "cboxNombreProducto";
            this.cboxNombreProducto.Size = new System.Drawing.Size(288, 21);
            this.cboxNombreProducto.TabIndex = 14;
            this.cboxNombreProducto.SelectedValueChanged += new System.EventHandler(this.cboxNombreProducto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Existencias:";
            // 
            // tboxExistencias
            // 
            this.tboxExistencias.Location = new System.Drawing.Point(154, 98);
            this.tboxExistencias.Name = "tboxExistencias";
            this.tboxExistencias.ReadOnly = true;
            this.tboxExistencias.Size = new System.Drawing.Size(49, 20);
            this.tboxExistencias.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(327, 99);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(542, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Chartreuse;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(660, 88);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 33);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 275);
            this.dataGridView1.TabIndex = 23;
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
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizarCliente.Enabled = false;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnActualizarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCliente.Location = new System.Drawing.Point(583, 424);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(135, 68);
            this.btnActualizarCliente.TabIndex = 24;
            this.btnActualizarCliente.Text = "GENERAR VENTA";
            this.btnActualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            // 
            // CP_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
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
            this.Load += new System.EventHandler(this.CP_NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnActualizarCliente;
    }
}