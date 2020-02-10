using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD2.informe
{
    public partial class frmSelecciondeDatos : Form
    {
        public frmSelecciondeDatos()
        {
            InitializeComponent();
        }

        private void frmSelecciondeDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.dsEstudiantes.estudiantes);

            this.reportViewer1.RefreshReport();
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbBuscar.DataSource = dt;
            this.cmbBuscar.DisplayMember = "Estudiante";
            this.cmbBuscar.ValueMember = "Matricula";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            String matricula = this.cmbBuscar.SelectedValue.ToString();
            try
            {
                estudiantesTableAdapter.FillBy(dsEstudiantes.estudiantes, matricula);
                reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
