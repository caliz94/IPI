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

namespace CP_Presentacion.Form_Direcciones
{
    public partial class Admin_Direcion : Form
    {
        public Admin_Direcion()
        {
            InitializeComponent();
        }

        private static Admin_Direcion _Abrir;

        public static Admin_Direcion Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new Admin_Direcion();
                return _Abrir;
            }
        }

     

        CL_Direcciones Direcciones_cl = new CL_Direcciones();
        private void MostrarClientes()
        {
            dgv_clientes.DataSource = Direcciones_cl.clientes_activos();
        }
        private void MostrarDireciones()
        {
            dgv_direciones.DataSource = Direcciones_cl.DirecionesCliente(Convert.ToInt32(txt_NumeroCliente.Text));
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            MostrarDireciones();
        }
        private void Admin_Direcion_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void dgv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_NuevDire.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;

            txt_NumeroCliente.Text = dgv_clientes.CurrentRow.Cells["IdCliente"].Value.ToString();
            txt_nombre_cliente.Text = dgv_clientes.CurrentRow.Cells["NombreCliente"].Value.ToString();
            txt_Calle.Enabled = true;
            txt_Barrio.Enabled = true;
            txt_Distrito.Enabled = true;
        }

        private void nuevadireci()
        {
            Direcciones_cl.nueva_direccion(Convert.ToInt32(txt_NumeroCliente.Text), txt_Calle.Text, txt_Barrio.Text, txt_Distrito.Text);
        }

        private void btn_NuevDire_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Calle.Enabled = true;
                txt_Barrio.Enabled = true;
                txt_Distrito.Enabled = true;

                btn_cancelar.Enabled = true;
                btn_guardar.Enabled = true;               
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_NumeroCliente.Text == string.Empty)
            {
                errorProvider1.SetError(txt_NumeroCliente, "Selcionar Cliente Con Doble clik");
            }
            else
            {
                dgv_clientes.Enabled = true;
                btn_editar.Enabled = false;
                btn_eliminar.Enabled = false;
            }
            if (txt_Calle.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Calle, "Campo Obligatorio");
            }
            else if (txt_Barrio.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Barrio, "Campo Obligatorio");
            }
            else if (txt_Distrito.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Distrito, "Campo Obligatorio");
            }

            else
            {
                nuevadireci();
                MessageBox.Show("Se Agrego Nueva Direccion Al Cliente " + txt_NumeroCliente.Text, txt_nombre_cliente.Text);
            }
        }

        private void Admin_Direcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

      
    }
}
