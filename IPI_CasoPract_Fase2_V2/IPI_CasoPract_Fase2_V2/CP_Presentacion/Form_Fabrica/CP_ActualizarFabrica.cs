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
    public partial class CP_ActualizarFabrica : Form
    {

        CL_Fabrica OFabrica = new CL_Fabrica();

        public CP_ActualizarFabrica()
        {
            InitializeComponent();
        }

        #region Inicio Singlenton
        private static CP_ActualizarFabrica _Abrir;

        public static CP_ActualizarFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_ActualizarFabrica();
                return _Abrir;
            }
        }

        private void ActualizarFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
        
        #endregion FinSinglenton

        private void MostrarFabricas()
        {
            dgvProveedores.DataSource = OFabrica.MostrarCamposFabricas();
        }

        private void CP_ActualizarFabrica_Load(object sender, EventArgs e)
        {
            MostrarFabricas();
            chkBuscaId.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBuscaId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscaId.Checked == true)
            {
                chkBuscaNombre.Checked = false;
                tboxIdFabrica.Enabled = true;
                tboxNombreFabrica.Enabled = false;
            }
            else
            {
                chkBuscaNombre.Checked = true;
                tboxIdFabrica.Enabled = false;
                tboxNombreFabrica.Enabled = true;
            }
        }

        private void chkBuscaNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscaNombre.Checked == true)
            {
                chkBuscaId.Checked = false;
            }
            else
            {
                chkBuscaId.Checked = true;
            }
        }
    }
}
