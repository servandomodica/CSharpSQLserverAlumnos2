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
    public partial class MantenimientoInscripcionMaterias : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);

        public MantenimientoInscripcionMaterias()
        {
            InitializeComponent();
        }

        private void MantenimientoInscripcionMaterias_Load(object sender, EventArgs e)
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
            CargarComboBoxMaterias();
        }

        private void CargarComboBoxMaterias()
        {
            conexion.Open();

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            string sql = "select codigo,nombremateria from materias where codigocarrera=@codigocarrera";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue;

            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            conexion.Close();

            comboBox2.DataSource = tabla1;
            comboBox2.DisplayMember = "nombremateria";
            comboBox2.ValueMember = "codigo";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into inscripciones(dni,codigomateria) values (@dni,@codigomateria)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@codigomateria", SqlDbType.Int).Value = comboBox2.SelectedValue;

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Se incribio el alumno a dicha materia.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select nombrecarrera, nombremateria from inscripciones as inc " + //select DESEOMOSTRAR1, DESEOMOSTRAR2 from TABLACRITICA as TABLACRITICAALIAS
                "            join materias as ma on ma.codigo = inc.codigomateria  " + //join TABLA1 as TABLA1ALIAS on TABLA1ALIAS.codigo = TABLACRITICAALIAS.codigomateria
                "            join carreras as ca on ca.codigo = ma.codigocarrera    " + //join TABLA2 as TABLA2ALIAS on TABLA2ALIAS.codigo = TABLA1ALIAS.codigocarrera
                "         where dni = @dni";

            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombrecarrera"].ToString(), registros["nombremateria"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
