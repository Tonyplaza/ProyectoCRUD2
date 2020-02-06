namespace ProyectoCRUD2.informe
{
    partial class frmInformeEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEstudiantes1 = new ProyectoCRUD2.ds.dsEstudiantes();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter1 = new ProyectoCRUD2.ds.dsEstudiantesTableAdapters.estudiantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoCRUD2.informe.rptEstudiante.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(647, 335);
            this.reportViewer2.TabIndex = 0;
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "estudiantes";
            this.bindingSource1.DataSource = this.dsEstudiantes1;
            // 
            // estudiantesTableAdapter1
            // 
            this.estudiantesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmInformeEstudiantes
            // 
            this.ClientSize = new System.Drawing.Size(647, 335);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmInformeEstudiantes";
            this.Load += new System.EventHandler(this.frmInformeEstudiantes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsEstudiantes dsEstudiantes;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private ds.dsEstudiantesTableAdapters.estudiantesTableAdapter estudiantesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ds.dsEstudiantes dsEstudiantes1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ds.dsEstudiantesTableAdapters.estudiantesTableAdapter estudiantesTableAdapter1;
    }
}