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
    public partial class CP_Elim_Client : Form
    {
        public CP_Elim_Client()
        {
            InitializeComponent();
        }

        private static CP_Elim_Client _Abrir;

        public static CP_Elim_Client Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_Elim_Client();
                return _Abrir;
            }
        }

      

        private void CP_Elim_Client_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
