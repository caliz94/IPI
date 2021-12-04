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

        CL_Articulos articulos_cl = new CL_Articulos();

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //    articulos_cl.NuevoArticulo(txt_desc.Text,t);
        }
    }
}
