
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
            this.components = new System.ComponentModel.Container();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_LimiteCredito = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_nuevo_cliente = new FontAwesome.Sharp.IconButton();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.BackColor = System.Drawing.Color.MintCream;
            this.txt_Saldo.Location = new System.Drawing.Point(128, 197);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Saldo.Size = new System.Drawing.Size(156, 20);
            this.txt_Saldo.TabIndex = 1;
            // 
            // txt_LimiteCredito
            // 
            this.txt_LimiteCredito.BackColor = System.Drawing.Color.MintCream;
            this.txt_LimiteCredito.Location = new System.Drawing.Point(128, 249);
            this.txt_LimiteCredito.Name = "txt_LimiteCredito";
            this.txt_LimiteCredito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_LimiteCredito.Size = new System.Drawing.Size(156, 20);
            this.txt_LimiteCredito.TabIndex = 2;
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.BackColor = System.Drawing.Color.MintCream;
            this.txt_Descuento.Location = new System.Drawing.Point(128, 302);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Descuento.Size = new System.Drawing.Size(156, 20);
            this.txt_Descuento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bodoni Bd BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(128, 169);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bodoni Bd BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(128, 224);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limite de Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bodoni Bd BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(128, 275);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descuento";
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.AutoSize = true;
            this.btn_nuevo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_nuevo_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_cliente.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_nuevo_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_cliente.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_nuevo_cliente.IconColor = System.Drawing.Color.White;
            this.btn_nuevo_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nuevo_cliente.IconSize = 50;
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(128, 356);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(156, 58);
            this.btn_nuevo_cliente.TabIndex = 11;
            this.btn_nuevo_cliente.UseVisualStyleBackColor = false;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.MintCream;
            this.errorProvider1.SetIconAlignment(this.txt_cliente, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.txt_cliente.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txt_cliente.Location = new System.Drawing.Point(128, 141);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cliente.Size = new System.Drawing.Size(156, 20);
            this.txt_cliente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bodoni Bd BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(128, 111);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(556, 141);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bodoni Bd BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(264, 28);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(406, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ingrese Los Datos Personales Del Nuevo Cliente";
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
            this.iconButton1.Location = new System.Drawing.Point(880, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(55, 425);
            this.iconButton1.TabIndex = 37;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.iconButton1, "Atras");
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CP_NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(935, 425);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_nuevo_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LimiteCredito);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CP_NuevoCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevoCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_LimiteCredito;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_nuevo_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}