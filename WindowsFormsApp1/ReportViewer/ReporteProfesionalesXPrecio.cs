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
    public partial class ReporteProfesionalesXPrecio : Form
    {
        public ReporteProfesionalesXPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FechaDesde1.Text.Trim() != "" || FechaHasta.Text.Trim() != "")
            {
                if (DateTime.Parse(FechaDesde1.Text) <= DateTime.Parse(FechaHasta.Text))
                {
                    DataTable tabla = new DataTable();
                    tabla = AdTurnos.EstadisticasPreciosXProfesionales(FechaDesde1.Text, FechaHasta.Text);
                    if (tabla.Rows.Count >= 1)
                    {

                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource ds = new ReportDataSource("EstPrecios", tabla);
                        reportViewer1.LocalReport.DataSources.Add(ds);
                        this.reportViewer1.RefreshReport();
                        reportViewer1.LocalReport.Refresh();
                    }


                    else
                    {
                        MessageBox.Show("Error: no se encuentran profesionales con turnos para este rango");
                        this.Close();
                        ReporteProfesionalesXPrecio ventana = new ReporteProfesionalesXPrecio();
                        ventana.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error, la fecha mínima debe ser inferior a la máxima");
                    this.Close();
                    ReporteProfesionalesXPrecio ventana = new ReporteProfesionalesXPrecio();
                    ventana.Show();
                }
            }

            else
            {
                MessageBox.Show("Error, los campos están vacíos");
            }
        }

        private void ReporteProfesionalesXPrecio_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }
    }
}

