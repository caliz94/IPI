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
    }
}
