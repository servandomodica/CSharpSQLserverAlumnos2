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
    public partial class MantenimientoMaterias : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public MantenimientoMaterias()
        {
            InitializeComponent();
        }

        private void MantenimientoMaterias_Load(object sender, EventArgs e)
        {
            CargarComboBoxCarreras();
        }

        private void CargarComboBoxCarreras()
        {
            conexion.Open();

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            string sql = "select codigo,nombrecarrera from carreras";

            adaptador1.SelectCommand = new SqlCommand(sql, conexion);
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            conexion.Close();

            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember = "nombrecarrera";
            comboBox1.ValueMember = "codigo";            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarGrillaMaterias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into materias(codigocarrera,nombremateria) values (@codigocarrera,@nombremateria)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue;
            comando.Parameters.Add("@nombremateria", SqlDbType.VarChar).Value = textBox1.Text;

            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";

            MessageBox.Show("Se cargo la materia en la carrera respectiva");

            MostrarGrillaMaterias();
        }

        private void MostrarGrillaMaterias()
        {
            conexion.Open();

            string sql = "select codigo,nombremateria from materias where codigocarrera=@codigocarrera";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["codigo"].ToString(), registros["nombremateria"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
