
namespace WindowsFormsApp1.ReportViewer
{
    partial class ReportViewerTurnosPorFechas
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
            this.reporteProfesionalesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteProfesionalesDataSet = new WindowsFormsApp1.Conjunto_de_datos.ReporteProfesionalesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaHasta1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaDesde1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesionalesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesionalesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporteProfesionalesDataSetBindingSource
            // 
            this.reporteProfesionalesDataSetBindingSource.DataSource = this.reporteProfesionalesDataSet;
            this.reporteProfesionalesDataSetBindingSource.Position = 0;
            // 
            // reporteProfesionalesDataSet
            // 
            this.reporteProfesionalesDataSet.DataSetName = "ReporteProfesionalesDataSet";
            this.reporteProfesionalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.backgruound_reportes;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.reportViewFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FechaHasta1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FechaDesde1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 667);
            this.panel1.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSalir.Image = global::WindowsFormsApp1.Properties.Resources.icono_salir;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(1078, 50);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(81, 47);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(828, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 80);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Criterios de filtrado:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Filtrar por fecha ascendente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(164, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Filtrar por fecha descendente";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Turnos por rango de fecha:";
            // 
            // reportViewFecha
            // 
            reportDataSource1.Name = "DataSetFechas";
            reportDataSource1.Value = this.reporteProfesionalesDataSetBindingSource;
            this.reportViewFecha.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewFecha.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReporteTurnosXFechas.rdlc";
            this.reportViewFecha.Location = new System.Drawing.Point(8, 109);
            this.reportViewFecha.Name = "reportViewFecha";
            this.reportViewFecha.ServerReport.BearerToken = null;
            this.reportViewFecha.Size = new System.Drawing.Size(1179, 582);
            this.reportViewFecha.TabIndex = 4;
            this.reportViewFecha.Load += new System.EventHandler(this.reportViewFecha_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FechaHasta1
            // 
            this.FechaHasta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FechaHasta1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.FechaHasta1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHasta1.Location = new System.Drawing.Point(534, 50);
            this.FechaHasta1.Name = "FechaHasta1";
            this.FechaHasta1.ShowUpDown = true;
            this.FechaHasta1.Size = new System.Drawing.Size(112, 20);
            this.FechaHasta1.TabIndex = 2;
            this.FechaHasta1.Value = new System.DateTime(2021, 6, 9, 0, 0, 0, 0);
            this.FechaHasta1.ValueChanged += new System.EventHandler(this.FechaHasta1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icono_buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(697, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaDesde1
            // 
            this.FechaDesde1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FechaDesde1.CustomFormat = "dd-MM-yyyy HH:mm";
            this.FechaDesde1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDesde1.Location = new System.Drawing.Point(354, 50);
            this.FechaDesde1.Name = "FechaDesde1";
            this.FechaDesde1.ShowUpDown = true;
            this.FechaDesde1.Size = new System.Drawing.Size(109, 20);
            this.FechaDesde1.TabIndex = 1;
            this.FechaDesde1.Tag = "";
            this.FechaDesde1.Value = new System.DateTime(2021, 6, 9, 0, 0, 0, 0);
            this.FechaDesde1.ValueChanged += new System.EventHandler(this.FechaDesde1_ValueChanged);
            // 
            // ReportViewerTurnosPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 667);
            this.Controls.Add(this.panel1);
            this.Name = "ReportViewerTurnosPorFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnosPorFechas";
            this.Load += new System.EventHandler(this.ReportViewerTurnosPorFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesionalesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesionalesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaHasta1;
        private System.Windows.Forms.DateTimePicker FechaDesde1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource reporteProfesionalesDataSetBindingSource;
        private Conjunto_de_datos.ReporteProfesionalesDataSet reporteProfesionalesDataSet;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalir;
    }
}