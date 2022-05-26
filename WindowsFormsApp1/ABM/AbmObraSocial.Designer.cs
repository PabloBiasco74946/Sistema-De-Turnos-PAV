
namespace WindowsFormsApp1.ABM
{
    partial class AbmObraSocial
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
            this.grdObraSocial = new System.Windows.Forms.DataGridView();
            this.Id_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAltaProfesional = new System.Windows.Forms.Label();
            this.txtTelefonoObraSocial = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombreObraSocial = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.IdObraSocial = new System.Windows.Forms.Label();
            this.lblEmailObraSocial = new System.Windows.Forms.Label();
            this.txtEmailObraSocial = new System.Windows.Forms.TextBox();
            this.txtIdObraSocial = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdObraSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // grdObraSocial
            // 
            this.grdObraSocial.AllowUserToAddRows = false;
            this.grdObraSocial.AllowUserToDeleteRows = false;
            this.grdObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObraSocial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ObraSocial,
            this.nombre,
            this.RazonSocial,
            this.Email,
            this.telefono});
            this.grdObraSocial.Location = new System.Drawing.Point(416, 55);
            this.grdObraSocial.Name = "grdObraSocial";
            this.grdObraSocial.ReadOnly = true;
            this.grdObraSocial.Size = new System.Drawing.Size(516, 292);
            this.grdObraSocial.TabIndex = 63;
            this.grdObraSocial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdObraSocial_CellContentClick);
            // 
            // Id_ObraSocial
            // 
            this.Id_ObraSocial.DataPropertyName = "id_ObraSocial";
            this.Id_ObraSocial.HeaderText = "ID";
            this.Id_ObraSocial.Name = "Id_ObraSocial";
            this.Id_ObraSocial.ReadOnly = true;
            this.Id_ObraSocial.Width = 30;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "razonSocial";
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 140;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // lblAltaProfesional
            // 
            this.lblAltaProfesional.AutoSize = true;
            this.lblAltaProfesional.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaProfesional.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaProfesional.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAltaProfesional.Location = new System.Drawing.Point(41, 78);
            this.lblAltaProfesional.Name = "lblAltaProfesional";
            this.lblAltaProfesional.Size = new System.Drawing.Size(299, 29);
            this.lblAltaProfesional.TabIndex = 62;
            this.lblAltaProfesional.Text = "Añadir nueva Obra Social";
            // 
            // txtTelefonoObraSocial
            // 
            this.txtTelefonoObraSocial.Location = new System.Drawing.Point(163, 220);
            this.txtTelefonoObraSocial.Name = "txtTelefonoObraSocial";
            this.txtTelefonoObraSocial.Size = new System.Drawing.Size(177, 20);
            this.txtTelefonoObraSocial.TabIndex = 4;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(163, 167);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(177, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtNombreObraSocial
            // 
            this.txtNombreObraSocial.Location = new System.Drawing.Point(163, 140);
            this.txtNombreObraSocial.Name = "txtNombreObraSocial";
            this.txtNombreObraSocial.Size = new System.Drawing.Size(177, 20);
            this.txtNombreObraSocial.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(69, 221);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(82, 19);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(40, 166);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(111, 19);
            this.lblRazonSocial.TabIndex = 53;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(74, 140);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre:";
            // 
            // IdObraSocial
            // 
            this.IdObraSocial.AutoSize = true;
            this.IdObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.IdObraSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdObraSocial.Location = new System.Drawing.Point(118, 248);
            this.IdObraSocial.Name = "IdObraSocial";
            this.IdObraSocial.Size = new System.Drawing.Size(33, 19);
            this.IdObraSocial.TabIndex = 51;
            this.IdObraSocial.Text = "ID:";
            // 
            // lblEmailObraSocial
            // 
            this.lblEmailObraSocial.AutoSize = true;
            this.lblEmailObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailObraSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailObraSocial.Location = new System.Drawing.Point(93, 192);
            this.lblEmailObraSocial.Name = "lblEmailObraSocial";
            this.lblEmailObraSocial.Size = new System.Drawing.Size(58, 19);
            this.lblEmailObraSocial.TabIndex = 50;
            this.lblEmailObraSocial.Text = "Email:";
            // 
            // txtEmailObraSocial
            // 
            this.txtEmailObraSocial.Location = new System.Drawing.Point(163, 193);
            this.txtEmailObraSocial.Name = "txtEmailObraSocial";
            this.txtEmailObraSocial.Size = new System.Drawing.Size(177, 20);
            this.txtEmailObraSocial.TabIndex = 3;
            // 
            // txtIdObraSocial
            // 
            this.txtIdObraSocial.Enabled = false;
            this.txtIdObraSocial.Location = new System.Drawing.Point(163, 249);
            this.txtIdObraSocial.Name = "txtIdObraSocial";
            this.txtIdObraSocial.Size = new System.Drawing.Size(34, 20);
            this.txtIdObraSocial.TabIndex = 5;
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
            this.btnModificar.Location = new System.Drawing.Point(273, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 46);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDatos.Image = global::WindowsFormsApp1.Properties.Resources.icono_limpiar;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(174, 350);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(93, 45);
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
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = global::WindowsFormsApp1.Properties.Resources.icono_registrar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(75, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 46);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Registrar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(643, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 45);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::WindowsFormsApp1.Properties.Resources.icono_salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(875, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 40);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AbmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_obraSocial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 431);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtIdObraSocial);
            this.Controls.Add(this.txtEmailObraSocial);
            this.Controls.Add(this.grdObraSocial);
            this.Controls.Add(this.lblAltaProfesional);
            this.Controls.Add(this.txtTelefonoObraSocial);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNombreObraSocial);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.IdObraSocial);
            this.Controls.Add(this.lblEmailObraSocial);
            this.Name = "AbmObraSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbmObraSocial";
            this.Load += new System.EventHandler(this.AbmObraSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdObraSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Label lblAltaProfesional;
        private System.Windows.Forms.TextBox txtTelefonoObraSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombreObraSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label IdObraSocial;
        private System.Windows.Forms.Label lblEmailObraSocial;
        private System.Windows.Forms.TextBox txtEmailObraSocial;
        private System.Windows.Forms.TextBox txtIdObraSocial;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}