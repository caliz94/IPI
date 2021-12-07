using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Presentacion
{
    public partial class Menu_Inicio : Form
    {
        public Menu_Inicio()
        {
            InitializeComponent();
        }

        private void Menu_Inicio_Load(object sender, EventArgs e)
        {
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            pnl_fun_btn_client.Visible = false;
            pnl_fun_btn_Provedor.Visible = false;
            pnl_fun_btn_Artic.Visible = false;
            pnl_venta.Visible = false;
        }

        //Variables de Control de Estado para paneles
        bool stateclient = false;
        bool stateArticle = false;
        bool stateProvider = false;
        bool stateVentas = false;

        //botones del panel de cliente
        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_NuevoCliente abrirform = Form_Cliente.CP_NuevoCliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_act_cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente.Actualizar_cliente abrirform = Form_Cliente.Actualizar_cliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);


            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }



        private void btn_mostrar_clientes_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_MostrarClientes abrirform = Form_Cliente.CP_MostrarClientes.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            
            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        

      

        #region Visualización de Sub-Menus
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (stateProvider == false)
            {
                pnl_fun_btn_Provedor.Visible = true;
                pnl_fun_btn_client.Visible = false;
                pnl_fun_btn_Artic.Visible = false;
                pnl_venta.Visible = false;

                stateProvider = true;
                stateArticle = false;
                stateclient = false;
                stateVentas = false;

                //this.pnl_izq.Size = new System.Drawing.Size(353, 551);
            }
            else
            {               
                pnl_fun_btn_Provedor.Visible = false;
                stateProvider = false;

                //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            }
        }

        private void btnAdministrarArticulos_Click(object sender, EventArgs e)
        {
            if (stateArticle == false)
            {
                pnl_fun_btn_Artic.Visible = true;
                pnl_fun_btn_Provedor.Visible = false;
                pnl_venta.Visible = false;
                pnl_fun_btn_client.Visible = false;

                stateclient = false;
                stateArticle = true;
                stateProvider = false;
                stateVentas = false;
                               
                //this.pnl_izq.Size = new System.Drawing.Size(353, 551);
            }
            else
            {
                pnl_fun_btn_Artic.Visible = false;
                stateArticle = false;

                //this.pnl_izq.Size = new System.Drawing.Size(158, 551);              
            }
        }

        private void btn_AministrarClientes_Click(object sender, EventArgs e)
        {
            if (stateclient == false)
            {
                pnl_fun_btn_Provedor.Visible = false;
                pnl_fun_btn_client.Visible = true;
                pnl_fun_btn_Artic.Visible = false;
                pnl_venta.Visible = false;

                stateProvider = false;
                stateArticle = false;
                stateclient = true;
                stateVentas = false;

                //this.pnl_izq.Size = new System.Drawing.Size(353, 551);
            }
            else
            {
                pnl_fun_btn_client.Visible = false;
                stateclient = false;

                //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            }
        }
        #endregion

        private void btnMostrarFabrica_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_MostrarFabrica abrirform = Form_Fabrica.CP_MostrarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);


            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_nuev_artic_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_NuevoArticulo abrirform = Form_Articulos.CP_NuevoArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void btn_actu_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_ActualizarArticulo abrirform = Form_Articulos.CP_ActualizarArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void btn_elim_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_EliminarArticulo abrirform = Form_Articulos.CP_EliminarArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void btn_mostr_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_MostrarArticulos abrirform = Form_Articulos.CP_MostrarArticulos.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void btn_nuev_prov_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_NuevaFabrica abrirform = Form_Fabrica.CP_NuevaFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void bnt_elim_prov_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_EliminarFabrica abrirform = Form_Fabrica.CP_EliminarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Form_Direcciones.Admin_Direcion abrirform = Form_Direcciones.Admin_Direcion.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            
        }

        private void btn_act_pro_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_ActualizarFabrica abrirform = Form_Fabrica.CP_ActualizarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            if (stateVentas == false)
            {
                pnl_venta.Visible = true;
                pnl_fun_btn_Provedor.Visible = false;
                pnl_fun_btn_Artic.Visible = false;
                pnl_fun_btn_client.Visible = false;
                
                stateVentas = true;
                stateArticle = false;
                stateclient = false;
                stateProvider = false;
                            
                //this.pnl_izq.Size = new System.Drawing.Size(353, 551);
            }
            else
            {
                pnl_venta.Visible = false;
                stateVentas = false;

                //this.pnl_izq.Size = new System.Drawing.Size(158, 551);               
            }
        }

        private void btn_NuevaVenta_Click(object sender, EventArgs e)
        {
            Form_Ventas.CP_NuevaVenta abrirform = Form_Ventas.CP_NuevaVenta.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
        }
    }
}
