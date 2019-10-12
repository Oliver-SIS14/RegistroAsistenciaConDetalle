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
    public partial class RegistroAsistencia : Form
    {
        public List<DetalleEstudiante> detalle { set; get; }
        public RegistroAsistencia()
        {
            InitializeComponent();
            this.detalle = new List<DetalleEstudiante>(); //Inicializa la lista de estudiantes
        }

        private void AgregarButton_Click(object sender, EventArgs e) //Abre el formulario para agregar un estudiante
        {

            Form formulario = new RegistroEstudiante();
            formulario.ShowDialog();

            var Lista = new List<Estudiante>();
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            Lista = repositorio.GetList(p => true);

            foreach (var item in Lista)
            {
                EstudianteComboBox.Items.Add(item.Nombres);
            }
        }

        public void CargarGrid() //Actualiza el grid
        {
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.DataSource = this.detalle;
        }

        public void Limpiar() //Limpiar
        {
            MyErrorProvider.Clear();
            IDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now.Date;
            EstudianteComboBox.Text = string.Empty;
            AsistenciaCheckBox.Checked = false;
            CantidadTextBox.Text = string.Empty;

            this.detalle = new List<DetalleEstudiante>();
            CargarGrid();
        }

        public Asistencia LlenarClase() //Llenar la clase que se va a guardar
        {
            Asistencia asistencia = new Asistencia();

            asistencia.asistenciaid = Convert.ToInt32(IDNumericUpDown.Value);
            asistencia.Fecha = FechaDateTimePicker.Value.Date;
            asistencia.asignatura = AsignaturaComboBox.Text;
            asistencia.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            asistencia.estudiantes = this.detalle;

            return asistencia;
        }

        public void LlenarCampos(Asistencia asistencia) //Llenar los campos
        {
            IDNumericUpDown.Value = asistencia.asistenciaid;
            FechaDateTimePicker.Value = asistencia.Fecha.Date;
            AsignaturaComboBox.Text = asistencia.asignatura;
            this.detalle = asistencia.estudiantes;
            CantidadTextBox.Text = Convert.ToString(this.detalle.Count);

            CargarGrid();
        }

        public bool validar() //validar los campos del registro
        {
            bool paso = true;

            if (this.detalle.Count == 0)
            {
                MyErrorProvider.SetError(AgregarButton, "Debe por lo menos agregar un estudiante");
                AgregarButton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                MyErrorProvider.SetError(AsignaturaButton, "Debe por lo menos agregar una asignatura");
                AsignaturaButton.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos() //Verifica si existe en la base de datos
        {
            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();

            Asistencia asistencia = repositorio.Buscar((int)IDNumericUpDown.Value);
            return asistencia != null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarAsistenciaButton_Click(object sender, EventArgs e) //Agrega elementos al data grid view
        {
            if (EstudianteComboBox.Text.Trim().Length <= 0)
                return;

            if (EstudiantesDataGridView.DataSource != null)
                this.detalle = (List<DetalleEstudiante>)EstudiantesDataGridView.DataSource;


            this.detalle.Add(

                new DetalleEstudiante(
                    id: 0,
                    asistenciaid: (int)IDNumericUpDown.Value,
                    nombre: EstudianteComboBox.Text,
                    presente: AsistenciaCheckBox.Checked
                    )
                );

            CargarGrid();
            EstudianteComboBox.Focus();
            EstudianteComboBox.Text = string.Empty;

            CantidadTextBox.Text = EstudiantesDataGridView.Rows.Count.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            bool paso = false;

            AsistenciaRepositorio repositorio = new AsistenciaRepositorio();

            if (!validar())
                return;

            Asistencia asistencia = new Asistencia();

            asistencia = LlenarClase();

            if(IDNumericUpDown.Value == 0)
                paso  = repositorio.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asistencia);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();

            Asistencia asistencia = new Asistencia();
            asistencia = repositorio.Buscar(id);

            Limpiar();

            if(asistencia == null)
            {
                MessageBox.Show("Asistencia no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampos(asistencia);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();
            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
            }
            else
            {
                MyErrorProvider.SetError(IDNumericUpDown, "La asistencia que quiere eliminar, no esta registrada");
                IDNumericUpDown.Focus();
            }
        }

        private void RegistroAsistencia_Load(object sender, EventArgs e) //Actualiza el combo box de los estudiantes y de las asignaturas
        {
            var Lista = new List<Estudiante>();
            var Lista2 = new List<Asignatura>();

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            RepositorioBase<Asignatura> repositorioa = new RepositorioBase<Asignatura>();

            Lista2 = repositorioa.GetList(c => true);
            Lista = repositorio.GetList(p => true);

            foreach(var item in Lista)
            {
                EstudianteComboBox.Items.Add(item.Nombres);
            }

            foreach(var item in Lista2)
            {
                AsignaturaComboBox.Items.Add(item.Nombre);
            }
        }

        private void AsignaturaButton_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroAsignatura();
            formulario.ShowDialog();

            var Lista = new List<Asignatura>();
            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            Lista = repositorio.GetList(p => true);

            foreach (var item in Lista)
            {
                AsignaturaComboBox.Items.Add(item.Nombre);
            }
        }
    }
}
