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
    public partial class frmRecordAcad_MostrarRecord : Form
    {
        public frmRecordAcad_MostrarRecord()
        {
            InitializeComponent();
        }

        private void frmRecordAcad_MostrarRecord_Load(object sender, EventArgs e)
        {
            string smatricula = frmRecordAcad_selEstudiante.Maricula;
            this.notasEstudiantesTableAdapter.FillxMatricula(dsNotas.notasEstudiantes, smatricula);
            this.reportViewer1.RefreshReport();
        }
    }
}
