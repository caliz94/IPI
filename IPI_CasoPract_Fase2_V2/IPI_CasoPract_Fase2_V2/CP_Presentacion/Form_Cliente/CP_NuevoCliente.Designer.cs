
namespace CP_Presentacion.Form_Cliente
{
    partial class CP_NuevoCliente
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
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_LimiteCredito = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.txt_Activo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nuevo_cliente = new FontAwesome.Sharp.IconButton();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(34, 126);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Saldo.Size = new System.Drawing.Size(156, 20);
            this.txt_Saldo.TabIndex = 1;
            // 
            // txt_LimiteCredito
            // 
            this.txt_LimiteCredito.Location = new System.Drawing.Point(34, 169);
            this.txt_LimiteCredito.Name = "txt_LimiteCredito";
            this.txt_LimiteCredito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_LimiteCredito.Size = new System.Drawing.Size(156, 20);
            this.txt_LimiteCredito.TabIndex = 2;
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(34, 214);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Descuento.Size = new System.Drawing.Size(156, 20);
            this.txt_Descuento.TabIndex = 3;
            // 
            // txt_Activo
            // 
            this.txt_Activo.Location = new System.Drawing.Point(34, 259);
            this.txt_Activo.Name = "txt_Activo";
            this.txt_Activo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Activo.Size = new System.Drawing.Size(156, 20);
            this.txt_Activo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limite de Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(34, 192);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(34, 237);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Activo";
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_nuevo_cliente.IconColor = System.Drawing.Color.DarkCyan;
            this.btn_nuevo_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nuevo_cliente.IconSize = 40;
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(34, 285);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(156, 46);
            this.btn_nuevo_cliente.TabIndex = 11;
            this.btn_nuevo_cliente.UseVisualStyleBackColor = true;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(34, 81);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cliente.Size = new System.Drawing.Size(156, 20);
            this.txt_cliente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente";
            // 
            // CP_NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.btn_nuevo_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Activo);
            this.Controls.Add(this.txt_LimiteCredito);
            this.Controls.Add(this.label4);
            this.Name = "CP_NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CP_NuevoCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevoCliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_LimiteCredito;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.TextBox txt_Activo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_nuevo_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label1;
    }
}