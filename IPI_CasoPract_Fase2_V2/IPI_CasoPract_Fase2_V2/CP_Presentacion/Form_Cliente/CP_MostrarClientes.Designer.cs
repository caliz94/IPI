
namespace CP_Presentacion.Form_Cliente
{
    partial class CP_MostrarClientes
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
            this.dgv_mostar_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostar_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mostar_clientes
            // 
            this.dgv_mostar_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostar_clientes.Location = new System.Drawing.Point(28, 56);
            this.dgv_mostar_clientes.Name = "dgv_mostar_clientes";
            this.dgv_mostar_clientes.Size = new System.Drawing.Size(563, 294);
            this.dgv_mostar_clientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // CP_MostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_mostar_clientes);
            this.Name = "CP_MostrarClientes";
            this.Text = "CP_MostrarClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_MostrarClientes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostar_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mostar_clientes;
        private System.Windows.Forms.Label label1;
    }
}