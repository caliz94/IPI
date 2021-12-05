using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Logica;

namespace CP_Presentacion.Form_Ventas
{
    public partial class CP_NuevaVenta : Form
    {
        CL_Ventas OVentas = new CL_Ventas();
        public CP_NuevaVenta()
        {
            InitializeComponent();
        }
        #region PROGRAMACIÓN MÉTODOS
        private void CargarComboCliente()
        {
            cboxNombreCliente.DataSource = OVentas.CargarComboClientes();
            cboxNombreCliente.DisplayMember = "NombreCliente";
            cboxNombreCliente.SelectedIndex = -1;
            cboxNombreCliente.ValueMember = "IdCliente";
        }
        
        private void CargarComboProducto()
        {
            cboxNombreProducto.DataSource = OVentas.CargarComboProductos();
            cboxNombreProducto.DisplayMember = "NombreArticulo";
            cboxNombreProducto.SelectedIndex = -1;
            cboxNombreProducto.ValueMember = "IdArticulo";
        }

        int idarticulo;
        private void ObtenerExistenciaArticulos()
        {
            try
            {
                //int indice = Convert.ToInt32(cboxNombreProducto.SelectedValue.ToString());
                idarticulo = Convert.ToInt32(cboxNombreProducto.SelectedValue.ToString());
                tboxExistencias.Text = Convert.ToString(OVentas.ObtenerExistenciaArticulos(idarticulo));

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Obtener la Existencias de los Articulos. Error: " + ex.Message);
            }
        }
        #endregion

        private void CP_NuevaVenta_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
            CargarComboProducto();
        }


        

        private void cboxNombreProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ObtenerExistenciaArticulos();
        }
    }
}
