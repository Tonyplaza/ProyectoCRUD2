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
    public partial class frmDatosPersonales1 : Form
    {
        public frmDatosPersonales1()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales1_Load(object sender, EventArgs e)
        {
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                this.estudiantes1TableAdapter.Fill(this.dsEstudiantes.estudiantes, "12345");

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No existe el estudiante...");
            }
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }
    }
}
