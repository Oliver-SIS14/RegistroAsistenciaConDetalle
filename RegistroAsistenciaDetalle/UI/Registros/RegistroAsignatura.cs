using RegistroAsistenciaDetalle.BLL;
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
    public partial class RegistroAsignatura : Form
    {
        public RegistroAsignatura()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(AsignaturaTextBox.Text))
            {
                MyErrorProvider.SetError(AsignaturaTextBox, "Es campo asignatura no puede estar vacio");
                AsignaturaTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void LlenarCampo(Asignatura asignatura)
        {
            IDnumericUpDown.Value = asignatura.asignaturaid;
            AsignaturaTextBox.Text = asignatura.Nombre;
        }

        public Asignatura LlenarClase()
        {
            Asignatura asignatura = new Asignatura();

            asignatura.asignaturaid = Convert.ToInt32(IDnumericUpDown.Value);
            asignatura.Nombre = AsignaturaTextBox.Text;

            return asignatura;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            Asignatura asignatura = repositorio.Buscar((int)IDnumericUpDown.Value);
            return asignatura != null;
        }

        public void LimpiarAsignatura()
        {
            IDnumericUpDown.Value = 0;
            AsignaturaTextBox.Text = string.Empty;
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;

            Asignatura asignatura = new Asignatura();

            if (!validar())
                return;

            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            asignatura = LlenarClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No esta registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asignatura);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarAsignatura();
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            LimpiarAsignatura();
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            LimpiarAsignatura();

            if (repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
            }
            else
            {
                MyErrorProvider.SetError(IDnumericUpDown, "La asignatura que quiere eliminar, no esta registrada");
                IDnumericUpDown.Focus();
            }
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            Asignatura asignatura = new Asignatura();
            asignatura = repositorio.Buscar(id);

            LimpiarAsignatura();

            if (asignatura == null)
            {
                MessageBox.Show("Asignatura no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampo(asignatura);
            }
        }
    }
}
