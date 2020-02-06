namespace ProyectoCRUD2.informe
{
    partial class frmDatosPersonales1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.estudiantes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiantes = new ProyectoCRUD2.ds.dsEstudiantes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estudiantes1TableAdapter = new ProyectoCRUD2.ds.dsEstudiantesTableAdapters.estudiantes1TableAdapter();
            this.estudiantes1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // estudiantes1BindingSource
            // 
            this.estudiantes1BindingSource.DataMember = "estudiantes1";
            this.estudiantes1BindingSource.DataSource = this.dsEstudiantes;
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.estudiantes1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD2.informe.InformePersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // estudiantes1TableAdapter
            // 
            this.estudiantes1TableAdapter.ClearBeforeFill = true;
            // 
            // estudiantes1BindingSource1
            // 
            this.estudiantes1BindingSource1.DataMember = "estudiantes1";
            this.estudiantes1BindingSource1.DataSource = this.dsEstudiantes;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(49, 78);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione el estudiante";
            // 
            // cmbMatricula
            // 
            this.cmbMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(25, 30);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(255, 21);
            this.cmbMatricula.TabIndex = 7;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // frmDatosPersonales1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMatricula);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDatosPersonales1";
            this.Text = "frmDatosPersonales1";
            this.Load += new System.EventHandler(this.frmDatosPersonales1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource estudiantes1BindingSource;
        private ds.dsEstudiantes dsEstudiantes;
        private ds.dsEstudiantesTableAdapters.estudiantes1TableAdapter estudiantes1TableAdapter;
        private System.Windows.Forms.BindingSource estudiantes1BindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMatricula;
    }
}