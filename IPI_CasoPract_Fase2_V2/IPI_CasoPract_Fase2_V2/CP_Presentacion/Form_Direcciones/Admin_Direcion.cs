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
        //private void MostrarDireciones()
        //{
        //    dgv_direciones.DataSource = Direcciones_cl.DirecionesCliente(Convert.ToInt32(txt_NumeroCliente.Text));        
        //}

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_numero_direccion.Text == string.Empty)
            {
                errorProvider1.SetError(txt_numero_direccion,"Con doble clik selecione la direccion que desea actualizar");
            }

            cargar_direc();
        }

        private SqlConnection cadena = new SqlConnection("server=.;database=IPICASOPRACTICO;integrated security= true");

        public SqlConnection abrircadena()
        {
            if (cadena.State == ConnectionState.Closed)

                cadena.Open();
            return cadena;

        }

        public SqlConnection cerrarcadena()
        {
            if (cadena.State == ConnectionState.Open)

                cadena.Close();
            return cadena;
        }
        private void cargar_direc()
        {
            DataTable tabla = new DataTable();
            string sql = "select IdDireccion,Calle,Barrio,Distrito from Direcciones where IdCliente=@idcliente and  Activo = 1";
            SqlCommand cmd = new SqlCommand(sql, cadena);
            cmd.Parameters.AddWithValue("@idcliente", txt_NumeroCliente.Text);
            SqlDataReader leer;
            abrircadena();
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            cerrarcadena();
            dgv_direciones.DataSource = tabla;

        }

        private void Admin_Direcion_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

     

        private void nuevadireci()
        {
            Direcciones_cl.nueva_direccion(Convert.ToInt32(txt_NumeroCliente.Text), txt_Calle.Text, txt_Barrio.Text, txt_Distrito.Text);
        }

        private void actualizar()
        {
            Direcciones_cl.actualizar_direc(Convert.ToInt32(txt_numero_direccion.Text), txt_Calle.Text, txt_Barrio.Text, txt_Distrito.Text);
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

            if (txt_numero_direccion.Text == string.Empty )
            {

                if (txt_NumeroCliente.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_NumeroCliente, "Selcionar Cliente Con Doble clik");
                }
                else
                {
                    dgv_clientes.Enabled = true;
                    btn_editar.Enabled = false;
                    
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
            else
            {
                actualizar();
                MessageBox.Show("cambios realizados");
            }




        }

        private void Admin_Direcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void dgv_direciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_numero_direccion.Text = dgv_direciones.CurrentRow.Cells["IdDireccion"].Value.ToString();
            txt_Calle.Text = dgv_direciones.CurrentRow.Cells["Calle"].Value.ToString();
            txt_Barrio.Text = dgv_direciones.CurrentRow.Cells["Barrio"].Value.ToString();
            txt_Distrito.Text = dgv_direciones.CurrentRow.Cells["Distrito"].Value.ToString();
            errorProvider1.SetError(txt_Distrito, "");

            txt_Calle.Enabled = true;
            txt_Barrio.Enabled = true;
            txt_Distrito.Enabled = true;

            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;

        }

        private void dgv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_NuevDire.Enabled = true;
            btn_editar.Enabled = true;
            

            txt_NumeroCliente.Text = dgv_clientes.CurrentRow.Cells["IdCliente"].Value.ToString();
            txt_nombre_cliente.Text = dgv_clientes.CurrentRow.Cells["NombreCliente"].Value.ToString();
            
        }
    }
}
