
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
            this.txt_art_rec = new System.Windows.Forms.TextBox();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fab_rec = new System.Windows.Forms.TextBox();
            this.txt_nom_fab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_art_rec
            // 
            this.txt_art_rec.Location = new System.Drawing.Point(23, 148);
            this.txt_art_rec.Name = "txt_art_rec";
            this.txt_art_rec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_art_rec.Size = new System.Drawing.Size(156, 20);
            this.txt_art_rec.TabIndex = 16;
            // 
            // btn_guardar
            // 
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_guardar.IconColor = System.Drawing.Color.DarkCyan;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 60;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(27, 249);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_guardar.Size = new System.Drawing.Size(156, 64);
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
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(23, 60);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_desc.Size = new System.Drawing.Size(156, 20);
            this.txt_desc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre de Fabrica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(23, 171);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(157, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fabricas Alternativas";
            // 
            // txt_fab_rec
            // 
            this.txt_fab_rec.Location = new System.Drawing.Point(23, 193);
            this.txt_fab_rec.Name = "txt_fab_rec";
            this.txt_fab_rec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fab_rec.Size = new System.Drawing.Size(156, 20);
            this.txt_fab_rec.TabIndex = 17;
            // 
            // txt_nom_fab
            // 
            this.txt_nom_fab.Location = new System.Drawing.Point(23, 103);
            this.txt_nom_fab.Name = "txt_nom_fab";
            this.txt_nom_fab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nom_fab.Size = new System.Drawing.Size(156, 20);
            this.txt_nom_fab.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Articulos Recibidos";
            // 
            // CP_NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 335);
            this.Controls.Add(this.txt_art_rec);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fab_rec);
            this.Controls.Add(this.txt_nom_fab);
            this.Controls.Add(this.label4);
            this.Name = "CP_NuevoArticulo";
            this.Text = "CP_NuevoArticulo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CP_NuevoArticulo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_art_rec;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fab_rec;
        private System.Windows.Forms.TextBox txt_nom_fab;
        private System.Windows.Forms.Label label4;
    }
}