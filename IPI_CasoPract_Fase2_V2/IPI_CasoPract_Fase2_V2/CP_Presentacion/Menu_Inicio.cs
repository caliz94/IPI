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
        bool stateVentas = false;

        #region Visualización de Sub-Menus
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (stateProvider == false)
            {
                stateProvider = true;
                stateArticle = false;
                stateclient = false;
                stateVentas = false;
            }
            else
            {               
                stateProvider = false;
            }
        }
        private void btnAdministrarArticulos_Click(object sender, EventArgs e)
        {
            if (stateArticle == false)
            {
                stateclient = false;
                stateArticle = true;
                stateProvider = false;
                stateVentas = false;
            }
            else
            {         
                stateArticle = false;           
            }
        }

        private void btn_AministrarClientes_Click(object sender, EventArgs e)
        {
            if (stateclient == false)
            {            
                stateProvider = false;
                stateArticle = false;
                stateclient = true;
                stateVentas = false;               
            }
            else
            {          
                stateclient = false;                             
            }
        }
        #endregion
     
        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            if (stateVentas == false)
            {                
                stateVentas = true;
                stateArticle = false;
                stateclient = false;
                stateProvider = false;
            }
            else
            {
                stateVentas = false;               
            }
        }
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_NuevoCliente abrirform = Form_Cliente.CP_NuevoCliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            //this.pnl_izq.Size = new System.Drawing.Size(158, 551);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente.CP_MostrarClientes abrirform = Form_Cliente.CP_MostrarClientes.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void actualizarCliienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente.Actualizar_cliente abrirform = Form_Cliente.Actualizar_cliente.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void adminDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Direcciones.Admin_Direcion abrirform = Form_Direcciones.Admin_Direcion.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void agregarProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_NuevaFabrica abrirform = Form_Fabrica.CP_NuevaFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void actualizarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_ActualizarFabrica abrirform = Form_Fabrica.CP_ActualizarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);

            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_EliminarFabrica abrirform = Form_Fabrica.CP_EliminarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fabrica.CP_MostrarFabrica abrirform = Form_Fabrica.CP_MostrarFabrica.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            abrirform.StartPosition = FormStartPosition.CenterScreen;
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void administrarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Articulos.CP_NuevoArticulo abrirform = Form_Articulos.CP_NuevoArticulo.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas.CP_NuevaVenta abrirform = Form_Ventas.CP_NuevaVenta.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }

        private void mostarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas.CP_Ver_Ventas abrirform = Form_Ventas.CP_Ver_Ventas.Abrir;
            abrirform.TopLevel = false;
            this.pnl_cont.Controls.Add(abrirform);
            this.pnl_cont.Tag = abrirform;
            abrirform.Show();
        }
    }
}
