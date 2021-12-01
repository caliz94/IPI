using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Presentacion.Form_Articulos
{
    public partial class CP_MostrarArticulos : Form
    {
        public CP_MostrarArticulos()
        {
            InitializeComponent();
        }
        private static CP_MostrarArticulos _Abrir;
        public static CP_MostrarArticulos Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_MostrarArticulos();
                return _Abrir;
            }
        }

       
        private void CP_MostrarArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
