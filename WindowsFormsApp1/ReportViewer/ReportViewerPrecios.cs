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
    public partial class ReportViewerPrecios : Form
    {
        public ReportViewerPrecios()
        {
            InitializeComponent();
        }

        private void ReportViewerPrecios_Load(object sender, EventArgs e)
        {

            this.reportViewerPreci.RefreshReport();
            this.reportViewerPreci.RefreshReport();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Precio1 = int.Parse(txtPrecioDesde.Text);
            int Precio2 = int.Parse(txtPrecioHasta.Text);



            if(txtPrecioDesde.Text.Equals("") || txtPrecioDesde.Text.Equals(""))
            {
                MessageBox.Show("Los campos están incompletos, por favor rellenelos");
            }

            else
            {
                if(Precio1 > Precio2)
                {
                    MessageBox.Show("Ingrese un rango válido de precios ¡El precio mínimo debe ser inferior al precio máximo!");
                }

                else
                {
                    DataTable tabla = new DataTable();
                    tabla = AdTurnos.ObtenerTurnosPorPrecios(Precio1, Precio2);
                    if (tabla.Rows.Count >= 1)
                    {
                        if (radioButton1.Checked)
                        {
                            tabla.DefaultView.Sort = "precio asc";
                            tabla = tabla.DefaultView.ToTable();
                            reportViewerPreci.LocalReport.Refresh();
                            this.reportViewerPreci.RefreshReport();
                        }


                        if (radioButton2.Checked)
                        {
                            tabla.DefaultView.Sort = "precio desc";
                            tabla = tabla.DefaultView.ToTable();
                            reportViewerPreci.LocalReport.Refresh();
                            this.reportViewerPreci.RefreshReport();
                        }

                        ReportDataSource ds = new ReportDataSource("DataSetPrecios", tabla);
                        reportViewerPreci.LocalReport.DataSources.Clear();
                        reportViewerPreci.LocalReport.DataSources.Add(ds);
                        reportViewerPreci.LocalReport.Refresh();
                        this.reportViewerPreci.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("No existe ningún precio en este rango.");
                        this.Close();
                        ReportViewerPrecios ventana = new ReportViewerPrecios();
                        ventana.Show();
                    }
                }
                   
            }
                
            }

        private void reportViewerPreci_Load(object sender, EventArgs e)
        {

        }
    }
    }


