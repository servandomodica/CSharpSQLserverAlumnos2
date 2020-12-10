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
    public partial class MantenimientoNotas : Form
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);
        public MantenimientoNotas()
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

            string sql = "select nombrecarrera, nombremateria,nota,ma.codigo as codigomateria from inscripciones as inc" +
                "           inner join materias as ma on ma.codigo = inc.codigomateria" +
                "           inner join carreras as ca on ca.codigo = ma.codigocarrera  " +
                "         where inc.dni = @dni";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["nombrecarrera"].ToString(), registros["codigomateria"].ToString(), registros["nombremateria"].ToString(), registros["nota"].ToString());
            }

            registros.Close();
            conexion.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int nota;

            bool correcto = int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out nota);

            if (!correcto)
            {
                MessageBox.Show("Debe ingresar un entero");
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                return;
            }
            if (nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota debe ser un valor comprendido entre 0 y 10");
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                return;
            }

            conexion.Open();

            string sql = "update inscripciones set nota=@nota where dni=@dni and codigomateria=@codigomateria";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@nota", SqlDbType.Int).Value = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@codigomateria", SqlDbType.Int).Value = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
