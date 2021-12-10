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
    public partial class CP_NuevoCliente : Form
    {
        public CP_NuevoCliente()
        {
            InitializeComponent();
        }

        private static CP_NuevoCliente _Abrir;

        public static CP_NuevoCliente Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_NuevoCliente();
                return _Abrir;
            }          	
        }

        private void CP_NuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        CL_Clientes nuevo_cliente_cl = new CL_Clientes();

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cliente.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_cliente, "CAMPO OBLIGATORIO");
                }
                else if (txt_Saldo.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_Saldo, "CAMPO OBLIGATORIO");
                }
                else if (txt_LimiteCredito.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_LimiteCredito, "CAMPO OBLIGATORIO");
                }
                else if (txt_Descuento.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_Descuento, "CAMPO OBLIGATORIO");
                }
                else
                {
                    nuevo_cliente_cl.nuevo_cliente(txt_cliente.Text, txt_Saldo.Text, txt_LimiteCredito.Text, txt_Descuento.Text);
                    MessageBox.Show("EL CLIENTE \"" + txt_cliente.Text.ToUpper() + "\" FUE AGREGADO EXITOSAMENTE");
                    txt_cliente.Clear();
                    txt_Descuento.Clear();
                    txt_LimiteCredito.Clear();
                    txt_Saldo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCURRIO UN ERROR: " + ex.Message);                
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
