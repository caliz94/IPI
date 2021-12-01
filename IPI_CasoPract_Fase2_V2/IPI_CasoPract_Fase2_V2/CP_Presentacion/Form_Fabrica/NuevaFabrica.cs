using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Presentacion.Form_Fabrica
{
    public partial class NuevaFabrica : Form
    {
        public NuevaFabrica()
        {
            InitializeComponent();
        }
        private static NuevaFabrica _Abrir;
        public static NuevaFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new NuevaFabrica();
                return _Abrir;
            }
        }


        private void NuevaFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
