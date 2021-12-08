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
    public partial class Actualizar_cliente : Form
    {
        public Actualizar_cliente()
        {
            InitializeComponent();
        }

        #region Metodo Singlenton
        private static Actualizar_cliente _Abrir;

        public static Actualizar_cliente Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new Actualizar_cliente();
                return _Abrir;
            }
        }

        private void Actualizar_cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }


        #endregion

        CL_Clientes clientes_cl = new CL_Clientes();

        private void actualizar()
        {
            clientes_cl.act_cliente(Convert.ToInt32(txt_idcliente.Text),txt_nombrecliente.Text,txt_Saldo.Text,txt_LimiteCredito.Text,txt_Descuento.Text,Convert.ToByte(chk_Estado.Tag));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (chk_Estado.CheckState == CheckState.Checked)
            {
                chk_Estado.Tag = "1";
            }
            else
            {
                chk_Estado.Tag = "0";
            }

            if (txt_idcliente.Text==string.Empty)
            {
                errorProvider1.SetError(txt_idcliente,"Selecione un clinte del DataGrid");
            }
            else if (txt_nombrecliente.Text==string.Empty)
            {
                errorProvider1.SetError(txt_idcliente, "");
                errorProvider1.SetError(txt_nombrecliente, "CAMPO OBLIGATORIO");
            }
            else if (txt_Saldo.Text == string.Empty)
            {
          
                errorProvider1.SetError(txt_Saldo, "CAMPO OBLIGATORIO");
                errorProvider1.SetError(txt_nombrecliente, "");
            }
            else if (txt_LimiteCredito.Text == string.Empty)
            {
                errorProvider1.SetError(txt_LimiteCredito, "CAMPO OBLIGATORIO");
                errorProvider1.SetError(txt_Saldo, "");
               
            }
            else if (txt_Descuento.Text == string.Empty)
            {
                errorProvider1.SetError(txt_LimiteCredito, "");
                errorProvider1.SetError(txt_Descuento, "CAMPO OBLIGATORIO");
            }
            else
            {
                errorProvider1.SetError(txt_Descuento, "");
                actualizar();              
                MessageBox.Show("el cliente ha sido actualizado exitosamente");

                txt_Descuento.Clear();
                txt_idcliente.Clear();
                txt_LimiteCredito.Clear();
                txt_nombrecliente.Clear();
                txt_Saldo.Clear();
                grid();
                dgv_mostar_clientes.Columns["Activo"].Visible = false;

                txt_nombrecliente.Enabled = false;
                txt_Saldo.Enabled = false;
                txt_LimiteCredito.Enabled = false;
                txt_Descuento.Enabled = false;
                iconButton1.Enabled = false;
                chk_Estado.Enabled = false;

            }

        }

        public void grid()
        {
           dgv_mostar_clientes.DataSource = clientes_cl.clientes_activos();
        }
        private void Actualizar_cliente_Load(object sender, EventArgs e)
        {
            chk_Estado.Checked = true;
            grid();
            dgv_mostar_clientes.Columns["Activo"].Visible = false;
        }

        private void dgv_mostar_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idcliente.Text = dgv_mostar_clientes.CurrentRow.Cells["IdCliente"].Value.ToString();
            txt_nombrecliente.Enabled = true;
            txt_Saldo.Enabled = true;
            txt_LimiteCredito.Enabled = true;
            txt_Descuento.Enabled = true;
            chk_Estado.Enabled = true;
            iconButton1.Enabled = true;

            //cargar campos en los textbox

            txt_nombrecliente.Text = dgv_mostar_clientes.CurrentRow.Cells["NombreCliente"].Value.ToString();
            txt_Saldo.Text= dgv_mostar_clientes.CurrentRow.Cells["Saldo"].Value.ToString();
            txt_LimiteCredito.Text= dgv_mostar_clientes.CurrentRow.Cells["LimiteCredito"].Value.ToString();
            txt_Descuento.Text = dgv_mostar_clientes.CurrentRow.Cells["Descuento"].Value.ToString();           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
