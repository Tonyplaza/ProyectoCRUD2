using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD2
{
    public partial class frmBorrar : Form
    {
        public frmBorrar()
        {
            InitializeComponent();
        }

        private void frmBorrar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    this.txtApellidos.Text = fila["apellidos"].ToString();
                    this.txtNombres.Text = fila["nombres"].ToString();
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    this.txtfechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    break;
                }
            }
            else
            {
                MessageBox.Show("No existe el estudiante...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar registro de este estudiante?"
                , "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int x = Academico.EstudianteDAO.delete(this.cmbMatricula.SelectedValue.ToString());
                this.txtApellidos.Clear();
                this.txtNombres.Clear();
                this.txtfechaNacimiento.Clear();
                this.txtCorreo.Clear();
                DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
                this.cmbMatricula.DataSource = dt;
            }
        }
    }
}
