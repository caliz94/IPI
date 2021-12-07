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
using System.Data.SqlClient;

namespace CP_Presentacion.Form_Ventas
{
    public partial class CP_NuevaVenta : Form
    {
       
        CL_Ventas OVentas = new CL_Ventas();
        //int idcliente = 0, idventa = 0, iddireccion = 0;
        byte Activo;

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

        #region CargarComboProducto
        private void CargarComboProducto()
        {
            cboxNombreProducto.DataSource = OVentas.CargarComboProductos();
            cboxNombreProducto.DisplayMember = "NombreArticulo";
            cboxNombreProducto.SelectedIndex = -1;
            cboxNombreProducto.ValueMember = "IdArticulo";
        }
        #endregion

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
        private void ObtenerPrecioArticulos()
        {
            try
            {
                //int indice = Convert.ToInt32(cboxNombreProducto.SelectedValue.ToString());
                idarticulo = Convert.ToInt32(cboxNombreProducto.SelectedValue.ToString());
                tboxPrecio.Text = Convert.ToString(OVentas.ObtenerPrecioArticulos(idarticulo));

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Obtener la Existencias de los Articulos. Error: " + ex.Message);
            }
        }
        #endregion

        private static CP_NuevaVenta _Abrir;

        public static CP_NuevaVenta Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_NuevaVenta();
                return _Abrir;
            }
        }

        private void CP_NuevaVenta_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
            CargarComboProducto();
        }

        
        private void CP_NuevaVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void cboxNombreProducto_KeyUp(object sender, KeyEventArgs e)
        {
            ObtenerExistenciaArticulos();
            ObtenerPrecioArticulos();
        }

        private void cboxNombreProducto_DropDownClosed(object sender, EventArgs e)
        {
            ObtenerExistenciaArticulos();
            ObtenerPrecioArticulos();
        }

        private void btn_AgregarCarrito_Click(object sender, EventArgs e)
        {
            int buscar1 = 0, buscar2 = 0;
            

            string NombreCliente = cboxNombreCliente.Text.ToString();
            buscar1 = NombreCliente.IndexOf("- ");
            string NoArticulo = cboxNombreProducto.Text.ToString();
            string Descripcion = cboxNombreProducto.Text.ToString();
            buscar2 = Descripcion.IndexOf("- ");
            string Cantidad = numCantidad.Value.ToString();
            string PrecioUnitario = tboxPrecio.Text;
            string Total = Convert.ToString(Convert.ToInt32(Cantidad) * Convert.ToDouble(PrecioUnitario));
            string Fecha = DateTime.Now.ToString();

            dgvVentas.Rows.Add(new object[]
            {
                

                NombreCliente.Substring(buscar1+2),
                NoArticulo.Substring(0,buscar2),
                Descripcion.Substring(buscar2+2),
                Cantidad,
                PrecioUnitario,
                Total,
                Fecha,
                "Eliminar"
            });

            //idcliente = Convert.ToInt32(NombreCliente.Substring(0, buscar1));
            //iddireccion = 1;
            Activo = 1;

            //cboxNombreCliente.SelectedIndex = -1;
            cboxNombreProducto.SelectedIndex = -1;
            numCantidad.Value = 0;
            tboxPrecio.Text = string.Empty;
            cboxNombreProducto.Focus();
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            foreach (var item in dgvVentas.Rows)
            {
                //OVentas.GuardarVenta(idcliente, iddireccion, Activo);
                MessageBox.Show("Venta Grabada exitosamente.");
            }
            
        }
    }
}
