using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD2.Asignatura
{
    public partial class frmGuardarAsignatura : Form
    {
        public frmGuardarAsignatura()
        {
            InitializeComponent();
        }

        private void frmGuardarAsignatura_Load(object sender, EventArgs e)
        {
            cargarGridAsignaturas();
        }
        private void cargarGridAsignaturas()
        {
            this.dgAsignaturas.DataSource = Academico.AsignaturaDAO.getDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Asignatura asignatura = new Academico.Asignatura();
            asignatura.CodAsignatura = this.txtCodAsignatura.Text;
            asignatura.NombreAsignatura = this.txtNombreAsignatura.Text;
            asignatura.Nivel = Convert.ToInt32(this.txtNivel.Text);
            asignatura.Creditos = Convert.ToInt32(this.txtCreditos.Text);
            asignatura.Carrera = this.txtCarrera.Text;
            try
            {
                x = Academico.AsignaturaDAO.guardar(asignatura);
                cargarGridAsignaturas();
                MessageBox.Show("Filas agregadas: " + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtCodAsignatura.Text = String.Empty;
            this.txtNombreAsignatura.Text = String.Empty;
            this.txtNivel.Text = String.Empty;
            this.txtCreditos.Text = String.Empty;
            this.txtCarrera.Text = String.Empty;
            this.txtCodAsignatura.Focus();
        }
    }
}
