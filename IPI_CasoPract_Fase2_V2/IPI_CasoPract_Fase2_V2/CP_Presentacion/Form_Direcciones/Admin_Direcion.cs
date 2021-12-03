using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void CP_NuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
        private void Admin_Direcion_Load(object sender, EventArgs e)
        {

        }
    }
}
