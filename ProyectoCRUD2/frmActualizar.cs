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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (buscar()==false)
            {
                MessageBox.Show("No exite el registro...");
            }
        }
        private bool buscar ()
        {
            bool  encontrado = false;
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    encontrado = true;
                    this.txtApellidos.Text = fila["apellidos"].ToString();
                    this.txtNombres.Text = fila["nombres"].ToString();
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    this.txtfechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    break;
                }
            }
            return encontrado;
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMatricula.SelectedIndex >=0 )
            {
                buscar();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante estudiante = new Academico.Estudiante();
            estudiante.Matricula = Convert.ToString (this.cmbMatricula.SelectedValue);
            estudiante.Apellidos = this.txtApellidos.Text;
            estudiante.Nombres = this.txtNombres.Text;
            estudiante.FechaNacimiento = Convert.ToDateTime(this.txtfechaNacimiento.Text);
            estudiante.Correo = this.txtCorreo.Text;
            string genero = "F";
            if (this.cmbGenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;
            try
            {
                x = Academico.EstudianteDAO.actualizar(estudiante);
                MessageBox.Show("Filas actualizadas: " + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }
    }
}
