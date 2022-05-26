using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AccesoADatos;

namespace WindowsFormsApp1.ReportViewer
{
    public partial class ReportViewerProfesionalesXPacientes : Form
    {
        public ReportViewerProfesionalesXPacientes()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
            {
                mskLetra.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && radioButton4.Checked)
            {
                string letra = mskLetra.Text;
                string letraProcesada = "'"+letra+"%'";
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerProfesionalesTabla(letraProcesada);
                ReportDataSource ds = new ReportDataSource("DataSetProfesionales", tabla);

                if (tabla.Rows.Count >= 1)
                {
                    reportviewProxPac.LocalReport.DataSources.Clear();
                    reportviewProxPac.LocalReport.DataSources.Add(ds);
                    reportviewProxPac.LocalReport.Refresh();
                    this.reportviewProxPac.RefreshReport();
                }

                else
                {
                    MessageBox.Show("No existen resultados para esta búsqueda");
                    this.Close();
                    ReportViewerProfesionalesXPacientes ventana = new ReportViewerProfesionalesXPacientes();
                    ventana.Show();

                }
            }

            if (radioButton1.Checked && radioButton3.Checked)
            {
                string letra = mskLetra.Text;
                string letraProcesada = "'%" + letra + "%'";
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerProfesionalesTabla(letraProcesada);
                ReportDataSource ds = new ReportDataSource("DataSetProfesionales", tabla);

                if (tabla.Rows.Count >= 1)
                {
                    reportviewProxPac.LocalReport.DataSources.Clear();
                    reportviewProxPac.LocalReport.DataSources.Add(ds);
                    reportviewProxPac.LocalReport.Refresh();
                    this.reportviewProxPac.RefreshReport();
                }

                else
                {
                    MessageBox.Show("No existen resultados para esta búsqueda");
                    this.Close();
                    ReportViewerProfesionalesXPacientes ventana = new ReportViewerProfesionalesXPacientes();
                    ventana.Show();

                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            ReportViewerPacientesXProfesionales ventana = new ReportViewerPacientesXProfesionales();
            ventana.Show();
        }

        private void ReportViewerProfesionalesXPacientes_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                mskLetra.Enabled = true;
            }
        }
    }
}
