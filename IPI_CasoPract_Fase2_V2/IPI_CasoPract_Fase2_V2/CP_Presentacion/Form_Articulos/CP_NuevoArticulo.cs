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
    public partial class CP_NuevoArticulo : Form
    {
        public CP_NuevoArticulo()
        {
            InitializeComponent();
        }
        private static CP_NuevoArticulo _Abrir;
        public static CP_NuevoArticulo Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_NuevoArticulo();
                return _Abrir;
            }
        }

     
        private void CP_NuevoArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
