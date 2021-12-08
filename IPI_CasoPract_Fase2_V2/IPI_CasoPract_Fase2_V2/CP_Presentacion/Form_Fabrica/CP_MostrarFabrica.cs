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
    public partial class CP_MostrarFabrica : Form
    {
        CL_Fabrica OFabrica = new CL_Fabrica();

        public CP_MostrarFabrica()
        {
            InitializeComponent();
        }

        #region Metodos
        private void MostrarFabricas()
        {
            dgvFabrica.DataSource = OFabrica.MostrarFabricas();
        }

        private void MostrarFabricasAct()
        {
            dgvFabrica.DataSource = OFabrica.MostrarFabricasAct();
        }

        private void MostrarFabricasInac()
        {
            dgvFabrica.DataSource = OFabrica.MostrarFabricasInac();
        }

        //Singlenton
        private static CP_MostrarFabrica _Abrir;

        public static CP_MostrarFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_MostrarFabrica();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarFabricas();
        }

        private void btnFabricaActiva_Click(object sender, EventArgs e)
        {
            MostrarFabricasAct();
        }

        private void btnFabricaInactiva_Click(object sender, EventArgs e)
        {
            MostrarFabricasInac();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
