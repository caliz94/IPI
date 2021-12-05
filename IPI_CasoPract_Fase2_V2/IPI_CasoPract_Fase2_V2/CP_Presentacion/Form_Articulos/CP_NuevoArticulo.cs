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

     //klklkl
        private void CP_NuevoArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Abrir = null;
        }

        CL_Articulos articulos_cl = new CL_Articulos();
        private string id_articulo = null;
        private bool editar = false;


        //cargar articulos en el grid
        private void MostrarArticulos()
        {           
            dgv_articulos.DataSource = articulos_cl.Mostrar_articulos();
        }
        private void CP_NuevoArticulo_Load(object sender, EventArgs e)
        {
            MostrarArticulos();
        }

        private void limpiarcontroles()
        {
            txt_art_provistos.Clear();
            txt_cod_artic.Clear();
            txt_descrip.Clear();
            txt_existe.Clear();
            txt_fabr.Clear();
            txt_fab_altern.Clear();
            txt_prec_uni.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //nuevo
            if (editar == false)
            {
                try
                {
                    articulos_cl.NuevoArticulo(txt_descrip.Text,Convert.ToInt32( txt_existe.Text),Convert.ToDouble(txt_prec_uni.Text),Convert.ToInt32( txt_fabr.Text),Convert.ToInt32( txt_art_provistos.Text),Convert.ToInt32( txt_fab_altern.Text));
                    MessageBox.Show("El articulo Se Agrego Correctamente");
                    MostrarArticulos();
                    limpiarcontroles();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio Un Error y No Se Agrego El Articulo");
                }
            }

            //editar
            if (editar== true)
            {
                try
                {
                    articulos_cl.EditarArticulo(Convert.ToInt32(txt_cod_artic.Text),txt_descrip.Text, Convert.ToInt32(txt_existe.Text), Convert.ToDouble(txt_prec_uni.Text), Convert.ToInt32(txt_fabr.Text), Convert.ToInt32(txt_art_provistos.Text), Convert.ToInt32(txt_fab_altern.Text));
                    MessageBox.Show("El articulo "+txt_descrip.Text+" Se Modifico Correctamente");
                    MostrarArticulos();
                    limpiarcontroles();
                    editar = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio Un Error y No Se Modifico El Articulo");
                }
            }
        }

       
    }
}
