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
    public partial class CP_ActualizarArticulo : Form
    {
        public CP_ActualizarArticulo()
        {
            InitializeComponent();
        }
        private static CP_ActualizarArticulo _Abrir;
        public static CP_ActualizarArticulo Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_ActualizarArticulo();
                return _Abrir;
            }
        }

      

        private void CP_ActualizarArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
