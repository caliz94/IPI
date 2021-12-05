
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
            this.txt_fabr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_existe
            // 
            this.txt_existe.Location = new System.Drawing.Point(31, 121);
            this.txt_existe.Name = "txt_existe";
            this.txt_existe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_existe.Size = new System.Drawing.Size(182, 20);
            this.txt_existe.TabIndex = 16;
            // 
            // btn_guardar
            // 
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_guardar.IconColor = System.Drawing.Color.DarkCyan;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 60;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(31, 348);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_guardar.Size = new System.Drawing.Size(182, 64);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(31, 11);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cod.Articulo";
            // 
            // txt_cod_artic
            // 
            this.txt_cod_artic.Location = new System.Drawing.Point(31, 33);
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
            this.Descripcion.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Descripcion.Location = new System.Drawing.Point(31, 54);
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
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(31, 144);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio Unitario";
            // 
            // txt_prec_uni
            // 
            this.txt_prec_uni.Location = new System.Drawing.Point(31, 166);
            this.txt_prec_uni.Name = "txt_prec_uni";
            this.txt_prec_uni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_prec_uni.Size = new System.Drawing.Size(182, 20);
            this.txt_prec_uni.TabIndex = 17;
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(31, 76);
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
            this.Existencias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Existencias.Location = new System.Drawing.Point(31, 99);
            this.Existencias.Name = "Existencias";
            this.Existencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Existencias.Size = new System.Drawing.Size(87, 19);
            this.Existencias.TabIndex = 20;
            this.Existencias.Text = "Existencias";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Location = new System.Drawing.Point(238, 12);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.Size = new System.Drawing.Size(406, 400);
            this.dgv_articulos.TabIndex = 23;
            // 
            // txt_art_provistos
            // 
            this.txt_art_provistos.Location = new System.Drawing.Point(31, 256);
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
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(31, 189);
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
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(31, 279);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "No Fabricas Alternativas";
            // 
            // txt_fab_altern
            // 
            this.txt_fab_altern.Location = new System.Drawing.Point(31, 301);
            this.txt_fab_altern.Name = "txt_fab_altern";
            this.txt_fab_altern.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fab_altern.Size = new System.Drawing.Size(182, 20);
            this.txt_fab_altern.TabIndex = 26;
            // 
            // txt_fabr
            // 
            this.txt_fabr.Location = new System.Drawing.Point(31, 211);
            this.txt_fabr.Name = "txt_fabr";
            this.txt_fabr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fabr.Size = new System.Drawing.Size(182, 20);
            this.txt_fabr.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(31, 234);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Articulos Provistos";
            // 
            // CP_NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(656, 516);
            this.Controls.Add(this.txt_art_provistos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fab_altern);
            this.Controls.Add(this.txt_fabr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.txt_existe);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod_artic);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_prec_uni);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.Existencias);
            this.Name = "CP_NuevoArticulo";
            this.Text = "Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevoArticulo_FormClosed);
            this.Load += new System.EventHandler(this.CP_NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_fabr;
        private System.Windows.Forms.Label label7;
    }
}