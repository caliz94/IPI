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
    public partial class CP_EliminarFabrica : Form
    {
        CL_Fabrica OFabrica = new CL_Fabrica();


        public CP_EliminarFabrica()
        {
            InitializeComponent();
        }

        private void CP_EliminarFabrica_Load(object sender, EventArgs e)
        {
            cboxNombreFabrica.DataSource = OFabrica.CargarComboFabrica();
            cboxNombreFabrica.DisplayMember = "NombreFabrica";
            cboxNombreFabrica.SelectedIndex = -1;
            cboxNombreFabrica.ValueMember = "IdFabrica";
        }

        
        private static CP_EliminarFabrica _Abrir;
        public static CP_EliminarFabrica Abrir
        {
            get
            {
                if (_Abrir == null)
                    _Abrir = new CP_EliminarFabrica();
                return _Abrir;
            }
        }


        private void CP_EliminarFabrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string indice = cboxNombreFabrica.SelectedValue.ToString();
            OFabrica.EliminarFabrica(Convert.ToInt32(indice));
        }
    }
}
