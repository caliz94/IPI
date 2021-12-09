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
            MostrartodosPedido();
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
            dgv_DetallePedido.DataSource = ventas_cl.OptenerDetallePedido(Convert.ToInt32(txt_pedido.Text));
        }
        private void btn_filtar_pedido_Click(object sender, EventArgs e)
        {
            MostrarPedido();            
        }

        private void dgv_pedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_pedido.Text = dgv_pedido.CurrentRow.Cells["IdPedido"].Value.ToString();
            MostrarDetallePedido();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MostrartodosPedido();
        }
    }
}
