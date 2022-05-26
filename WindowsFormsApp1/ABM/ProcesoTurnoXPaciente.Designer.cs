
namespace WindowsFormsApp1.ABM
{
    partial class ProcesoTurnoXPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoTurnoXPaciente));
            this.mskFechaTurno = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaHoy = new System.Windows.Forms.Label();
            this.txtNumTurno = new System.Windows.Forms.TextBox();
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProfesionales = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoProfesional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDocProfesional = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.lblAltaProfesional = new System.Windows.Forms.Label();
            this.txtTipoDocProfesional = new System.Windows.Forms.TextBox();
            this.txtTipoDocPaciente = new System.Windows.Forms.TextBox();
            this.cmbTipoDocProfesional = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDObraSocial = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.chkObraSocial = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSinObraSocial = new System.Windows.Forms.CheckBox();
            this.txtPrecioAtencion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesionales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskFechaTurno
            // 
            this.mskFechaTurno.Enabled = false;
            this.mskFechaTurno.Location = new System.Drawing.Point(669, 576);
            this.mskFechaTurno.Mask = "00/00/0000 00:00";
            this.mskFechaTurno.Name = "mskFechaTurno";
            this.mskFechaTurno.Size = new System.Drawing.Size(104, 20);
            this.mskFechaTurno.TabIndex = 5;
            this.mskFechaTurno.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaHoy
            // 
            this.lblFechaHoy.AutoSize = true;
            this.lblFechaHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHoy.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoy.Location = new System.Drawing.Point(937, 43);
            this.lblFechaHoy.Name = "lblFechaHoy";
            this.lblFechaHoy.Size = new System.Drawing.Size(73, 19);
            this.lblFechaHoy.TabIndex = 3;
            this.lblFechaHoy.Text = "lblFecha";
            // 
            // txtNumTurno
            // 
            this.txtNumTurno.Enabled = false;
            this.txtNumTurno.Location = new System.Drawing.Point(1141, 69);
            this.txtNumTurno.Name = "txtNumTurno";
            this.txtNumTurno.Size = new System.Drawing.Size(31, 20);
            this.txtNumTurno.TabIndex = 4;
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.BackColor = System.Drawing.Color.Transparent;
            this.lblNroTurno.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTurno.Location = new System.Drawing.Point(1054, 70);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(81, 19);
            this.lblNroTurno.TabIndex = 5;
            this.lblNroTurno.Text = "N° Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha y hora:";
            // 
            // grdProfesionales
            // 
            this.grdProfesionales.AllowUserToAddRows = false;
            this.grdProfesionales.AllowUserToDeleteRows = false;
            this.grdProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.matricula,
            this.tipodoc,
            this.apellido,
            this.dni});
            this.grdProfesionales.Enabled = false;
            this.grdProfesionales.Location = new System.Drawing.Point(12, 144);
            this.grdProfesionales.Name = "grdProfesionales";
            this.grdProfesionales.ReadOnly = true;
            this.grdProfesionales.Size = new System.Drawing.Size(494, 341);
            this.grdProfesionales.TabIndex = 4;
            this.grdProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfesionales_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matricula_Cirujano";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Visible = false;
            // 
            // tipodoc
            // 
            this.tipodoc.DataPropertyName = "tipoDoc";
            this.tipodoc.HeaderText = "TipoDoc";
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            this.tipodoc.Visible = false;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "numDoc";
            this.dni.HeaderText = "Número de Documento";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI Paciente:";
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(669, 164);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtDniPaciente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Location = new System.Drawing.Point(669, 190);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePaciente.TabIndex = 800;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Enabled = false;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(669, 216);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoPaciente.TabIndex = 465;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Apellido:";
            // 
            // txtApellidoProfesional
            // 
            this.txtApellidoProfesional.Enabled = false;
            this.txtApellidoProfesional.Location = new System.Drawing.Point(669, 437);
            this.txtApellidoProfesional.Name = "txtApellidoProfesional";
            this.txtApellidoProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoProfesional.TabIndex = 5006;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Apellido:";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Enabled = false;
            this.txtNombreProfesional.Location = new System.Drawing.Point(669, 411);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesional.TabIndex = 500;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nombre:";
            // 
            // txtNumDocProfesional
            // 
            this.txtNumDocProfesional.Enabled = false;
            this.txtNumDocProfesional.Location = new System.Drawing.Point(669, 385);
            this.txtNumDocProfesional.Name = "txtNumDocProfesional";
            this.txtNumDocProfesional.Size = new System.Drawing.Size(100, 20);
            this.txtNumDocProfesional.TabIndex = 567;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "DNI Profesional:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Precio atención:";
            // 
            // txtPrecioDescuento
            // 
            this.txtPrecioDescuento.Enabled = false;
            this.txtPrecioDescuento.Location = new System.Drawing.Point(669, 521);
            this.txtPrecioDescuento.Name = "txtPrecioDescuento";
            this.txtPrecioDescuento.Size = new System.Drawing.Size(104, 20);
            this.txtPrecioDescuento.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(561, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "Obra Social:";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObraSocial.Enabled = false;
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(669, 322);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(100, 21);
            this.cmbObraSocial.TabIndex = 3;
            this.cmbObraSocial.SelectedIndexChanged += new System.EventHandler(this.cmbObraSocial_SelectedIndexChanged);
            // 
            // lblAltaProfesional
            // 
            this.lblAltaProfesional.AutoSize = true;
            this.lblAltaProfesional.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaProfesional.Font = new System.Drawing.Font("Constantia", 22F, System.Drawing.FontStyle.Bold);
            this.lblAltaProfesional.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAltaProfesional.Location = new System.Drawing.Point(471, 9);
            this.lblAltaProfesional.Name = "lblAltaProfesional";
            this.lblAltaProfesional.Size = new System.Drawing.Size(297, 37);
            this.lblAltaProfesional.TabIndex = 46;
            this.lblAltaProfesional.Text = "Añadir nuevo Turno";
            // 
            // txtTipoDocProfesional
            // 
            this.txtTipoDocProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoDocProfesional.Enabled = false;
            this.txtTipoDocProfesional.Location = new System.Drawing.Point(899, 41);
            this.txtTipoDocProfesional.Name = "txtTipoDocProfesional";
            this.txtTipoDocProfesional.Size = new System.Drawing.Size(29, 13);
            this.txtTipoDocProfesional.TabIndex = 89;
            this.txtTipoDocProfesional.Visible = false;
            // 
            // txtTipoDocPaciente
            // 
            this.txtTipoDocPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoDocPaciente.Enabled = false;
            this.txtTipoDocPaciente.Location = new System.Drawing.Point(899, 49);
            this.txtTipoDocPaciente.Name = "txtTipoDocPaciente";
            this.txtTipoDocPaciente.Size = new System.Drawing.Size(29, 13);
            this.txtTipoDocPaciente.TabIndex = 90;
            this.txtTipoDocPaciente.Visible = false;
            // 
            // cmbTipoDocProfesional
            // 
            this.cmbTipoDocProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocProfesional.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTipoDocProfesional.FormattingEnabled = true;
            this.cmbTipoDocProfesional.Location = new System.Drawing.Point(-7, -10);
            this.cmbTipoDocProfesional.Name = "cmbTipoDocProfesional";
            this.cmbTipoDocProfesional.Size = new System.Drawing.Size(35, 21);
            this.cmbTipoDocProfesional.TabIndex = 91;
            this.cmbTipoDocProfesional.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(775, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 19);
            this.label12.TabIndex = 92;
            this.label12.Text = "ID Obra Social:";
            // 
            // txtIDObraSocial
            // 
            this.txtIDObraSocial.Enabled = false;
            this.txtIDObraSocial.Location = new System.Drawing.Point(915, 323);
            this.txtIDObraSocial.Name = "txtIDObraSocial";
            this.txtIDObraSocial.Size = new System.Drawing.Size(26, 20);
            this.txtIDObraSocial.TabIndex = 93;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.ItemHeight = 13;
            this.cmbEspecialidad.Location = new System.Drawing.Point(669, 463);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(100, 21);
            this.cmbEspecialidad.TabIndex = 27;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Especialidad:";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Enabled = false;
            this.txtIdEspecialidad.Location = new System.Drawing.Point(915, 465);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(26, 20);
            this.txtIdEspecialidad.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(775, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "ID Especialidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(12, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 29);
            this.label13.TabIndex = 96;
            this.label13.Text = "Seleccionar profesional:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1099, 675);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDatos.Image")));
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(714, 629);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(125, 45);
            this.btnLimpiarDatos.TabIndex = 7;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(583, 629);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 46);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Generar turno";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPaciente.Image = global::WindowsFormsApp1.Properties.Resources.icono_buscar;
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(789, 154);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(130, 41);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // chkObraSocial
            // 
            this.chkObraSocial.AutoSize = true;
            this.chkObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.chkObraSocial.Enabled = false;
            this.chkObraSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObraSocial.Location = new System.Drawing.Point(20, 3);
            this.chkObraSocial.Name = "chkObraSocial";
            this.chkObraSocial.Size = new System.Drawing.Size(71, 23);
            this.chkObraSocial.TabIndex = 5007;
            this.chkObraSocial.Text = "Tiene";
            this.chkObraSocial.UseVisualStyleBackColor = false;
            this.chkObraSocial.CheckedChanged += new System.EventHandler(this.chkObraSocial_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkSinObraSocial);
            this.panel1.Controls.Add(this.chkObraSocial);
            this.panel1.Location = new System.Drawing.Point(667, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 58);
            this.panel1.TabIndex = 5008;
            // 
            // chkSinObraSocial
            // 
            this.chkSinObraSocial.AutoSize = true;
            this.chkSinObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.chkSinObraSocial.Enabled = false;
            this.chkSinObraSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinObraSocial.Location = new System.Drawing.Point(20, 32);
            this.chkSinObraSocial.Name = "chkSinObraSocial";
            this.chkSinObraSocial.Size = new System.Drawing.Size(93, 23);
            this.chkSinObraSocial.TabIndex = 5008;
            this.chkSinObraSocial.Text = "No tiene";
            this.chkSinObraSocial.UseVisualStyleBackColor = false;
            this.chkSinObraSocial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPrecioAtencion
            // 
            this.txtPrecioAtencion.Enabled = false;
            this.txtPrecioAtencion.Location = new System.Drawing.Point(669, 549);
            this.txtPrecioAtencion.Name = "txtPrecioAtencion";
            this.txtPrecioAtencion.Size = new System.Drawing.Size(104, 20);
            this.txtPrecioAtencion.TabIndex = 5009;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(485, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 19);
            this.label14.TabIndex = 5010;
            this.label14.Text = "Precio con descuento:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1230, 521);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 5011;
            // 
            // ProcesoTurnoXPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_proceso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecioAtencion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDObraSocial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbTipoDocProfesional);
            this.Controls.Add(this.txtTipoDocPaciente);
            this.Controls.Add(this.txtTipoDocProfesional);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAltaProfesional);
            this.Controls.Add(this.cmbObraSocial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecioDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtApellidoProfesional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumDocProfesional);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdProfesionales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNroTurno);
            this.Controls.Add(this.txtNumTurno);
            this.Controls.Add(this.lblFechaHoy);
            this.Controls.Add(this.mskFechaTurno);
            this.DoubleBuffered = true;
            this.Name = "ProcesoTurnoXPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar turno";
            this.Load += new System.EventHandler(this.ProcesoTurnoXPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesionales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskFechaTurno;
        private System.Windows.Forms.Label lblFechaHoy;
        private System.Windows.Forms.TextBox txtNumTurno;
        private System.Windows.Forms.Label lblNroTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProfesionales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoProfesional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumDocProfesional;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.Label lblAltaProfesional;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.TextBox txtTipoDocProfesional;
        private System.Windows.Forms.TextBox txtTipoDocPaciente;
        private System.Windows.Forms.ComboBox cmbTipoDocProfesional;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDObraSocial;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.CheckBox chkObraSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSinObraSocial;
        private System.Windows.Forms.TextBox txtPrecioAtencion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
    }
}