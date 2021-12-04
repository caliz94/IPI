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
            this.dgvFabrica = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnFabricaInactiva = new System.Windows.Forms.Button();
            this.btnFabricaActiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFabrica
            // 
            this.dgvFabrica.AllowUserToAddRows = false;
            this.dgvFabrica.AllowUserToDeleteRows = false;
            this.dgvFabrica.AllowUserToOrderColumns = true;
            this.dgvFabrica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFabrica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFabrica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabrica.Location = new System.Drawing.Point(12, 75);
            this.dgvFabrica.Name = "dgvFabrica";
            this.dgvFabrica.ReadOnly = true;
            this.dgvFabrica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFabrica.Size = new System.Drawing.Size(776, 363);
            this.dgvFabrica.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(332, 9);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 57);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Fabricas";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnFabricaInactiva
            // 
            this.btnFabricaInactiva.Location = new System.Drawing.Point(640, 9);
            this.btnFabricaInactiva.Name = "btnFabricaInactiva";
            this.btnFabricaInactiva.Size = new System.Drawing.Size(148, 57);
            this.btnFabricaInactiva.TabIndex = 2;
            this.btnFabricaInactiva.Text = "Fabricas\r\nInactivas";
            this.btnFabricaInactiva.UseVisualStyleBackColor = true;
            this.btnFabricaInactiva.Click += new System.EventHandler(this.btnFabricaInactiva_Click);
            // 
            // btnFabricaActiva
            // 
            this.btnFabricaActiva.Location = new System.Drawing.Point(486, 9);
            this.btnFabricaActiva.Name = "btnFabricaActiva";
            this.btnFabricaActiva.Size = new System.Drawing.Size(148, 57);
            this.btnFabricaActiva.TabIndex = 3;
            this.btnFabricaActiva.Text = "Fabricas\r\nActivas";
            this.btnFabricaActiva.UseVisualStyleBackColor = true;
            this.btnFabricaActiva.Click += new System.EventHandler(this.btnFabricaActiva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "FABRICAS";
            // 
            // CP_MostrarFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFabricaActiva);
            this.Controls.Add(this.btnFabricaInactiva);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvFabrica);
            this.Name = "CP_MostrarFabrica";
            this.Text = "ActualizarFabrica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarFabrica_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarFabrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFabrica;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnFabricaInactiva;
        private System.Windows.Forms.Button btnFabricaActiva;
        private System.Windows.Forms.Label label1;
    }
}