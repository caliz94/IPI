using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class REGIST_USU_AMATEURS : Form
    {
        public REGIST_USU_AMATEURS()
        {
            InitializeComponent();
        }

        //HACER REFERENCIA A LA CLASE DE LA CAPA NEGOCIO
        CN_INTEGRANTES INTEGRANTES_CN = new CN_INTEGRANTES();
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            INTEGRANTES_CN.insertar_integrante(txt_usuario.Text,txt_celular.Text,txt_pais.Text,Convert.ToDateTime(txt_fecha_ingreso.Text),txt_comentario.Text,txt_estado.Text);
            MessageBox.Show("Se Registro al integrante "+ txt_usuario.Text+" Exitosamente");
            txt_usuario.Clear();
            txt_celular.Clear();
            txt_pais.Clear();
            txt_fecha_ingreso.Clear();
            txt_comentario.Clear();
            txt_estado.Clear();
        }
    }
}
