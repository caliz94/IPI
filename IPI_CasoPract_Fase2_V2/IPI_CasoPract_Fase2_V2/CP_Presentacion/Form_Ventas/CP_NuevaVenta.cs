﻿using System;
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
        int idcliente = 0, idventa = 0, iddireccion = 0;
        byte Activo;

        public CP_NuevaVenta()
        {
            InitializeComponent();
        }

        #region CARGAR COMBO CLIENTE
        private void CargarComboCliente()
        {
            cboxNombreCliente.DataSource = OVentas.CargarComboClientes();
            cboxNombreCliente.DisplayMember = "NombreCliente";
            cboxNombreCliente.SelectedIndex = -1;
            cboxNombreCliente.ValueMember = "IdCliente";
        }
        #endregion

        #region CARGAR COMPRO PRODUCTO
        private void CargarComboProducto()
        {
            cboxNombreProducto.DataSource = OVentas.CargarComboProductos();
            cboxNombreProducto.DisplayMember = "NombreArticulo";
            cboxNombreProducto.SelectedIndex = -1;
            cboxNombreProducto.ValueMember = "IdArticulo";
        }
        #endregion

        #region CARGAR COMBO DIRECCIONES
        private void CargarComboDirecciones()
        {
            cboxDirecciones.DataSource = OVentas.CargarComboDirecciones(Convert.ToInt32(cboxNombreCliente.SelectedValue.ToString()));
            cboxDirecciones.DisplayMember = "Dirección";
            cboxDirecciones.SelectedIndex = -1;
            cboxDirecciones.ValueMember = "IdCliente";
        }
        #endregion

        #region OBTENER EXISTENCIAS DE PRODUCTOS
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

        #region OBTENER PRECIOS DE ARTICULOS
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

        #region IMPLEMENTACIÓN SINGLENTON
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

        private void CP_NuevaVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
        #endregion

        #region METODO LOAD FORMULARIO
        private void CP_NuevaVenta_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
            CargarComboProducto();
        }
        #endregion

        #region METODO DROPDOWN COMBO NOMBRE CLIENTE Y NOMBRE PRODUCTO
        private void cboxNombreProducto_DropDownClosed(object sender, EventArgs e)
        {
            ObtenerExistenciaArticulos();
            ObtenerPrecioArticulos();
        }

        private void cboxNombreCliente_DropDownClosed(object sender, EventArgs e)
        {
            CargarComboDirecciones();
        }
        #endregion

        #region PROGRAMACIÓN BOTON LATERAL SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PROGRAMACIÓN AGREGAR AL CARRITO
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

            idcliente = Convert.ToInt32(NombreCliente.Substring(0, buscar1));
            iddireccion = 1;
            Activo = 1;

            //cboxNombreCliente.SelectedIndex = -1;
            cboxNombreProducto.SelectedIndex = -1;
            numCantidad.Value = 0;
            tboxPrecio.Text = string.Empty;
            cboxNombreProducto.Focus();
        }
        #endregion

        #region BOTON GENERAR VENTAS
        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            foreach (var item in dgvVentas.Rows)
            {
                OVentas.GuardarVenta(idcliente, iddireccion, Activo);
                MessageBox.Show("Venta Grabada exitosamente.");
            }
        }
        #endregion
    }
}
