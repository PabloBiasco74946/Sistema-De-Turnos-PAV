
namespace WindowsFormsApp1
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arancelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPorProfesionalesYPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTurnosPorPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosPorProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosPorObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesXTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.altaToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(262, 414);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sistemaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clinicasToolStripMenuItem,
            this.configurarImpresoraToolStripMenuItem});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_sistema2;
            this.sistemaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.sistemaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(249, 66);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // clinicasToolStripMenuItem
            // 
            this.clinicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaClínicaToolStripMenuItem,
            this.cambiarContraseña,
            this.borrarUsuarioToolStripMenuItem});
            this.clinicasToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_usuario;
            this.clinicasToolStripMenuItem.Name = "clinicasToolStripMenuItem";
            this.clinicasToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.clinicasToolStripMenuItem.Text = "Usuarios";
            this.clinicasToolStripMenuItem.Click += new System.EventHandler(this.clinicasToolStripMenuItem_Click);
            // 
            // nuevaClínicaToolStripMenuItem
            // 
            this.nuevaClínicaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_persona;
            this.nuevaClínicaToolStripMenuItem.Name = "nuevaClínicaToolStripMenuItem";
            this.nuevaClínicaToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.nuevaClínicaToolStripMenuItem.Text = "Nuevo usuario";
            this.nuevaClínicaToolStripMenuItem.Click += new System.EventHandler(this.nuevaClínicaToolStripMenuItem_Click);
            // 
            // cambiarContraseña
            // 
            this.cambiarContraseña.Image = global::WindowsFormsApp1.Properties.Resources.icono_editarPersona;
            this.cambiarContraseña.Name = "cambiarContraseña";
            this.cambiarContraseña.Size = new System.Drawing.Size(244, 30);
            this.cambiarContraseña.Text = "Modificar usuario";
            this.cambiarContraseña.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // borrarUsuarioToolStripMenuItem
            // 
            this.borrarUsuarioToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_eliminarPersona;
            this.borrarUsuarioToolStripMenuItem.Name = "borrarUsuarioToolStripMenuItem";
            this.borrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.borrarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.borrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.borrarUsuarioToolStripMenuItem_Click);
            // 
            // configurarImpresoraToolStripMenuItem
            // 
            this.configurarImpresoraToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_impresora;
            this.configurarImpresoraToolStripMenuItem.Name = "configurarImpresoraToolStripMenuItem";
            this.configurarImpresoraToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.configurarImpresoraToolStripMenuItem.Text = "Configurar impresora";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.pacientesToolStripMenuItem1,
            this.obrasSocialesToolStripMenuItem,
            this.arancelesToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.clinicaToolStripMenuItem});
            this.altaToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.altaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_ABM2;
            this.altaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(249, 66);
            this.altaToolStripMenuItem.Text = "ABM";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_profesional;
            this.pacientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.pacientesToolStripMenuItem.Text = "Profesionales";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.icono_profesional1;
            this.pacientesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(234, 38);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_oss;
            this.obrasSocialesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            this.obrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.obrasSocialesToolStripMenuItem_Click);
            // 
            // arancelesToolStripMenuItem
            // 
            this.arancelesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_money;
            this.arancelesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arancelesToolStripMenuItem.Name = "arancelesToolStripMenuItem";
            this.arancelesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.arancelesToolStripMenuItem.Text = "Aranceles";
            this.arancelesToolStripMenuItem.Click += new System.EventHandler(this.arancelesToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_especialidades;
            this.especialidadesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            this.especialidadesToolStripMenuItem.Click += new System.EventHandler(this.especialidadesToolStripMenuItem_Click);
            // 
            // clinicaToolStripMenuItem
            // 
            this.clinicaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_clinica;
            this.clinicaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clinicaToolStripMenuItem.Name = "clinicaToolStripMenuItem";
            this.clinicaToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.clinicaToolStripMenuItem.Text = "Clinica";
            this.clinicaToolStripMenuItem.Click += new System.EventHandler(this.clinicaToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.listadoPorProfesionalesYPacientesToolStripMenuItem,
            this.listadoDeTurnosPorPreciosToolStripMenuItem,
            this.turnosPorProfesionalesToolStripMenuItem,
            this.turnosPorObraSocialToolStripMenuItem,
            this.turnosPorFechasToolStripMenuItem});
            this.listadosToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.listadosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_ABM1;
            this.listadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(249, 66);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(415, 30);
            this.toolStripMenuItem1.Text = "Turnos por Pacientes y Especialidad";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // listadoPorProfesionalesYPacientesToolStripMenuItem
            // 
            this.listadoPorProfesionalesYPacientesToolStripMenuItem.Name = "listadoPorProfesionalesYPacientesToolStripMenuItem";
            this.listadoPorProfesionalesYPacientesToolStripMenuItem.Size = new System.Drawing.Size(415, 30);
            this.listadoPorProfesionalesYPacientesToolStripMenuItem.Text = "Listado por Profesionales y Pacientes";
            this.listadoPorProfesionalesYPacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoPorProfesionalesYPacientesToolStripMenuItem_Click);
            // 
            // listadoDeTurnosPorPreciosToolStripMenuItem
            // 
            this.listadoDeTurnosPorPreciosToolStripMenuItem.Name = "listadoDeTurnosPorPreciosToolStripMenuItem";
            this.listadoDeTurnosPorPreciosToolStripMenuItem.Size = new System.Drawing.Size(415, 30);
            this.listadoDeTurnosPorPreciosToolStripMenuItem.Text = "Listado de Turnos por Precios";
            this.listadoDeTurnosPorPreciosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTurnosPorPreciosToolStripMenuItem_Click);
            // 
            // turnosPorProfesionalesToolStripMenuItem
            // 
            this.turnosPorProfesionalesToolStripMenuItem.Name = "turnosPorProfesionalesToolStripMenuItem";
            this.turnosPorProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(415, 30);
            this.turnosPorProfesionalesToolStripMenuItem.Text = "Turnos por Profesionales";
            this.turnosPorProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.turnosPorProfesionalesToolStripMenuItem_Click);
            // 
            // turnosPorObraSocialToolStripMenuItem
            // 
            this.turnosPorObraSocialToolStripMenuItem.Name = "turnosPorObraSocialToolStripMenuItem";
            this.turnosPorObraSocialToolStripMenuItem.Size = new System.Drawing.Size(415, 30);
            this.turnosPorObraSocialToolStripMenuItem.Text = "Turnos por Obra Social";
            this.turnosPorObraSocialToolStripMenuItem.Click += new System.EventHandler(this.turnosPorObraSocialToolStripMenuItem_Click);
            // 
            // turnosPorFechasToolStripMenuItem
            // 
            this.turnosPorFechasToolStripMenuItem.Name = "turnosPorFechasToolStripMenuItem";
            this.turnosPorFechasToolStripMenuItem.Size = new System.Drawing.Size(415, 30);
            this.turnosPorFechasToolStripMenuItem.Text = "Turnos por Fechas";
            this.turnosPorFechasToolStripMenuItem.Click += new System.EventHandler(this.turnosPorFechasToolStripMenuItem_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesionalesXTurnosToolStripMenuItem,
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem,
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem,
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem,
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem});
            this.estadísticasToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.estadísticasToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_estadisticas;
            this.estadísticasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(249, 66);
            this.estadísticasToolStripMenuItem.Text = "Reportes";
            // 
            // profesionalesXTurnosToolStripMenuItem
            // 
            this.profesionalesXTurnosToolStripMenuItem.Name = "profesionalesXTurnosToolStripMenuItem";
            this.profesionalesXTurnosToolStripMenuItem.Size = new System.Drawing.Size(547, 30);
            this.profesionalesXTurnosToolStripMenuItem.Text = "Estadísticas de Turnos Profesionales por fechas";
            this.profesionalesXTurnosToolStripMenuItem.Click += new System.EventHandler(this.profesionalesXTurnosToolStripMenuItem_Click);
            // 
            // estadisticasPreciosPorObrasSocialesToolStripMenuItem
            // 
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem.Name = "estadisticasPreciosPorObrasSocialesToolStripMenuItem";
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(547, 30);
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem.Text = "Estadísticas Precios por Obras Sociales";
            this.estadisticasPreciosPorObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.estadisticasPreciosPorObrasSocialesToolStripMenuItem_Click);
            // 
            // estadisticasDeProfesionalesPorPreciosToolStripMenuItem
            // 
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem.Name = "estadisticasDeProfesionalesPorPreciosToolStripMenuItem";
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem.Size = new System.Drawing.Size(547, 30);
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem.Text = "Estadísticas de Precios por Profesionales ";
            this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem.Click += new System.EventHandler(this.estadisticasDeProfesionalesPorPreciosToolStripMenuItem_Click);
            // 
            // estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem
            // 
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem.Name = "estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem";
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem.Size = new System.Drawing.Size(547, 30);
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem.Text = "Estadísiticas del total de Turnos por Fechas";
            this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem.Click += new System.EventHandler(this.estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnoToolStripMenuItem});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.procesosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icono_procesos;
            this.procesosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(249, 66);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.turnoToolStripMenuItem.Text = "Turno";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.salirDelSistemaToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.icono_salir;
            this.salirDelSistemaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(249, 66);
            this.salirDelSistemaToolStripMenuItem1.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem1.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem
            // 
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem.Name = "estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem";
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem.Size = new System.Drawing.Size(547, 30);
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem.Text = "Estadísticas de Especialidades por Turnos en fechas";
            this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_menuPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 414);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clinicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaClínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem configurarImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arancelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosPorProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turnosPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosPorObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPorProfesionalesYPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTurnosPorPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesXTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasPreciosPorObrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasDeProfesionalesPorPreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísiticasDelTotalDeTurnosPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasDeEspecialidadesPorTurnosEnFechasToolStripMenuItem;
    }
}