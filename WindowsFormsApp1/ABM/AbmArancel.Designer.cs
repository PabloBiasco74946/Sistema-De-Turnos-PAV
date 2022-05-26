
namespace WindowsFormsApp1.ABM
{
    partial class AbmArancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmArancel));
            this.grdArancel = new System.Windows.Forms.DataGridView();
            this.idarancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAltaProfesional = new System.Windows.Forms.Label();
            this.mskNumeroDocumentoProfesional = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.mskFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.mskFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProfesional = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidopro = new System.Windows.Forms.TextBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtTipoDocumentoPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoDocAux = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdArancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArancel
            // 
            this.grdArancel.AllowUserToAddRows = false;
            this.grdArancel.AllowUserToDeleteRows = false;
            this.grdArancel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdArancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarancel,
            this.tipdoc,
            this.numDocProfesional,
            this.precio,
            this.FechaIni,
            this.fechaFinVigencia});
            this.grdArancel.Location = new System.Drawing.Point(12, 389);
            this.grdArancel.Name = "grdArancel";
            this.grdArancel.ReadOnly = true;
            this.grdArancel.Size = new System.Drawing.Size(489, 244);
            this.grdArancel.TabIndex = 43;
            this.grdArancel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArancel_CellContentClick);
            // 
            // idarancel
            // 
            this.idarancel.DataPropertyName = "idArancel";
            this.idarancel.HeaderText = "ID";
            this.idarancel.Name = "idarancel";
            this.idarancel.ReadOnly = true;
            this.idarancel.Width = 33;
            // 
            // tipdoc
            // 
            this.tipdoc.HeaderText = "TipoDoc";
            this.tipdoc.Name = "tipdoc";
            this.tipdoc.ReadOnly = true;
            this.tipdoc.Visible = false;
            // 
            // numDocProfesional
            // 
            this.numDocProfesional.DataPropertyName = "numDocProfesional";
            this.numDocProfesional.HeaderText = "Número de Documento";
            this.numDocProfesional.Name = "numDocProfesional";
            this.numDocProfesional.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio de Arancel";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // FechaIni
            // 
            this.FechaIni.DataPropertyName = "fecha_Inicio_Vigencia";
            this.FechaIni.HeaderText = "Fecha de Inicio";
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.ReadOnly = true;
            // 
            // fechaFinVigencia
            // 
            this.fechaFinVigencia.DataPropertyName = "fecha_Fin_Vigencia";
            this.fechaFinVigencia.HeaderText = "Fecha de fin";
            this.fechaFinVigencia.Name = "fechaFinVigencia";
            this.fechaFinVigencia.ReadOnly = true;
            this.fechaFinVigencia.Width = 110;
            // 
            // lblAltaProfesional
            // 
            this.lblAltaProfesional.AutoSize = true;
            this.lblAltaProfesional.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaProfesional.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.lblAltaProfesional.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAltaProfesional.Location = new System.Drawing.Point(403, 9);
            this.lblAltaProfesional.Name = "lblAltaProfesional";
            this.lblAltaProfesional.Size = new System.Drawing.Size(255, 29);
            this.lblAltaProfesional.TabIndex = 45;
            this.lblAltaProfesional.Text = "Añadir nuevo Arancel";
            // 
            // mskNumeroDocumentoProfesional
            // 
            this.mskNumeroDocumentoProfesional.Enabled = false;
            this.mskNumeroDocumentoProfesional.Location = new System.Drawing.Point(721, 94);
            this.mskNumeroDocumentoProfesional.Mask = "99999999";
            this.mskNumeroDocumentoProfesional.Name = "mskNumeroDocumentoProfesional";
            this.mskNumeroDocumentoProfesional.Size = new System.Drawing.Size(57, 20);
            this.mskNumeroDocumentoProfesional.TabIndex = 1;
            this.mskNumeroDocumentoProfesional.ValidatingType = typeof(int);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(721, 229);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(613, 228);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(96, 19);
            this.lblMatricula.TabIndex = 44;
            this.lblMatricula.Text = "ID Arancel:";
            // 
            // mskFechaInicio
            // 
            this.mskFechaInicio.Enabled = false;
            this.mskFechaInicio.Location = new System.Drawing.Point(721, 150);
            this.mskFechaInicio.Mask = "00/00/0000";
            this.mskFechaInicio.Name = "mskFechaInicio";
            this.mskFechaInicio.Size = new System.Drawing.Size(74, 20);
            this.mskFechaInicio.TabIndex = 3;
            this.mskFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(721, 203);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(646, 202);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 19);
            this.lblTelefono.TabIndex = 35;
            this.lblTelefono.Text = "Precio:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(534, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 19);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Fecha de finalización:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(581, 149);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(128, 19);
            this.lblFechaNacimiento.TabIndex = 31;
            this.lblFechaNacimiento.Text = "Fecha de inicio:";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblNroDocumento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.Location = new System.Drawing.Point(517, 94);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(192, 19);
            this.lblNroDocumento.TabIndex = 25;
            this.lblNroDocumento.Text = "Número de documento:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(200, 653);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 45);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(719, 304);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 46);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(864, 659);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 40);
            this.btnSalir.TabIndex = 11;
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
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDatos.Image")));
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(620, 304);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(93, 45);
            this.btnLimpiarDatos.TabIndex = 8;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(521, 304);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 46);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Registrar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDoc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(545, 122);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(164, 19);
            this.lblTipoDoc.TabIndex = 46;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // mskFechaFin
            // 
            this.mskFechaFin.Enabled = false;
            this.mskFechaFin.Location = new System.Drawing.Point(721, 176);
            this.mskFechaFin.Mask = "00/00/0000";
            this.mskFechaFin.Name = "mskFechaFin";
            this.mskFechaFin.Size = new System.Drawing.Size(75, 20);
            this.mskFechaFin.TabIndex = 4;
            this.mskFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Seleccionar Profesional";
            // 
            // grdProfesional
            // 
            this.grdProfesional.AllowUserToAddRows = false;
            this.grdProfesional.AllowUserToDeleteRows = false;
            this.grdProfesional.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.numdoc});
            this.grdProfesional.Location = new System.Drawing.Point(12, 94);
            this.grdProfesional.Name = "grdProfesional";
            this.grdProfesional.ReadOnly = true;
            this.grdProfesional.Size = new System.Drawing.Size(489, 255);
            this.grdProfesional.TabIndex = 51;
            this.grdProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfesional_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // numdoc
            // 
            this.numdoc.DataPropertyName = "numDoc";
            this.numdoc.HeaderText = "Numero de Documento";
            this.numdoc.Name = "numdoc";
            this.numdoc.ReadOnly = true;
            this.numdoc.Width = 144;
            // 
            // txtApellidopro
            // 
            this.txtApellidopro.BackColor = System.Drawing.Color.White;
            this.txtApellidopro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidopro.Enabled = false;
            this.txtApellidopro.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtApellidopro.Location = new System.Drawing.Point(956, 252);
            this.txtApellidopro.Name = "txtApellidopro";
            this.txtApellidopro.Size = new System.Drawing.Size(10, 13);
            this.txtApellidopro.TabIndex = 52;
            this.txtApellidopro.Visible = false;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BackColor = System.Drawing.Color.White;
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePro.Enabled = false;
            this.txtNombrePro.ForeColor = System.Drawing.Color.Ivory;
            this.txtNombrePro.Location = new System.Drawing.Point(972, 250);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(10, 13);
            this.txtNombrePro.TabIndex = 53;
            this.txtNombrePro.Visible = false;
            // 
            // txtTipoDocumentoPro
            // 
            this.txtTipoDocumentoPro.Enabled = false;
            this.txtTipoDocumentoPro.Location = new System.Drawing.Point(721, 122);
            this.txtTipoDocumentoPro.Name = "txtTipoDocumentoPro";
            this.txtTipoDocumentoPro.Size = new System.Drawing.Size(126, 20);
            this.txtTipoDocumentoPro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Seleccionar Arancel";
            // 
            // txtTipoDocAux
            // 
            this.txtTipoDocAux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoDocAux.Enabled = false;
            this.txtTipoDocAux.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTipoDocAux.Location = new System.Drawing.Point(881, 244);
            this.txtTipoDocAux.Name = "txtTipoDocAux";
            this.txtTipoDocAux.Size = new System.Drawing.Size(32, 13);
            this.txtTipoDocAux.TabIndex = 56;
            this.txtTipoDocAux.Visible = false;
            // 
            // AbmArancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 711);
            this.Controls.Add(this.txtTipoDocAux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoDocumentoPro);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.txtApellidopro);
            this.Controls.Add(this.grdProfesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskFechaFin);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdArancel);
            this.Controls.Add(this.lblAltaProfesional);
            this.Controls.Add(this.mskNumeroDocumentoProfesional);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.mskFechaInicio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNroDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbmArancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbmArancel";
            this.Load += new System.EventHandler(this.AbmArancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView grdArancel;
        private System.Windows.Forms.Label lblAltaProfesional;
        private System.Windows.Forms.MaskedTextBox mskNumeroDocumentoProfesional;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.MaskedTextBox mskFechaInicio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.MaskedTextBox mskFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProfesional;
        private System.Windows.Forms.TextBox txtApellidopro;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtTipoDocumentoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoDocAux;
    }
}