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

namespace CP_Presentacion.Form_Cliente
{
    public partial class CP_MostrarClientes : Form
    {
        public CP_MostrarClientes()
        {
            InitializeComponent();
        }

        private static CP_MostrarClientes _Abrir;

        public static CP_MostrarClientes Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_MostrarClientes();
                return _Abrir;
            }
        }

        private void CP_MostrarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
        private CL_Clientes clientes_cl = new CL_Clientes();
        //clientes activos
        private void btn_actico_Click(object sender, EventArgs e)
        {
            label_grid.Text = "Clientes Activos";
            dgv_mostar_clientes.DataSource = clientes_cl.clientes_activos();
        }

        //clientes inactivos
        private void btn_inactivo_Click(object sender, EventArgs e)
        {
            label_grid.Text = "Clientes Inactivos";
            dgv_mostar_clientes.DataSource = clientes_cl.clientes_inactivos();
        }
        //clientes activos
        private void btn_todos_Click(object sender, EventArgs e)
        {
            label_grid.Text = "Clientes Activos e Inactivos";
            dgv_mostar_clientes.DataSource = clientes_cl.mostrarclientes();
        }
    }
}
