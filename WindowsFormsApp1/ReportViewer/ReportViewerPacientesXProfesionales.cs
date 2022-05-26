using Microsoft.Reporting.WinForms;
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

namespace WindowsFormsApp1.ReportViewer
{
    public partial class ReportViewerPacientesXProfesionales : Form
    {
        public ReportViewerPacientesXProfesionales()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            
            ReportViewerProfesionalesXPacientes ventana = new ReportViewerProfesionalesXPacientes();
            ventana.Show();
        }

        private void ReportViewerPacientesXProfesionales_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked && radioButton4.Checked)
            {
                string letra = mskLetra.Text;
                string letraProcesada = "'" + letra + "%'";
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerPaciente(letraProcesada);
                ReportDataSource ds = new ReportDataSource("DataSetPacientes", tabla);

                if (tabla.Rows.Count >= 1)
                {
                    reportViewPacxPro.LocalReport.DataSources.Clear();
                    reportViewPacxPro.LocalReport.DataSources.Add(ds);
                    reportViewPacxPro.LocalReport.Refresh();
                    this.reportViewPacxPro.RefreshReport();
                }

                else
                {
                    MessageBox.Show("No existen resultados para esta búsqueda");
                    this.Close();
                    ReportViewerPacientesXProfesionales ventana = new ReportViewerPacientesXProfesionales();
                    ventana.Show();

                }


            }

            if (radioButton2.Checked && radioButton3.Checked)
            {
                string letra = mskLetra.Text;
                string letraProcesada = "'%" + letra + "%'";
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerPaciente(letraProcesada);
                ReportDataSource ds = new ReportDataSource("DataSetPacientes", tabla);

                if (tabla.Rows.Count >= 1)
                {
                    reportViewPacxPro.LocalReport.DataSources.Clear();
                    reportViewPacxPro.LocalReport.DataSources.Add(ds);
                    reportViewPacxPro.LocalReport.Refresh();
                    this.reportViewPacxPro.RefreshReport();
                }

                else
                {
                    MessageBox.Show("No existen resultados para esta búsqueda");
                    this.Close();
                    ReportViewerPacientesXProfesionales ventana = new ReportViewerPacientesXProfesionales();
                    ventana.Show();

                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                mskLetra.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                mskLetra.Enabled = true;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void reportViewPacxPro_Load(object sender, EventArgs e)
        {

        }
    }
}
