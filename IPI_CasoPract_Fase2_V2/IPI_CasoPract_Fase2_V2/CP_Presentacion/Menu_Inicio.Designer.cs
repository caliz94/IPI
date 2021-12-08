
namespace CP_Presentacion
{
    partial class Menu_Inicio
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
            this.pnl_cont = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.nuevoClienteToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.actualizarCliienteToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.mostrarClientesToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.adminDireccionesToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.administrarArticulosToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.administrarProvedoresToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.agregarProvedorToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.eliminarProveedorToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.actualizarProveedorToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.mostrarProveedoresToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.ventasToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.pnl_inf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.pnl_inf.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cont
            // 
            this.pnl_cont.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cont.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnl_cont.Location = new System.Drawing.Point(240, 34);
            this.pnl_cont.Name = "pnl_cont";
            this.pnl_cont.Size = new System.Drawing.Size(914, 681);
            this.pnl_cont.TabIndex = 5;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_Cerrar.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cerrar.IconSize = 35;
            this.btn_Cerrar.Location = new System.Drawing.Point(9, 656);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(31, 31);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btn_Cerrar, "Salir Del Programa");
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 0, 2, 250);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.administrarArticulosToolStripMenuItem,
            this.administrarProvedoresToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(9, 234);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(216, 267);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.actualizarCliienteToolStripMenuItem,
            this.mostrarClientesToolStripMenuItem,
            this.adminDireccionesToolStripMenuItem});
            this.iconMenuItem1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 60;
            this.iconMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(209, 64);
            this.iconMenuItem1.Text = "Administrar Clientes         ";
            this.iconMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.AutoSize = false;
            this.nuevoClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nuevoClienteToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nuevoClienteToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.nuevoClienteToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.nuevoClienteToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nuevoClienteToolStripMenuItem.IconSize = 60;
            this.nuevoClienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoClienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(221, 66);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoClienteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // actualizarCliienteToolStripMenuItem
            // 
            this.actualizarCliienteToolStripMenuItem.AutoSize = false;
            this.actualizarCliienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.actualizarCliienteToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.actualizarCliienteToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.actualizarCliienteToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.actualizarCliienteToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizarCliienteToolStripMenuItem.IconSize = 60;
            this.actualizarCliienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarCliienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizarCliienteToolStripMenuItem.Name = "actualizarCliienteToolStripMenuItem";
            this.actualizarCliienteToolStripMenuItem.Size = new System.Drawing.Size(221, 66);
            this.actualizarCliienteToolStripMenuItem.Text = "Actualizar Cliientes";
            this.actualizarCliienteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actualizarCliienteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.actualizarCliienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarCliienteToolStripMenuItem_Click);
            // 
            // mostrarClientesToolStripMenuItem
            // 
            this.mostrarClientesToolStripMenuItem.AutoSize = false;
            this.mostrarClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mostrarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mostrarClientesToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.mostrarClientesToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.mostrarClientesToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mostrarClientesToolStripMenuItem.IconSize = 60;
            this.mostrarClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrarClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mostrarClientesToolStripMenuItem.Name = "mostrarClientesToolStripMenuItem";
            this.mostrarClientesToolStripMenuItem.Size = new System.Drawing.Size(221, 66);
            this.mostrarClientesToolStripMenuItem.Text = "Mostrar Clientes";
            this.mostrarClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mostrarClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.mostrarClientesToolStripMenuItem.Click += new System.EventHandler(this.mostrarClientesToolStripMenuItem_Click);
            // 
            // adminDireccionesToolStripMenuItem
            // 
            this.adminDireccionesToolStripMenuItem.AutoSize = false;
            this.adminDireccionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminDireccionesToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.adminDireccionesToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Safari;
            this.adminDireccionesToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.adminDireccionesToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminDireccionesToolStripMenuItem.IconSize = 60;
            this.adminDireccionesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminDireccionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminDireccionesToolStripMenuItem.Name = "adminDireccionesToolStripMenuItem";
            this.adminDireccionesToolStripMenuItem.Size = new System.Drawing.Size(221, 66);
            this.adminDireccionesToolStripMenuItem.Text = "Admin. Direcciones";
            this.adminDireccionesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminDireccionesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.adminDireccionesToolStripMenuItem.Click += new System.EventHandler(this.adminDireccionesToolStripMenuItem_Click);
            // 
            // administrarArticulosToolStripMenuItem
            // 
            this.administrarArticulosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.administrarArticulosToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.administrarArticulosToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.administrarArticulosToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.administrarArticulosToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.administrarArticulosToolStripMenuItem.IconSize = 60;
            this.administrarArticulosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administrarArticulosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administrarArticulosToolStripMenuItem.Name = "administrarArticulosToolStripMenuItem";
            this.administrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(209, 64);
            this.administrarArticulosToolStripMenuItem.Text = "Administrar Articulos";
            this.administrarArticulosToolStripMenuItem.Click += new System.EventHandler(this.administrarArticulosToolStripMenuItem_Click);
            // 
            // administrarProvedoresToolStripMenuItem
            // 
            this.administrarProvedoresToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.administrarProvedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProvedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem,
            this.actualizarProveedorToolStripMenuItem,
            this.mostrarProveedoresToolStripMenuItem});
            this.administrarProvedoresToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.administrarProvedoresToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.administrarProvedoresToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.administrarProvedoresToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.administrarProvedoresToolStripMenuItem.IconSize = 60;
            this.administrarProvedoresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administrarProvedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administrarProvedoresToolStripMenuItem.Name = "administrarProvedoresToolStripMenuItem";
            this.administrarProvedoresToolStripMenuItem.Size = new System.Drawing.Size(209, 64);
            this.administrarProvedoresToolStripMenuItem.Text = "Administrar Provedores";
            // 
            // agregarProvedorToolStripMenuItem
            // 
            this.agregarProvedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agregarProvedorToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.agregarProvedorToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.agregarProvedorToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.agregarProvedorToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarProvedorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProvedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.agregarProvedorToolStripMenuItem.Name = "agregarProvedorToolStripMenuItem";
            this.agregarProvedorToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.agregarProvedorToolStripMenuItem.Text = "Agregar Proveedor";
            this.agregarProvedorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProvedorToolStripMenuItem.Click += new System.EventHandler(this.agregarProvedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.eliminarProveedorToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.eliminarProveedorToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.eliminarProveedorToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarProveedorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProveedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminar Proveedor";
            this.eliminarProveedorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // actualizarProveedorToolStripMenuItem
            // 
            this.actualizarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.actualizarProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.actualizarProveedorToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Algolia;
            this.actualizarProveedorToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.actualizarProveedorToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizarProveedorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarProveedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizarProveedorToolStripMenuItem.Name = "actualizarProveedorToolStripMenuItem";
            this.actualizarProveedorToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.actualizarProveedorToolStripMenuItem.Text = "Actualizar Proveedor";
            this.actualizarProveedorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarProveedorToolStripMenuItem.Click += new System.EventHandler(this.actualizarProveedorToolStripMenuItem_Click);
            // 
            // mostrarProveedoresToolStripMenuItem
            // 
            this.mostrarProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mostrarProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mostrarProveedoresToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Algolia;
            this.mostrarProveedoresToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.mostrarProveedoresToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mostrarProveedoresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrarProveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mostrarProveedoresToolStripMenuItem.Name = "mostrarProveedoresToolStripMenuItem";
            this.mostrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.mostrarProveedoresToolStripMenuItem.Text = "Mostrar Proveedores";
            this.mostrarProveedoresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.mostrarProveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ventasToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.ventasToolStripMenuItem.IconColor = System.Drawing.Color.RoyalBlue;
            this.ventasToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ventasToolStripMenuItem.IconSize = 60;
            this.ventasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(209, 64);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // pnl_inf
            // 
            this.pnl_inf.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_inf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_inf.Controls.Add(this.label1);
            this.pnl_inf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_inf.Location = new System.Drawing.Point(0, 715);
            this.pnl_inf.Name = "pnl_inf";
            this.pnl_inf.Size = new System.Drawing.Size(1154, 34);
            this.pnl_inf.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elaborado por Alex Martinez y Danny Caliz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 34);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 681);
            this.panel2.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Crimson;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Linux;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 200;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(12, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 185);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
           
            // 
            // Menu_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1154, 749);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_cont);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_inf);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Inicio";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_inf.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cont;
        private System.Windows.Forms.Panel pnl_inf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem nuevoClienteToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem actualizarCliienteToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem mostrarClientesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem adminDireccionesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem administrarArticulosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem administrarProvedoresToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconMenuItem agregarProvedorToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem actualizarProveedorToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem eliminarProveedorToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem mostrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}