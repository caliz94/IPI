using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Logica;

namespace CP_Presentacion.Form_Ventas
{
    public partial class CP_Ver_Ventas : Form
    {
        public CP_Ver_Ventas()
        {
            InitializeComponent();
        }

        #region IMPLEMENTACIÓN SINGLENTON
        private static CP_Ver_Ventas _Abrir;
        public static CP_Ver_Ventas Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_Ver_Ventas();
                return _Abrir;
            }
        }
        private void CP_Ver_Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
        #endregion
        private void CP_Ver_Ventas_Load(object sender, EventArgs e)
        {
            DatosGraf();
            MostrartodosPedido();
            DatosGraf_Articulos();
        }


        CL_Ventas ventas_cl = new CL_Ventas();
        private void MostrarPedido()
        {
            dgv_pedido.DataSource = ventas_cl.optenerPedido(Convert.ToInt32(txt_pedido.Text));
        }

        private void MostrartodosPedido()
        {
            dgv_pedido.DataSource = ventas_cl.OptenertodosPedido();
        }
        private void MostrarDetallePedido()
        {
            try
            {
                dgv_DetallePedido.DataSource = ventas_cl.OptenerDetallePedido(Convert.ToInt32(txt_pedido.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("TIENE QUE SELECIONAR UN PEDIDO PARA CARGAR EL DETALLE DEL PEDIDO");
            }
            
        }
        private void btn_filtar_pedido_Click(object sender, EventArgs e)
        {
            MostrarPedido();            
        }

        private void dgv_pedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pedido.SelectedRows.Count > 0)
            {
                txt_pedido.Text = dgv_pedido.CurrentRow.Cells["IdPedido"].Value.ToString();
                MostrarDetallePedido();
            }
            else
            {
                MessageBox.Show("TIENE QUE SELECIONAR UN PEDIDO PARA CARGAR EL DETALLE DEL PEDIDO");
            }
               
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MostrartodosPedido();
        }

        private SqlConnection conexion = new SqlConnection
            ("server=.;database=IPICASOPRACTICO;integrated security=true");

        public SqlConnection abrirconexion()
        {
            if (conexion.State == ConnectionState.Closed)

                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarrconexion()
        {
            if (conexion.State == ConnectionState.Open)

                conexion.Close();
            return conexion;
        }

        ArrayList Cliente = new ArrayList();
        ArrayList Compras = new ArrayList();

        private void DatosGraf()
        {
            string sql = "select top 5  c.NombreCliente,SUM(d.Cantidad * a.PrecioUnitario)as sub_total from cliente as c inner join Pedido as p on c.IdCliente = p.IdCliente inner join Detalle_Pedido as d on d.IdPedido = p.IdPedido inner join Articulo as a on d.IdArticulo = a.IdArticulo group by c.NombreCliente ORDER BY sub_total DESC";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataReader leer;
            abrirconexion();
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                Cliente.Add(leer.GetString(0));
               Compras.Add(leer.GetDecimal(1));
            }
            chart1.Series[0].Points.DataBindXY(Cliente,Compras);
            leer.Close();
            cerrarrconexion();                    
        }

        ArrayList articulo = new ArrayList();
        ArrayList cantidad = new ArrayList();
        private void DatosGraf_Articulos()
        {
            string sql = "select top 5  a.Descripción_Articulo,count(d.Cantidad)as sub_total from cliente as c inner join Pedido as p on c.IdCliente = p.IdCliente inner join Detalle_Pedido as d on d.IdPedido = p.IdPedido inner join Articulo as a on d.IdArticulo = a.IdArticulo group by a.Descripción_Articulo ORDER BY sub_total DESC";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataReader leer2;
            abrirconexion();
            leer2 = cmd.ExecuteReader();
            while (leer2.Read())
            {
                articulo.Add(leer2.GetString(0));
                cantidad.Add(leer2.GetInt32(1));
            }
            chart3.Series[0].Points.DataBindXY(articulo, cantidad);
            leer2.Close();
            cerrarrconexion();
        }
    }
}