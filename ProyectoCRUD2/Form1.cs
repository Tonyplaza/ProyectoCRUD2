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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante estudiante = new Academico.Estudiante();
            estudiante.Matricula = this.txtMatricula.Text;
            estudiante.Apellidos = this.txtApellidos.Text;
            estudiante.Nombres = this.txtNombres.Text;
            estudiante.FechaNacimiento = this.dtFechaNacimiento.Value;
            estudiante.Correo = this.txtCorreo.Text;
            string genero = "F";
            if (this.cmbGenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;
            try
            {
                x = Academico.EstudianteDAO.guardar(estudiante);
                cargarGridEstudiantes();
                MessageBox.Show("Filas agregadas: " + x.ToString());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGridEstudiantes();
        }
        private void cargarGridEstudiantes()
        {
            this.dgEstudiantes.DataSource = Academico.EstudianteDAO.getDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtMatricula.Text = String.Empty;
            this.txtApellidos.Text = String.Empty;
            this.txtNombres.Text = String.Empty;
            this.txtCorreo.Text = String.Empty;
            this.cmbGenero.Text = String.Empty;
            this.txtMatricula.Focus();
        }
    }
}
