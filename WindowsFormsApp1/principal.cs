using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ABM;
using WindowsFormsApp1.ReportViewer;

namespace WindowsFormsApp1
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            altaProfesional ventana = new altaProfesional();
            ventana.Show();
        }

        private void clinicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmPaciente ventana = new AbmPaciente();
            ventana.Show();
        }

        private void nuevaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaUsuario ventana = new altaUsuario();
            ventana.Show();
        }

        private void borrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bajaUsuarios ventana = new bajaUsuarios();
            ventana.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarUsuario ventana = new modificarUsuario();
            ventana.Show();

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void obrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmObraSocial ventana = new AbmObraSocial();
            ventana.Show();
            this.Hide();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmEspecialidad ventana = new AbmEspecialidad();
            ventana.Show();
        }

        private void arancelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmArancel ventana = new AbmArancel();
            ventana.Show();
        }

        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmClinica ventana = new AbmClinica();
            ventana.Show();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesoTurnoXPaciente ventana = new ProcesoTurnoXPaciente();
            ventana.Show();
            this.Close();

        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void turnosPorProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewerProfesionalesTurno ventana = new ReportViewerProfesionalesTurno();
            ventana.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TurnoPacienteXEspecialidad ventana = new TurnoPacienteXEspecialidad();
            ventana.Show();
            this.Close();
        }

        private void turnosPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewerTurnosPorFechas ventana = new ReportViewerTurnosPorFechas();
            ventana.Show();
            this.Close();
        }

        private void turnosPorObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportViewerTurnosObraSocial ventana = new ReportViewerTurnosObraSocial();
            ventana.Show();
        }

        private void listadoPorProfesionalesYPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportViewerProfesionalesXPacientes ventana = new ReportViewerProfesionalesXPacientes();
            ventana.Show();

        }

        private void listadoDeTurnosPorPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportViewerPrecios ventana = new ReportViewerPrecios();
            ventana.Show();
        }

        private void profesionalesXTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           reportestadistica ventana = new reportestadistica();
            ventana.Show();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void estadisticasPreciosPorObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportPrecioXOSS ventana = new ReportPrecioXOSS();
            ventana.Show();
        }

        private void estadisticasDeProfesionalesPorPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteProfesionalesXPrecio ventana = new ReporteProfesionalesXPrecio();
            ventana.Show();
        }

        private void estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteTurnosEnFechas ventana = new ReporteTurnosEnFechas();
            ventana.Show();
        }

        private void estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteEspecialidades ventana = new ReporteEspecialidades();
            ventana.Show();
        }
    }
}
