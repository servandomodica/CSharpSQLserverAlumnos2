using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto23
{
    public partial class MantenimientoAlumnos : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public MantenimientoAlumnos()
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

            string sql = "insert into alumnos(dni,nombrealumno) values (@dni,@nombrealumno)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@nombrealumno", SqlDbType.VarChar).Value = textBox2.Text;

            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Se cargaron los datos del alumno");
        }
    }
}
