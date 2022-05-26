
namespace WindowsFormsApp1.ABM
{
    partial class altaProfesional
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
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.txtApellidoProfesional = new System.Windows.Forms.TextBox();
            this.txtEmailProfesional = new System.Windows.Forms.TextBox();
            this.txtTelefonoProfesional = new System.Windows.Forms.TextBox();
            this.mskFechaNacimientoProfesional = new System.Windows.Forms.MaskedTextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatriculaProfesional = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipoDocProfesional = new System.Windows.Forms.ComboBox();
            this.mskNumeroDocumentoProfesional = new System.Windows.Forms.MaskedTextBox();
            this.lblAltaProfesional = new System.Windows.Forms.Label();
            this.grdProfesional = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDoc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(33, 113);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(164, 19);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo de documento:";
            this.lblTipoDoc.Click += new System.EventHandler(this.lblTipoDoc_Click);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblNroDocumento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.Location = new System.Drawing.Point(5, 143);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(192, 19);
            this.lblNroDocumento.TabIndex = 1;
            this.lblNroDocumento.Text = "Número de documento:";
            this.lblNroDocumento.Click += new System.EventHandler(this.lblNroDocumento_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(120, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(118, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(25, 169);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(172, 19);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.lblFechaNacimiento_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(139, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(115, 221);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(82, 19);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Location = new System.Drawing.Point(205, 60);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(177, 20);
            this.txtNombreProfesional.TabIndex = 1;
            this.txtNombreProfesional.TextChanged += new System.EventHandler(this.txtNombreProfesional_TextChanged);
            // 
            // txtApellidoProfesional
            // 
            this.txtApellidoProfesional.Location = new System.Drawing.Point(205, 87);
            this.txtApellidoProfesional.Name = "txtApellidoProfesional";
            this.txtApellidoProfesional.Size = new System.Drawing.Size(177, 20);
            this.txtApellidoProfesional.TabIndex = 2;
            this.txtApellidoProfesional.TextChanged += new System.EventHandler(this.txtApellidoProfesional_TextChanged);
            // 
            // txtEmailProfesional
            // 
            this.txtEmailProfesional.Location = new System.Drawing.Point(205, 196);
            this.txtEmailProfesional.Name = "txtEmailProfesional";
            this.txtEmailProfesional.Size = new System.Drawing.Size(177, 20);
            this.txtEmailProfesional.TabIndex = 6;
            this.txtEmailProfesional.TextChanged += new System.EventHandler(this.txtEmailProfesional_TextChanged);
            // 
            // txtTelefonoProfesional
            // 
            this.txtTelefonoProfesional.Location = new System.Drawing.Point(205, 222);
            this.txtTelefonoProfesional.Name = "txtTelefonoProfesional";
            this.txtTelefonoProfesional.Size = new System.Drawing.Size(177, 20);
            this.txtTelefonoProfesional.TabIndex = 7;
            this.txtTelefonoProfesional.TextChanged += new System.EventHandler(this.txtTelefonoProfesional_TextChanged);
            // 
            // mskFechaNacimientoProfesional
            // 
            this.mskFechaNacimientoProfesional.Location = new System.Drawing.Point(205, 170);
            this.mskFechaNacimientoProfesional.Mask = "00/00/0000";
            this.mskFechaNacimientoProfesional.Name = "mskFechaNacimientoProfesional";
            this.mskFechaNacimientoProfesional.Size = new System.Drawing.Size(68, 20);
            this.mskFechaNacimientoProfesional.TabIndex = 5;
            this.mskFechaNacimientoProfesional.ValidatingType = typeof(System.DateTime);
            this.mskFechaNacimientoProfesional.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFechaNacimientoProfesional_MaskInputRejected);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(109, 247);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(88, 19);
            this.lblMatricula.TabIndex = 16;
            this.lblMatricula.Text = "Matrícula:";
            this.lblMatricula.Click += new System.EventHandler(this.lblMatricula_Click);
            // 
            // txtMatriculaProfesional
            // 
            this.txtMatriculaProfesional.Location = new System.Drawing.Point(205, 248);
            this.txtMatriculaProfesional.Name = "txtMatriculaProfesional";
            this.txtMatriculaProfesional.Size = new System.Drawing.Size(177, 20);
            this.txtMatriculaProfesional.TabIndex = 8;
            this.txtMatriculaProfesional.TextChanged += new System.EventHandler(this.txtMatriculaProfesional_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = global::WindowsFormsApp1.Properties.Resources.icono_registrar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(118, 330);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 46);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Registrar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDatos.Image = global::WindowsFormsApp1.Properties.Resources.icono_limpiar;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(217, 330);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(93, 45);
            this.btnLimpiarDatos.TabIndex = 10;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::WindowsFormsApp1.Properties.Resources.icono_salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(910, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 40);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbTipoDocProfesional
            // 
            this.cmbTipoDocProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocProfesional.FormattingEnabled = true;
            this.cmbTipoDocProfesional.Location = new System.Drawing.Point(205, 114);
            this.cmbTipoDocProfesional.Name = "cmbTipoDocProfesional";
            this.cmbTipoDocProfesional.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoDocProfesional.TabIndex = 3;
            this.cmbTipoDocProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocProfesional_SelectedIndexChanged);
            // 
            // mskNumeroDocumentoProfesional
            // 
            this.mskNumeroDocumentoProfesional.Location = new System.Drawing.Point(205, 144);
            this.mskNumeroDocumentoProfesional.Mask = "99999999";
            this.mskNumeroDocumentoProfesional.Name = "mskNumeroDocumentoProfesional";
            this.mskNumeroDocumentoProfesional.Size = new System.Drawing.Size(68, 20);
            this.mskNumeroDocumentoProfesional.TabIndex = 4;
            this.mskNumeroDocumentoProfesional.ValidatingType = typeof(int);
            this.mskNumeroDocumentoProfesional.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNumeroDocumentoProfesional_MaskInputRejected);
            // 
            // lblAltaProfesional
            // 
            this.lblAltaProfesional.AutoSize = true;
            this.lblAltaProfesional.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaProfesional.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.lblAltaProfesional.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAltaProfesional.Location = new System.Drawing.Point(32, 9);
            this.lblAltaProfesional.Name = "lblAltaProfesional";
            this.lblAltaProfesional.Size = new System.Drawing.Size(298, 29);
            this.lblAltaProfesional.TabIndex = 22;
            this.lblAltaProfesional.Text = "Añadir nuevo profesional";
            this.lblAltaProfesional.Click += new System.EventHandler(this.lblAltaProfesional_Click);
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
            this.numerodoc,
            this.matricula});
            this.grdProfesional.Location = new System.Drawing.Point(445, 31);
            this.grdProfesional.Name = "grdProfesional";
            this.grdProfesional.ReadOnly = true;
            this.grdProfesional.Size = new System.Drawing.Size(485, 292);
            this.grdProfesional.TabIndex = 14;
            this.grdProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // numerodoc
            // 
            this.numerodoc.DataPropertyName = "numDoc";
            this.numerodoc.HeaderText = "Numero de Documento";
            this.numerodoc.Name = "numerodoc";
            this.numerodoc.ReadOnly = true;
            this.numerodoc.Width = 140;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matricula_Cirujano";
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::WindowsFormsApp1.Properties.Resources.icono_baja;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(635, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 45);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Image = global::WindowsFormsApp1.Properties.Resources.icono_modificar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(316, 330);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 46);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // altaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_Profesionales;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 431);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdProfesional);
            this.Controls.Add(this.lblAltaProfesional);
            this.Controls.Add(this.mskNumeroDocumentoProfesional);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtMatriculaProfesional);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.mskFechaNacimientoProfesional);
            this.Controls.Add(this.cmbTipoDocProfesional);
            this.Controls.Add(this.txtTelefonoProfesional);
            this.Controls.Add(this.txtEmailProfesional);
            this.Controls.Add(this.txtApellidoProfesional);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTipoDoc);
            this.Name = "altaProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Profesional";
            this.Load += new System.EventHandler(this.altaProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.TextBox txtApellidoProfesional;
        private System.Windows.Forms.TextBox txtEmailProfesional;
        private System.Windows.Forms.TextBox txtTelefonoProfesional;
        private System.Windows.Forms.MaskedTextBox mskFechaNacimientoProfesional;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatriculaProfesional;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipoDocProfesional;
        private System.Windows.Forms.MaskedTextBox mskNumeroDocumentoProfesional;
        private System.Windows.Forms.Label lblAltaProfesional;
        private System.Windows.Forms.DataGridView grdProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}