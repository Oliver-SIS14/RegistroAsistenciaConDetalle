using RegistroAsistenciaDetalle.Entidades;
using RegistroAsistenciaDetalle.UI.Consultas;
using RegistroAsistenciaDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistenciaDetalle
{
    public partial class MainForm : Form
    {
        public List<DetalleEstudiante> detalle { set; get; } 
        public MainForm()
        {
            InitializeComponent();
            this.detalle = new List<DetalleEstudiante>();
        }

        private void AsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroAsistencia();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void AsistenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaAsistencia();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroAsignatura();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroEstudiante();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void AsignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaAsignatura();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaEstudiante();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void DetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultaDetalle();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
