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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFabrica
            // 
            this.dgvFabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabrica.Location = new System.Drawing.Point(12, 75);
            this.dgvFabrica.Name = "dgvFabrica";
            this.dgvFabrica.Size = new System.Drawing.Size(776, 363);
            this.dgvFabrica.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(690, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // ActualizarFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvFabrica);
            this.Name = "ActualizarFabrica";
            this.Text = "ActualizarFabrica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarFabrica_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarFabrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabrica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFabrica;
        private System.Windows.Forms.Button btnActualizar;
    }
}