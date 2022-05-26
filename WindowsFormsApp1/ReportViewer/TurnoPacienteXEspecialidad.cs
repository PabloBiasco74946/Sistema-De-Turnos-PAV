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
    public partial class TurnoPacienteXEspecialidad : Form
    {
        public TurnoPacienteXEspecialidad()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TurnoPacienteXEspecialidad_Load(object sender, EventArgs e)
        {

        }

        private void reportviewPro_Load(object sender, EventArgs e)
        {

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string documento = txtDoc.Text;
            string IDespecialidad = txtEsp.Text;
            if (txtEsp.Text.Equals("") || txtDoc.Text.Equals(""))
            {
                MessageBox.Show("Porfavor, complete todos los campos.");
            }

            else
            {
                DataTable tabla = new DataTable();
                tabla = AdTurnos.ObtenerPacientesPorEsp(documento, IDespecialidad);

                ReportDataSource ds = new ReportDataSource("DataSetEspecialidades", tabla);
                if (tabla.Rows.Count >= 1)
                {
                    reportviewPro.LocalReport.DataSources.Clear();
                    reportviewPro.LocalReport.DataSources.Add(ds);
                    reportviewPro.LocalReport.Refresh();
                    this.reportviewPro.RefreshReport();
                }

                else
                {
                    MessageBox.Show("No existen resultados para esta búsqueda");
                    this.Close();
                    TurnoPacienteXEspecialidad ventana = new TurnoPacienteXEspecialidad();
                    ventana.Show();

                }
            }

         
        }
    }
}
