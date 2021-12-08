namespace CP_Presentacion.Form_Fabrica
{
    partial class CP_NuevaFabrica
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
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNombreFabrica = new System.Windows.Forms.TextBox();
            this.btnGuardarFabrica = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(100, 182);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxTelefono.Size = new System.Drawing.Size(230, 20);
            this.tboxTelefono.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(96, 159);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(96, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre Fabrica:";
            // 
            // tboxNombreFabrica
            // 
            this.tboxNombreFabrica.Location = new System.Drawing.Point(100, 125);
            this.tboxNombreFabrica.Name = "tboxNombreFabrica";
            this.tboxNombreFabrica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxNombreFabrica.Size = new System.Drawing.Size(230, 20);
            this.tboxNombreFabrica.TabIndex = 32;
            // 
            // btnGuardarFabrica
            // 
            this.btnGuardarFabrica.FlatAppearance.BorderSize = 0;
            this.btnGuardarFabrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardarFabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFabrica.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGuardarFabrica.IconColor = System.Drawing.Color.MintCream;
            this.btnGuardarFabrica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarFabrica.IconSize = 60;
            this.btnGuardarFabrica.Location = new System.Drawing.Point(100, 219);
            this.btnGuardarFabrica.Name = "btnGuardarFabrica";
            this.btnGuardarFabrica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardarFabrica.Size = new System.Drawing.Size(230, 74);
            this.btnGuardarFabrica.TabIndex = 31;
            this.btnGuardarFabrica.UseVisualStyleBackColor = true;
            this.btnGuardarFabrica.Click += new System.EventHandler(this.btnGuardarFabrica_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(713, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 475);
            this.panel4.TabIndex = 36;
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
            this.iconButton1.Size = new System.Drawing.Size(58, 475);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CP_NuevaFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(792, 475);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNombreFabrica);
            this.Controls.Add(this.btnGuardarFabrica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_NuevaFabrica";
            this.Text = "NuevaFabrica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaFabrica_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNombreFabrica;
        private FontAwesome.Sharp.IconButton btnGuardarFabrica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}