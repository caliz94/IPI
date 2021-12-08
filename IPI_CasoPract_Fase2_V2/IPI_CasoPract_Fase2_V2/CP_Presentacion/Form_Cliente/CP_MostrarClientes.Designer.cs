
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
            this.label_grid = new System.Windows.Forms.Label();
            this.btn_actico = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btn_inactivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostar_clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_mostar_clientes
            // 
            this.dgv_mostar_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mostar_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_mostar_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostar_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mostar_clientes.Location = new System.Drawing.Point(119, 96);
            this.dgv_mostar_clientes.Name = "dgv_mostar_clientes";
            this.dgv_mostar_clientes.ReadOnly = true;
            this.dgv_mostar_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mostar_clientes.Size = new System.Drawing.Size(466, 260);
            this.dgv_mostar_clientes.TabIndex = 0;
            // 
            // label_grid
            // 
            this.label_grid.AutoSize = true;
            this.label_grid.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_grid.Location = new System.Drawing.Point(39, 34);
            this.label_grid.Name = "label_grid";
            this.label_grid.Size = new System.Drawing.Size(0, 25);
            this.label_grid.TabIndex = 1;
            // 
            // btn_actico
            // 
            this.btn_actico.FlatAppearance.BorderSize = 0;
            this.btn_actico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_actico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_actico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_actico.Location = new System.Drawing.Point(24, 19);
            this.btn_actico.Name = "btn_actico";
            this.btn_actico.Size = new System.Drawing.Size(75, 23);
            this.btn_actico.TabIndex = 2;
            this.btn_actico.Text = "Activos";
            this.btn_actico.UseVisualStyleBackColor = true;
            this.btn_actico.Click += new System.EventHandler(this.btn_actico_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.FlatAppearance.BorderSize = 0;
            this.btn_todos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_todos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_todos.Location = new System.Drawing.Point(24, 102);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(75, 23);
            this.btn_todos.TabIndex = 3;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_inactivo
            // 
            this.btn_inactivo.FlatAppearance.BorderSize = 0;
            this.btn_inactivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inactivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_inactivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inactivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inactivo.Location = new System.Drawing.Point(23, 58);
            this.btn_inactivo.Name = "btn_inactivo";
            this.btn_inactivo.Size = new System.Drawing.Size(75, 23);
            this.btn_inactivo.TabIndex = 4;
            this.btn_inactivo.Text = "Inactivos";
            this.btn_inactivo.UseVisualStyleBackColor = true;
            this.btn_inactivo.Click += new System.EventHandler(this.btn_inactivo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label_grid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 96);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 28);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.btn_actico);
            this.panel3.Controls.Add(this.btn_todos);
            this.panel3.Controls.Add(this.btn_inactivo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 260);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(585, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 384);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            this.iconButton1.Size = new System.Drawing.Size(58, 384);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CP_MostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 384);
            this.Controls.Add(this.dgv_mostar_clientes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_MostrarClientes";
            this.Text = "CP_MostrarClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_MostrarClientes_FormClosed);
            this.Load += new System.EventHandler(this.CP_MostrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostar_clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mostar_clientes;
        private System.Windows.Forms.Label label_grid;
        private System.Windows.Forms.Button btn_actico;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btn_inactivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}