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

            actualizar();

        }

    }
}
