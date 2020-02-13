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
    public partial class frmMenu : Form
    {
        private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //llamada al form para agregar nuevos registros
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //abrir el formulario de busqueda
            frmBuscar frm1 = new frmBuscar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formulario modificar
            frmActualizar frm1 = new frmActualizar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrar frm1 = new frmBorrar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adm.frmUsuario frm1 = new Adm.frmUsuario();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informe.frmInformeEstudiantes frm1 = new informe.frmInformeEstudiantes();
            frm1.MdiParent = this;
            frm1.Show();
        }
        private void asignaturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Asignatura.frmGuardarAsignatura frm1 = new Asignatura.frmGuardarAsignatura();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignatura.frmActualizarAsignatura frm1 = new Asignatura.frmActualizarAsignatura();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignatura.frmBorrarAsignatura frm1 = new Asignatura.frmBorrarAsignatura();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignatura.frmBuscarAsignatura frm1 = new Asignatura.frmBuscarAsignatura();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void informeDeAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informe.frmInformeAsignaturas frm1 = new informe.frmInformeAsignaturas();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informe.frmSelecciondeDatos frm1 = new informe.frmSelecciondeDatos();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void listado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informe.frmRecordAcad_selEstudiante frm1 = new informe.frmRecordAcad_selEstudiante();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
