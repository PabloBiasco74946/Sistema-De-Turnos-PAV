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
    public partial class ReportPrecioXOSS : Form
    {
        public ReportPrecioXOSS()
        {
            InitializeComponent();
        }

        private void ReportPrecioXOSS_Load(object sender, EventArgs e)
        {
            txtPrecioDesde.Text = "0";
            txtPrecioHasta.Text = "0";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPrecioDesde.Text.Trim() != "" || txtPrecioHasta.Text.Trim() != "")
            {
                if (int.Parse(txtPrecioDesde.Text) <= int.Parse(txtPrecioHasta.Text))
                {
                    DataTable tabla = new DataTable();
                    tabla = AdTurnos.EstadisticasOSSXPrecios(int.Parse(txtPrecioDesde.Text), int.Parse(txtPrecioHasta.Text));
                    if (tabla.Rows.Count >= 1)
                    {

                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource ds = new ReportDataSource("ObrasSocialesPrecio", tabla);
                        reportViewer1.LocalReport.DataSources.Add(ds);
                        this.reportViewer1.RefreshReport();
                        this.reportViewer1.RefreshReport();
                        reportViewer1.LocalReport.Refresh();
                    }


                    else
                    {
                        MessageBox.Show("Error: no se encuentran Obras Sociales en turnos para este rango");
                        this.Close();
                        ReportPrecioXOSS ventana = new ReportPrecioXOSS();
                        ventana.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error, el precio mínimo debe ser inferior al máximo");
                    this.Close();
                    ReportPrecioXOSS ventana = new ReportPrecioXOSS();
                    ventana.Show();
                }
            }
            else
            {
                MessageBox.Show("Error ingrese los campos solicitados");
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
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
