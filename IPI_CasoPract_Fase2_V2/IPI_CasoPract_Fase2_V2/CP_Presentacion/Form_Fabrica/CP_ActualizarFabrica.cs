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

        private void LimpiarControles()
        {
            tboxIdFabrica.Text = string.Empty;
            tboxNombreFabrica.Text = string.Empty;
            tboxTelefono.Text = string.Empty;
            chk_Estado.Checked = false;
            btnGuardar.Enabled = false;
            btnActualizarCliente.Enabled = false;
            btnCancelar.Enabled = true;
        }

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
            MostrarFabricas();
            LimpiarControles();
            pnlBusqueda.Enabled = true;
            chkBuscaId.Checked = true;
            tboxIdFabrica.Enabled = true;
            tboxNombreFabrica.Enabled = false;
            tboxTelefono.Enabled = false;
            chk_Estado.Enabled = false;
            //this.Close();
        }

        private void chkBuscaId_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscaId.Checked == true)
            {
                LimpiarControles();
                chkBuscaNombre.Checked = false;
                tboxIdFabrica.Enabled = true;
                tboxNombreFabrica.Enabled = false;
            }
            else
            {
                LimpiarControles();
                chkBuscaNombre.Checked = true;
                tboxIdFabrica.Enabled = false;
                tboxNombreFabrica.Enabled = true;
            }
        }

        private void chkBuscaNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscaNombre.Checked == true)
            {
                LimpiarControles();
                chkBuscaId.Checked = false;
            }
            else
            {
                LimpiarControles();
                chkBuscaId.Checked = true;
            }
        }


        private void tboxIdFabrica_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvProveedores.DataSource = OFabrica.BuscarFabricaxId(Convert.ToInt32(tboxIdFabrica.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tboxNombreFabrica_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvProveedores.DataSource = OFabrica.BuscaFabricaxNombre(tboxNombreFabrica.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxIdFabrica.Text = dgvProveedores.CurrentRow.Cells["IdFabrica"].Value.ToString();
            tboxNombreFabrica.Text = dgvProveedores.CurrentRow.Cells["NombreFabrica"].Value.ToString();
            tboxTelefono.Text = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
            chk_Estado.Checked = Convert.ToBoolean(dgvProveedores.CurrentRow.Cells["Activo"].Value);
            btnActualizarCliente.Enabled = true;
            btnActualizarCliente.ForeColor = Color.Yellow;
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            btnActualizarCliente.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            tboxIdFabrica.Enabled = false;
            tboxNombreFabrica.Enabled = true;
            tboxTelefono.Enabled = true;
            chk_Estado.Enabled = true;
            pnlBusqueda.Enabled = false;
            btnActualizarCliente.ForeColor = Color.Navy;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                OFabrica.ActualizarFabrica(Convert.ToInt32(tboxIdFabrica.Text), tboxNombreFabrica.Text, tboxTelefono.Text, Convert.ToByte(chk_Estado.Checked));
                MessageBox.Show("Proveedor Actualizado Exitosamente.");
                dgvProveedores.DataSource = OFabrica.BuscaFabricaxNombre(tboxNombreFabrica.Text);
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Eliminar la Fabrica. Error: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
