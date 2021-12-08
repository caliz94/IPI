
namespace CP_Presentacion.Form_Articulos
{
    partial class CP_NuevoArticulo
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
            this.txt_existe = new System.Windows.Forms.TextBox();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod_artic = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prec_uni = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.Existencias = new System.Windows.Forms.Label();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.txt_art_provistos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fab_altern = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_fabrica = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_existe
            // 
            this.txt_existe.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_existe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_existe.Location = new System.Drawing.Point(46, 177);
            this.txt_existe.Name = "txt_existe";
            this.txt_existe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_existe.Size = new System.Drawing.Size(182, 20);
            this.txt_existe.TabIndex = 16;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.MintCream;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.btn_guardar.IconColor = System.Drawing.Color.Honeydew;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 60;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(46, 409);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_guardar.Size = new System.Drawing.Size(182, 80);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cod.Articulo";
            // 
            // txt_cod_artic
            // 
            this.txt_cod_artic.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_cod_artic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cod_artic.Location = new System.Drawing.Point(46, 89);
            this.txt_cod_artic.Name = "txt_cod_artic";
            this.txt_cod_artic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cod_artic.Size = new System.Drawing.Size(182, 20);
            this.txt_cod_artic.TabIndex = 14;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descripcion.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.Color.AliceBlue;
            this.Descripcion.Location = new System.Drawing.Point(46, 110);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Descripcion.Size = new System.Drawing.Size(93, 19);
            this.Descripcion.TabIndex = 19;
            this.Descripcion.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(46, 200);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio Unitario";
            // 
            // txt_prec_uni
            // 
            this.txt_prec_uni.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_prec_uni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_prec_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prec_uni.ForeColor = System.Drawing.Color.Black;
            this.txt_prec_uni.Location = new System.Drawing.Point(46, 222);
            this.txt_prec_uni.Name = "txt_prec_uni";
            this.txt_prec_uni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_prec_uni.Size = new System.Drawing.Size(182, 20);
            this.txt_prec_uni.TabIndex = 17;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_descrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descrip.Location = new System.Drawing.Point(46, 132);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_descrip.Size = new System.Drawing.Size(182, 20);
            this.txt_descrip.TabIndex = 15;
            // 
            // Existencias
            // 
            this.Existencias.AutoSize = true;
            this.Existencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Existencias.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencias.ForeColor = System.Drawing.Color.AliceBlue;
            this.Existencias.Location = new System.Drawing.Point(46, 155);
            this.Existencias.Name = "Existencias";
            this.Existencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Existencias.Size = new System.Drawing.Size(87, 19);
            this.Existencias.TabIndex = 20;
            this.Existencias.Text = "Existencias";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_articulos.Location = new System.Drawing.Point(281, 52);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulos.Size = new System.Drawing.Size(514, 597);
            this.dgv_articulos.TabIndex = 23;
            // 
            // txt_art_provistos
            // 
            this.txt_art_provistos.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_art_provistos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_art_provistos.Location = new System.Drawing.Point(46, 312);
            this.txt_art_provistos.Name = "txt_art_provistos";
            this.txt_art_provistos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_art_provistos.Size = new System.Drawing.Size(182, 20);
            this.txt_art_provistos.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(46, 245);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fabrica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(46, 335);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "No Fabricas Alternativas";
            // 
            // txt_fab_altern
            // 
            this.txt_fab_altern.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_fab_altern.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_fab_altern.Location = new System.Drawing.Point(46, 357);
            this.txt_fab_altern.Name = "txt_fab_altern";
            this.txt_fab_altern.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fab_altern.Size = new System.Drawing.Size(182, 20);
            this.txt_fab_altern.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(46, 290);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Articulos Provistos";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.MintCream;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btn_eliminar.IconColor = System.Drawing.Color.Honeydew;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 60;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(208, 10);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_eliminar.Size = new System.Drawing.Size(182, 78);
            this.btn_eliminar.TabIndex = 30;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.MintCream;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_editar.IconColor = System.Drawing.Color.Honeydew;
            this.btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editar.IconSize = 60;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(13, 10);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_editar.Size = new System.Drawing.Size(182, 78);
            this.btn_editar.TabIndex = 31;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.cbx_fabrica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Existencias);
            this.panel1.Controls.Add(this.txt_descrip);
            this.panel1.Controls.Add(this.txt_art_provistos);
            this.panel1.Controls.Add(this.txt_prec_uni);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.txt_fab_altern);
            this.panel1.Controls.Add(this.txt_cod_artic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.txt_existe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 697);
            this.panel1.TabIndex = 32;
            // 
            // cbx_fabrica
            // 
            this.cbx_fabrica.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbx_fabrica.FormattingEnabled = true;
            this.cbx_fabrica.Location = new System.Drawing.Point(46, 266);
            this.cbx_fabrica.Name = "cbx_fabrica";
            this.cbx_fabrica.Size = new System.Drawing.Size(182, 21);
            this.cbx_fabrica.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(281, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 100);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_articulos);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 749);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(795, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 697);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(857, 52);
            this.panel5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(853, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lista de Articulos En Excistencia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
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
            this.iconButton1.Location = new System.Drawing.Point(14, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 697);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CP_NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(857, 749);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CP_NuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevoArticulo_FormClosed);
            this.Load += new System.EventHandler(this.CP_NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_existe;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cod_artic;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prec_uni;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label Existencias;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.TextBox txt_art_provistos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fab_altern;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbx_fabrica;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}