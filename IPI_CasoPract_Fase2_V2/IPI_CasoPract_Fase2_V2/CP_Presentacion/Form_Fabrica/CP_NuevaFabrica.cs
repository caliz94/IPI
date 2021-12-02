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
    public partial class CP_NuevaFabrica : Form
    {
        CL_Fabrica Ofabrica = new CL_Fabrica();

        public CP_NuevaFabrica()
        {
            InitializeComponent();
        }
        private static CP_NuevaFabrica _Abrir;
        public static CP_NuevaFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_NuevaFabrica();
                return _Abrir;
            }
        }


        private void NuevaFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void btnGuardarFabrica_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxNombreFabrica.Text == string.Empty)
                {
                    errorProvider1.SetError(tboxNombreFabrica, "CAMPO OBLIGATORIO");
                }
                else if (tboxTelefono.Text == string.Empty)
                {
                    errorProvider1.SetError(tboxTelefono, "CAMPO OBLIGATORIO");
                }
                else
                {
                    Ofabrica.InsertarFabrica(tboxNombreFabrica.Text, tboxTelefono.Text);
                    MessageBox.Show("Proveedor Creado Exitosamente");
                    tboxNombreFabrica.Text = string.Empty;
                    tboxTelefono.Text = string.Empty;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear NUEVO PROVEEDOR. Error: " + ex);
            }
        }
    }
}
