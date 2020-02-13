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
    public partial class frmRecordAcad_selEstudiante : Form
    {

        public static String Maricula;

        public frmRecordAcad_selEstudiante()
        {
            InitializeComponent();
        }

        private void frmRecordAcad_selEstudiante_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            if (this.cmbMatricula.SelectedValue.ToString().Length==0)
            {
                MessageBox.Show("Debes seleccionar un estudiante");
                this.cmbMatricula.Focus(); //  ubicar enfoque en cmbMatricula
                return;//abandonar la ejecucion
            }

            Maricula = this.cmbMatricula.SelectedValue.ToString();
            informe.frmRecordAcad_MostrarRecord frm1 = new informe.frmRecordAcad_MostrarRecord();
            frm1.Show();
        }
    }
}
