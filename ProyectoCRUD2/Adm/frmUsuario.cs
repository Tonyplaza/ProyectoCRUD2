using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD2.Adm
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreCompleto.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresar el nombre Completo");
                this.txtNombreCompleto.Focus();
                return;
            }
            if (this.txtLogin.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingresar el login");
                this.txtLogin.Focus();
                return;
            }
            if (this.txtClave.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingresar la clave");
                this.txtClave.Focus();
                return;
            }
            //Pregunto si el usuario existe en la base de datos 
            int id = int.Parse(this.txtId.Text.ToString());
            DataTable dt = Academico.UsuariosDAO.getDatos(id);
            if (dt.Rows.Count > 0)
            {
                int x = 0;
                Academico.Usuarios usuarios = new Academico.Usuarios();
                usuarios.idLogin = id;
                usuarios.nombreCompleto = this.txtNombreCompleto.Text;
                usuarios.login = this.txtLogin.Text;
                usuarios.clave = this.txtClave.Text;
                usuarios.tipoUsuario = this.cmbTipoUsuario.Text;
                try
                {
                    x = Academico.UsuariosDAO.actualizar(usuarios);
                    MessageBox.Show("Filas actualizadas: " + x.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                encerar();
                cargarGridUsuario();
            }
            else
            {
                int x = 0;
                Academico.Usuarios usuarios = new Academico.Usuarios();
                usuarios.nombreCompleto = this.txtNombreCompleto.Text;
                usuarios.login = this.txtLogin.Text;
                usuarios.clave = this.txtClave.Text;
                usuarios.tipoUsuario = this.cmbTipoUsuario.Text;
                x = Academico.UsuariosDAO.guardar(usuarios);
                if (x > 0)
                {
                    cargarGridUsuario();
                    encerar();
                    MessageBox.Show("Usuario guardado con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el usario");
                }
            }
            
        }
        private void cargarGridUsuario()
        {
            this.dgUsuarios.DataSource = Academico.UsuariosDAO.getDatos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void oriengendatos()
        {
            cargarGridUsuario();
            dgUsuarios.Columns["imagen"].Visible = false;
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            encerar();
            cargarGridUsuario();
            DataGridViewButtonColumn btnSelec = new DataGridViewButtonColumn();
            btnSelec.Name = "Select";
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            dgUsuarios.Columns.Add(btnSelec);
            dgUsuarios.Columns.Add(btnDelete);
        }
        private void encerar()
        {
            this.txtId.Text = "0";
            this.txtNombreCompleto.Text = String.Empty;
            this.txtLogin.Text = String.Empty;
            this.txtClave.Text = String.Empty;
            this.cmbTipoUsuario.Text = "Secretaria";
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgUsuarios.Columns[e.ColumnIndex].Name == "Select" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgUsuarios.Rows[e.RowIndex].Cells["Select"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\select.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgUsuarios.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgUsuarios.Rows[e.RowIndex].Cells["Delete"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\delete.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "Select")
            {
                txtId.Text = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtNombreCompleto.Text = dgUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtLogin.Text = dgUsuarios.CurrentRow.Cells[4].Value.ToString();
                txtClave.Text = dgUsuarios.CurrentRow.Cells[5].Value.ToString();
                cmbTipoUsuario.Text = dgUsuarios.CurrentRow.Cells[6].Value.ToString();
            }
            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("¿Estas seguro de eliminar registro de este estudiante?"
                , "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int x = Academico.UsuariosDAO.delete(dgUsuarios.CurrentRow.Cells[2].Value.ToString());
                    encerar();
                    cargarGridUsuario();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
