using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto23
{
    public partial class MantenimientoCarreras : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public MantenimientoCarreras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into carreras(nombrecarrera) values (@nombrecarrera)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@nombrecarrera", SqlDbType.VarChar).Value = textBox1.Text;

            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";

            MostrarGrilla();

            MessageBox.Show("Se cargo la carrera");
        }

        private void MostrarGrilla()
        {
            conexion.Open();

            string sql = "select codigo,nombrecarrera from carreras";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["codigo"].ToString(), registros["nombrecarrera"].ToString());
            }

            registros.Close();
            conexion.Close();
        }

        private void MantenimientoCarreras_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }
    }
}
