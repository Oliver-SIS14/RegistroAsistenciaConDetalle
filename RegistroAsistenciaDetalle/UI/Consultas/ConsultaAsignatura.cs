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

namespace RegistroAsistenciaDetalle.UI.Consultas
{
    public partial class ConsultaAsignatura : Form
    {
        public ConsultaAsignatura()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asignatura>();
            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.asignaturaid == id);
                        break;
                    case 2:
                        listado = repositorio.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
