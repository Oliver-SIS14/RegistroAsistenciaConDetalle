using RegistroAsistenciaDetalle.BLL;
using RegistroAsistenciaDetalle.DAL;
using RegistroAsistenciaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistenciaDetalle.UI.Registros
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "Es campo estudiante no puede estar vacio");
                EstudianteTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void LlenarCampo(Estudiante estudiante)
        {
            IDnumericUpDown.Value = estudiante.Estudianteid;
            EstudianteTextBox.Text = estudiante.Nombres;
        }

        public Estudiante LlenarClase()
        {
            Estudiante estudiante = new Estudiante();

            estudiante.Estudianteid = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Nombres = EstudianteTextBox.Text;

            return estudiante;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            Estudiante estudiante = repositorio.Buscar((int)IDnumericUpDown.Value);
            return estudiante != null;
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            Estudiante estudiante = new Estudiante();

            if (!validar())
                return;

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            estudiante = LlenarClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(estudiante);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarEstudiante();
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LimpiarEstudiante()
        {
            IDnumericUpDown.Value = 0;
            EstudianteTextBox.Text = string.Empty;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarEstudiante();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            Estudiante estudiante = new Estudiante();
            estudiante = repositorio.Buscar(id);

            LimpiarEstudiante();

            if (estudiante == null)
            {
                MessageBox.Show("Asistencia no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(estudiante);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            LimpiarEstudiante();

            if (repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
            }
            else
            {
                MyErrorProvider.SetError(IDnumericUpDown, "La asistencia que quiere eliminar, no esta registrada");
                IDnumericUpDown.Focus();
            }
        }
    }
}
