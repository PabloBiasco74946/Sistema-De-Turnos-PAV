using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AccesoADatos;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1.ReportViewer
{
    public partial class ReportViewerProfesionalesTurno : Form
    {
        public ReportViewerProfesionalesTurno()
        {
            InitializeComponent();
        }

        private void ReportViewerProfesionalesTurno_Load(object sender, EventArgs e)
        {
           this.reportviewPro.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

    

        private void reportViewer1_Load(object sender, EventArgs e)
        {
         
        }

        private void reportviewPro_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string documento = txtDoc.Text;
            
            if(txtDoc.Text.Equals(""))
            {
                MessageBox.Show("Rellene los campos solicitados");
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerProfesionalesXTurnos(documento);

                ReportDataSource ds = new ReportDataSource("DSfiltro", tabla);

                if (tabla.Rows.Count >= 1)
                {
                    reportviewPro.LocalReport.DataSources.Clear();
                    reportviewPro.LocalReport.DataSources.Add(ds);
                    reportviewPro.LocalReport.Refresh();
                    this.reportviewPro.RefreshReport();

                }

                else
                {
                    MessageBox.Show("No existen datos para esta búsqueda");
                    this.Close();
                    ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                    ventana.Show();
                }
                  
            }

        }
    }
}
