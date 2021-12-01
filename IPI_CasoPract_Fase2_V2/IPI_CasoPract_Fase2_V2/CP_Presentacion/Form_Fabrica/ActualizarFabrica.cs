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

namespace CP_Presentacion.Form_Fabrica
{
    public partial class ActualizarFabrica : Form
    {
        CL_Fabrica OFabrica = new CL_Fabrica();

        public ActualizarFabrica()
        {
            InitializeComponent();
        }

        #region Metodos
        private void MostrarFabricas()
        {
            dgvFabrica.DataSource = OFabrica.MostrarFabricas();
        }

        //Singlenton
        private static ActualizarFabrica _Abrir;

        public static ActualizarFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new ActualizarFabrica();
                return _Abrir;
            }
        }

        private void ActualizarFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }



        #endregion

        private void ActualizarFabrica_Load(object sender, EventArgs e)
        {
            MostrarFabricas();
        }

        
    }
}
