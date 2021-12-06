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

        CL_Fabrica OFbrica = new CL_Fabrica();
        CL_Articulos articulos_cl = new CL_Articulos();
        private string id_articulo = null;
        private bool editar = false;


        //cargar articulos en el grid
        private void MostrarArticulos()
        {           
            dgv_articulos.DataSource = articulos_cl.Mostrar_articulos();
        }
        private void MostrarComboFabrica()
        {            
            cbx_fabrica.DataSource = OFbrica.CargarComboFabrica();
            cbx_fabrica.DisplayMember = "NombreFabrica";
            cbx_fabrica.SelectedIndex = -1;
            cbx_fabrica.ValueMember = "IdFabrica";
        }

        private void CP_NuevoArticulo_Load(object sender, EventArgs e)
        {
            MostrarComboFabrica();
            MostrarArticulos();
        }

        private void limpiarcontroles()
        {
            txt_art_provistos.Clear();
            txt_cod_artic.Clear();
            txt_descrip.Clear();
            txt_existe.Clear();
            cbx_fabrica.Text = string.Empty;
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
                    articulos_cl.NuevoArticulo(/*Convert.ToInt32(txt_cod_artic.Text),*/txt_descrip.Text,
                        Convert.ToInt32( txt_existe.Text),Convert.ToDouble(txt_prec_uni.Text),
                         Convert.ToInt32(cbx_fabrica.SelectedValue),Convert.ToInt32( txt_art_provistos.Text),
                        Convert.ToInt32(txt_fab_altern.Text));
                    MessageBox.Show("El articulo Se Agrego Correctamente");
                    MostrarArticulos();
                    limpiarcontroles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio Un Error y No Se Agrego El Articulo"+ex.Message);
                }
            }

            //editar
            if (editar== true)
            {
                try
                {
                    articulos_cl.EditarArticulo(Convert.ToInt32(txt_cod_artic.Text),txt_descrip.Text, Convert.ToInt32(txt_existe.Text), Convert.ToDouble(txt_prec_uni.Text), Convert.ToInt32(cbx_fabrica.SelectedValue), Convert.ToInt32(txt_art_provistos.Text), Convert.ToInt32(txt_fab_altern.Text));
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_articulos.SelectedRows.Count > 0)
            {
                editar = true;
                txt_cod_artic.Text = dgv_articulos.CurrentRow.Cells["IdArticulo"].Value.ToString();
                txt_descrip.Text = dgv_articulos.CurrentRow.Cells["Descripción_Articulo"].Value.ToString();
                txt_existe.Text = dgv_articulos.CurrentRow.Cells["Existencias"].Value.ToString();
                txt_prec_uni.Text = dgv_articulos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
               /* txt_fabr.Text = cbx_fabrica.SelectedText;*/ //cbx_fabrica.Select.Cells["IdFabrica"].Value.ToString();
                //PARA CARGAR LO DATOS DEL GRID ES EN EL BOTON EDITAR
                //AHORA YO TENGO EL PROCEDIMIENTO DE NUEVO Y EDITAR EN EL BOTON GUARDAR
                //Y EN EL GRID LO PIENSO DEJAR PAR VER
                //AHORA EL TEXBOX FABRICA ELIMANADO Y DEJO SOLO EL COMBO BOX
                //AHORA PARA NUEVO Y EDITAR QUIRO PASAR EL VALOR DE EL COMBOBOX
                //YA TE MUESTRO/ Y ME DECIS SI SE PUEDE
                

                txt_art_provistos.Text = dgv_articulos.CurrentRow.Cells["ArticulosProvistos"].Value.ToString();
                txt_fab_altern.Text = dgv_articulos.CurrentRow.Cells["NoFabricasAlternativas"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione Un Articulo Por Favor");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_articulos.SelectedRows.Count > 0)
            {
                id_articulo = dgv_articulos.CurrentRow.Cells["IdArticulo"].Value.ToString();
                articulos_cl.Eliminar_articulo(id_articulo);
                MessageBox.Show("Articulo Eliminado Exitosamente");
                MostrarArticulos();
            }
            else
                MessageBox.Show("Seleccione un articulo");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
