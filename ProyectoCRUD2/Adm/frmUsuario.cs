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
            int x = 0;
            Academico.Usuarios usuarios = new Academico.Usuarios();
            usuarios.nombreCompleto = this.txtNombreCompleto.Text;
            usuarios.login = this.txtLogin.Text;
            usuarios.clave = this.txtClave.Text;
            usuarios.tipoUsuario = this.cmbTipoUsuario.Text;
            x = Academico.UsuariosDAO.guardar(usuarios);
            if (x>0)
            {
                cargarGridUsuario();
                MessageBox.Show("Usuario guardado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el usario");
            }
            
            
        }
        private void cargarGridUsuario()
        {
            this.dgUsuarios.DataSource = Academico.UsuariosDAO.getDatos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            encerar();
            cargarGridUsuario();
        }
        private void encerar()
        {
            this.txtId.Text = "0";
            this.txtNombreCompleto.Text = String.Empty;
            this.txtLogin.Text = String.Empty;
            this.txtClave.Text = String.Empty;
            this.cmbTipoUsuario.Text = "Secretaria";
        }
    }
}
