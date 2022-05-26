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
    public partial class ReportViewerTurnosPorFechas : Form
    {
        public ReportViewerTurnosPorFechas()
        {
            InitializeComponent();
        }

        private void ReportViewerTurnosPorFechas_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fecha1 = (FechaDesde1.Text);
            string Fecha2 = (FechaHasta1.Text);
          



            if (DateTime.Parse(Fecha1) <= DateTime.Parse(Fecha2))
            {
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerTurnosPorFechas(Fecha1, Fecha2);
                if (tabla.Rows.Count >= 1)
                {
                    if (checkBox1.Checked)
                    {
                        tabla.DefaultView.Sort = "fechaTurno asc";
                        tabla = tabla.DefaultView.ToTable();
                        reportViewFecha.LocalReport.Refresh();
                        this.reportViewFecha.RefreshReport();
                        checkBox2.Enabled = false;
                    }


                    if (checkBox2.Checked)
                    {
                        tabla.DefaultView.Sort = "fechaTurno desc";
                        tabla = tabla.DefaultView.ToTable();
                        reportViewFecha.LocalReport.Refresh();
                        this.reportViewFecha.RefreshReport();
                    }

                    ReportDataSource ds = new ReportDataSource("DataSetFechas", tabla);
                    reportViewFecha.LocalReport.DataSources.Clear();
                    reportViewFecha.LocalReport.DataSources.Add(ds);
                    reportViewFecha.LocalReport.Refresh();
                    this.reportViewFecha.RefreshReport();
                    
                   

                }

                else
                {
                    MessageBox.Show("No existe ningún turno para este rango de fechas.");
                    this.Close();
                    ReportViewerTurnosPorFechas ventana = new ReportViewerTurnosPorFechas();
                    ventana.Show();


                }
            }
            
            else
            {
                MessageBox.Show("Ingrese un rango de fechas válido.");
            }
        }

        private void reportViewFecha_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
            }

            else
            {
                checkBox2.Enabled = true;

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            }

            else
            {
                checkBox1.Enabled = true;

            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FechaHasta1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FechaDesde1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
