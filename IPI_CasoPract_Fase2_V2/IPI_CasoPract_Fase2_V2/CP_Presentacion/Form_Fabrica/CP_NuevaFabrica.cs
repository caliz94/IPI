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

        private void btnGuardarFabrica_Click(object sender, EventArgs e)
        {
            try
            {
                Ofabrica.InsertarFabrica(tboxNombreFabrica.Text, Convert.ToInt32(tboxCodArticulo.Text), tboxDescripcion.Text, Convert.ToInt32(numExistencia.Value), tboxTelefono.Text);
                MessageBox.Show("Proveedor Creado Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear NUEVO PROVEEDOR. Error: " + ex);
            }
        }


        private void NuevaFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }
    }
}
