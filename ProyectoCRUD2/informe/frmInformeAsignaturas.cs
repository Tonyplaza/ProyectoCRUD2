﻿using System;
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
    public partial class frmInformeAsignaturas : Form
    {
        public frmInformeAsignaturas()
        {
            InitializeComponent();
        }

        private void frmInformeAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.dsEstudiantes.asignaturas);

            this.reportViewer1.RefreshReport();
        }
    }
}
