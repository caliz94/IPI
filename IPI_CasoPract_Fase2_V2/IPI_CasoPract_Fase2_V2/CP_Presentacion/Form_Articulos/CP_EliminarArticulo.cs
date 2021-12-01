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
    public partial class CP_EliminarArticulo : Form
    {
        public CP_EliminarArticulo()
        {
            InitializeComponent();
        }
        private static CP_EliminarArticulo _Abrir;
        public static CP_EliminarArticulo Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_EliminarArticulo();
                return _Abrir;
            }
        }

      
        private void CP_EliminarArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
