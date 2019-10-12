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
    public partial class ConsultaAsistencia : Form
    {
        public ConsultaAsistencia()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asistencia>();
            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.asistenciaid == id);
                        break;
                    case 2:
                        listado = repositorio.GetList(p => p.asignatura.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date <= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
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
