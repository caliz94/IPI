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
        //Variables de Control de Estado para paneles
        bool stateclient = false;
        bool stateArticle = false;
        bool stateProvider = false;


        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_NuevoCliente abrirform = Form_Cliente.CP_NuevoCliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
           
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_act_cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente.Actualizar_cliente abrirform = Form_Cliente.Actualizar_cliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
           
          
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_elimin_cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_Elim_Client abrirform = Form_Cliente.CP_Elim_Client.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
          
      
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
        }

        

        private void Menu_Inicio_Load(object sender, EventArgs e)
        {
            pnl_fun_btn_client.Visible = false;
            pnl_fun_btn_Provider.Visible = false;
            pnl_fun_btn_Article.Visible = false;
        }

        #region Visualización de Sub-Menus
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (stateProvider == false)
            {
                pnl_fun_btn_Provider.Visible = true;
                stateProvider = true;
                pnl_fun_btn_Article.Visible = false;
                stateArticle = false;
                pnl_fun_btn_client.Visible = false;
                stateclient = false;
            }
            else
            {
                pnl_fun_btn_Provider.Visible = false;
                stateProvider = false;
            }
        }

        private void btnAdministrarArticulos_Click(object sender, EventArgs e)
        {
            if (stateArticle == false)
            {
                pnl_fun_btn_Article.Visible = true;
                stateArticle = true;
                pnl_fun_btn_client.Visible = false;
                stateclient = false;
                pnl_fun_btn_Provider.Visible = false;
                stateProvider = false;
            }
            else
            {
                pnl_fun_btn_Article.Visible = false;
                stateArticle = false;
            }
        }

        private void btn_AministrarClientes_Click(object sender, EventArgs e)
        {
            if (stateclient == false)
            {
                pnl_fun_btn_client.Visible = true;
                stateclient = true;
                pnl_fun_btn_Article.Visible = false;
                stateArticle = false;
                pnl_fun_btn_Provider.Visible = false;
                stateProvider = false;
            }
            else
            {
                pnl_fun_btn_client.Visible = false;
                stateclient = false;
            }
        }
        #endregion

        private void btnMostrarFabrica_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_MostrarFabrica abrirform = Form_Fabrica.CP_MostrarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);


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
        }

        private void btn_actu_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_ActualizarArticulo abrirform = Form_Articulos.CP_ActualizarArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_elim_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_EliminarArticulo abrirform = Form_Articulos.CP_EliminarArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_mostr_Articulo_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_MostrarArticulos abrirform = Form_Articulos.CP_MostrarArticulos.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void btn_nuev_prov_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_NuevaFabrica abrirform = Form_Fabrica.CP_NuevaFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }
    }
}
