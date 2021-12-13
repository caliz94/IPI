using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace PRESENTACION
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        //CADENA CON EL SERVIDOR DE BASE DE DATOS
        private SqlConnection Conexion = new SqlConnection("Server=.;database=AMATEURS;INTEGRATED SECURITY=TRUE");

        SqlCommand cmd;
        SqlDataReader dr;


        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        private void GrafCategorias()
        {
            cmd = new SqlCommand("placas_mes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria.Add(dr.GetString(0));
                CantProd.Add(dr.GetInt32(1));
            }
            Grf_PlacasMes.Series[0].Points.DataBindXY(Categoria, CantProd);
            dr.Close();
            Conexion.Close();
        }

        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();
        private void mejores_5_mes()
        {
            cmd = new SqlCommand("mejores_5_mes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                Cant.Add(dr.GetInt32(1));
            }
            chart1.Series[0].Points.DataBindXY(Producto, Cant);
            dr.Close();
            Conexion.Close();
        }
        ArrayList PLACAS = new ArrayList();
        ArrayList MES = new ArrayList();       
        private void placas_anuales()
        {
            cmd = new SqlCommand("sp_anual", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PLACAS.Add(dr.GetInt32(0));
                MES.Add(dr.GetString(1));
            }
            chart2.Series[0].Points.DataBindXY(MES, PLACAS);
            dr.Close();
            Conexion.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            GrafCategorias();
            mejores_5_mes();
            placas_anuales();
        }

        private void panel_der_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
