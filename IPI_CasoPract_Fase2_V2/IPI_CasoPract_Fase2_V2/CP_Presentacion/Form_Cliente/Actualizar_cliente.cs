using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

    }
}
