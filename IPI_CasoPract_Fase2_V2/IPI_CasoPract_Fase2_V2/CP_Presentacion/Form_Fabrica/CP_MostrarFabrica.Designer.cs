namespace CP_Presentacion.Form_Fabrica
{
    partial class CP_MostrarFabrica
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFabricaActiva = new System.Windows.Forms.Button();
            this.btnFabricaInactiva = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvFabrica = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(904, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 523);
            this.panel4.TabIndex = 9;
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
            this.iconButton1.Size = new System.Drawing.Size(58, 523);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 523);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(49, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 42);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnFabricaActiva);
            this.panel3.Controls.Add(this.btnFabricaInactiva);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(49, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 100);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "FABRICAS";
            // 
            // btnFabricaActiva
            // 
            this.btnFabricaActiva.FlatAppearance.BorderSize = 0;
            this.btnFabricaActiva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnFabricaActiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabricaActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricaActiva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFabricaActiva.Location = new System.Drawing.Point(492, 22);
            this.btnFabricaActiva.Name = "btnFabricaActiva";
            this.btnFabricaActiva.Size = new System.Drawing.Size(148, 57);
            this.btnFabricaActiva.TabIndex = 19;
            this.btnFabricaActiva.Text = "Fabricas\r\nActivas";
            this.btnFabricaActiva.UseVisualStyleBackColor = true;
            this.btnFabricaActiva.Click += new System.EventHandler(this.btnFabricaActiva_Click);
            // 
            // btnFabricaInactiva
            // 
            this.btnFabricaInactiva.FlatAppearance.BorderSize = 0;
            this.btnFabricaInactiva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnFabricaInactiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabricaInactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricaInactiva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFabricaInactiva.Location = new System.Drawing.Point(646, 22);
            this.btnFabricaInactiva.Name = "btnFabricaInactiva";
            this.btnFabricaInactiva.Size = new System.Drawing.Size(148, 57);
            this.btnFabricaInactiva.TabIndex = 18;
            this.btnFabricaInactiva.Text = "Fabricas\r\nInactivas";
            this.btnFabricaInactiva.UseVisualStyleBackColor = true;
            this.btnFabricaInactiva.Click += new System.EventHandler(this.btnFabricaInactiva_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(338, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 57);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Fabricas";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvFabrica);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(49, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(855, 381);
            this.panel5.TabIndex = 14;
            // 
            // dgvFabrica
            // 
            this.dgvFabrica.AllowUserToAddRows = false;
            this.dgvFabrica.AllowUserToDeleteRows = false;
            this.dgvFabrica.AllowUserToOrderColumns = true;
            this.dgvFabrica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFabrica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFabrica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvFabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabrica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFabrica.Location = new System.Drawing.Point(0, 0);
            this.dgvFabrica.Name = "dgvFabrica";
            this.dgvFabrica.ReadOnly = true;
            this.dgvFabrica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFabrica.Size = new System.Drawing.Size(855, 381);
            this.dgvFabrica.TabIndex = 13;
            // 
            // CP_MostrarFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_MostrarFabrica";
            this.Text = "ActualizarFabrica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarFabrica_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarFabrica_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFabricaActiva;
        private System.Windows.Forms.Button btnFabricaInactiva;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvFabrica;
    }
}