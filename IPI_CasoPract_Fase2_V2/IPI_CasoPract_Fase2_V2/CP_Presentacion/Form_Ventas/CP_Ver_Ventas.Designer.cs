﻿namespace CP_Presentacion.Form_Ventas
{
    partial class CP_Ver_Ventas
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
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.dgv_DetallePedido = new System.Windows.Forms.DataGridView();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.btn_filtar_pedido = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallePedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedido.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_pedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pedido.Location = new System.Drawing.Point(0, 40);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.ReadOnly = true;
            this.dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedido.Size = new System.Drawing.Size(714, 200);
            this.dgv_pedido.TabIndex = 0;
            this.dgv_pedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedido_CellClick);
            // 
            // dgv_DetallePedido
            // 
            this.dgv_DetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DetallePedido.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_DetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DetallePedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_DetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DetallePedido.Location = new System.Drawing.Point(0, 0);
            this.dgv_DetallePedido.Name = "dgv_DetallePedido";
            this.dgv_DetallePedido.ReadOnly = true;
            this.dgv_DetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DetallePedido.Size = new System.Drawing.Size(714, 241);
            this.dgv_DetallePedido.TabIndex = 1;
            // 
            // txt_pedido
            // 
            this.txt_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_pedido.Location = new System.Drawing.Point(15, 31);
            this.txt_pedido.Multiline = true;
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(168, 33);
            this.txt_pedido.TabIndex = 2;
            // 
            // btn_filtar_pedido
            // 
            this.btn_filtar_pedido.AutoSize = true;
            this.btn_filtar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_filtar_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtar_pedido.FlatAppearance.BorderSize = 0;
            this.btn_filtar_pedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_filtar_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_filtar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtar_pedido.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_filtar_pedido.IconColor = System.Drawing.Color.White;
            this.btn_filtar_pedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_filtar_pedido.IconSize = 20;
            this.btn_filtar_pedido.Location = new System.Drawing.Point(154, 35);
            this.btn_filtar_pedido.Name = "btn_filtar_pedido";
            this.btn_filtar_pedido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_filtar_pedido.Size = new System.Drawing.Size(26, 26);
            this.btn_filtar_pedido.TabIndex = 12;
            this.btn_filtar_pedido.UseVisualStyleBackColor = false;
            this.btn_filtar_pedido.Click += new System.EventHandler(this.btn_filtar_pedido_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_pedido);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 240);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 680);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(25, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 21);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1002, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 680);
            this.panel5.TabIndex = 17;
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
            this.iconButton1.Location = new System.Drawing.Point(13, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(58, 680);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_DetallePedido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(25, 418);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(714, 241);
            this.panel6.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_filtar_pedido);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txt_pedido);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(25, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(977, 86);
            this.panel7.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 40);
            this.panel3.TabIndex = 1;
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(15, 6);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton2.Size = new System.Drawing.Size(150, 26);
            this.iconButton2.TabIndex = 20;
            this.iconButton2.Text = "Actualizar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(25, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Detalles de Compra";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(739, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(263, 573);
            this.panel8.TabIndex = 22;
            // 
            // CP_Ver_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1073, 680);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_Ver_Ventas";
            this.Text = "CP_Ver_Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_Ver_Ventas_FormClosed);
            this.Load += new System.EventHandler(this.CP_Ver_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallePedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.DataGridView dgv_DetallePedido;
        private System.Windows.Forms.TextBox txt_pedido;
        private FontAwesome.Sharp.IconButton btn_filtar_pedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
    }
}