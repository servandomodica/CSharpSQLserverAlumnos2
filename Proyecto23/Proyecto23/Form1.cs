using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mantenimientoDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCarreras m = new MantenimientoCarreras();
            m.ShowDialog();
        }

        private void mantenimientoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMaterias m = new MantenimientoMaterias();
            m.ShowDialog();
        }

        private void mantenimientoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAlumnos m = new MantenimientoAlumnos();
            m.ShowDialog();
        }

        private void mantenimientoDeInscripcionesAMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoInscripcionMaterias m = new MantenimientoInscripcionMaterias();
            m.ShowDialog();
        }

        private void mantenimientoDeNotasDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoNotas m = new MantenimientoNotas();
            m.ShowDialog();
        }
    }
}
