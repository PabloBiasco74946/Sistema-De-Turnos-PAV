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
    public partial class ReportViewerTurnosObraSocial : Form
    {
        public ReportViewerTurnosObraSocial()
        {
            InitializeComponent();
        }



        private void BuscarConObraSocial()
        {
            int documento = 1;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);
            
            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }

        }

     


        private void BuscarConOsASC()
        {
            int documento = 1;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);
            tabla.DefaultView.Sort = "apellidoPaciente asc";
            tabla = tabla.DefaultView.ToTable();
            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }

        }

        private void BuscarConOsDESC()
        {
            int documento = 1;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);
            tabla.DefaultView.Sort = "apellidoPaciente desc";
            tabla = tabla.DefaultView.ToTable();
            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }
        }



        private void BuscarSinObraSocial()
        {
            int documento = 0;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);

            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }
        }

        
        private void BuscarSinOsDESC()
        {
            int documento = 0;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);
            tabla.DefaultView.Sort = "apellidoPaciente desc";
            tabla = tabla.DefaultView.ToTable();
            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }
        }

        private void BuscarSinOsASC()
        {
            int documento = 0;
            checkBox1.Enabled = false;
            DataTable tabla = new DataTable();
            tabla = AdTurnos.ObtenerObrasSociales(documento);
            tabla.DefaultView.Sort = "apellidoPaciente asc";
            tabla = tabla.DefaultView.ToTable();
            ReportDataSource ds = new ReportDataSource("DataSetObraSocial", tabla);

            if (tabla.Rows.Count >= 1)
            {
                reportViewObraSocial.LocalReport.DataSources.Clear();
                reportViewObraSocial.LocalReport.DataSources.Add(ds);
                reportViewObraSocial.LocalReport.Refresh();
                this.reportViewObraSocial.RefreshReport();
            }

            else
            {
                MessageBox.Show("No existen datos para esta búsqueda");
                this.Close();
                ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
                ventana.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Primero debe seleccionar el criterio de filtrado!");

            }

            else
            {
                if (checkBox1.Checked)
                {
                    BuscarConObraSocial();

                    if (radioButton1.Checked)
                    {
                        BuscarConOsASC();
                    }

                    if (radioButton2.Checked)
                    {
                        BuscarConOsDESC();
                    }
                }

                else
                {
                    checkBox2.Enabled = true;
                }


                if (checkBox2.Checked)
                {
                    BuscarSinObraSocial();

                    if(radioButton1.Checked)
                    {
                        BuscarSinOsASC();
                    }
                    
                    if (radioButton2.Checked)
                    {
                        BuscarSinOsDESC();
                    }
                }
                else
                {
                    checkBox1.Enabled = true;
                }

            }
                
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reportViewObraSocial_Load(object sender, EventArgs e)
        {

        }
    }
}
