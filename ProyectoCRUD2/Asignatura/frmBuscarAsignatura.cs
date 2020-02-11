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
    public partial class frmBuscarAsignatura : Form
    {
        public frmBuscarAsignatura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = Academico.AsignaturaDAO.getDatos(this.cmbCodAsignatura.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    this.txtCodAsignatura.Text = fila["codAsignatura"].ToString();
                    this.txtNombreAsignatura.Text = fila["nombreAsignatura"].ToString();
                    this.txtNivel.Text = fila["nivel"].ToString();
                    this.txtCreditos.Text = fila["creditos"].ToString();
                    this.txtCarrera.Text = fila["carrera"].ToString();
                    break;
                }
            }
            else
            {
                MessageBox.Show("No existe el estudiante...");
            }
        }

        private void frmBuscarAsignatura_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.AsignaturaDAO.getNombresCompletos();
            this.cmbCodAsignatura.DataSource = dt;
            this.cmbCodAsignatura.DisplayMember = "Asignatura";
            this.cmbCodAsignatura.ValueMember = "CodAsignatura";
        }
    }
}
