
namespace WindowsFormsApp1.ABM
{
    partial class modificarUsuario
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
            this.grdModificarUsu = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.lblTituloModificarUsuarios = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsu = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdModificarUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // grdModificarUsu
            // 
            this.grdModificarUsu.AllowUserToAddRows = false;
            this.grdModificarUsu.AllowUserToDeleteRows = false;
            this.grdModificarUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdModificarUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombreDeUsuario,
            this.contraseña});
            this.grdModificarUsu.Location = new System.Drawing.Point(-6, -1);
            this.grdModificarUsu.Name = "grdModificarUsu";
            this.grdModificarUsu.ReadOnly = true;
            this.grdModificarUsu.Size = new System.Drawing.Size(393, 258);
            this.grdModificarUsu.TabIndex = 0;
            this.grdModificarUsu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "idUsuario";
            this.idusuario.HeaderText = "ID";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Width = 25;
            // 
            // nombreDeUsuario
            // 
            this.nombreDeUsuario.DataPropertyName = "usuario";
            this.nombreDeUsuario.HeaderText = "Nombre de Usuario";
            this.nombreDeUsuario.Name = "nombreDeUsuario";
            this.nombreDeUsuario.ReadOnly = true;
            this.nombreDeUsuario.Width = 150;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Width = 175;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(452, 101);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(102, 19);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(560, 100);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(142, 20);
            this.txtContraseña1.TabIndex = 2;
            this.txtContraseña1.TextChanged += new System.EventHandler(this.txtContraseña1_TextChanged);
            // 
            // lblTituloModificarUsuarios
            // 
            this.lblTituloModificarUsuarios.AutoSize = true;
            this.lblTituloModificarUsuarios.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloModificarUsuarios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloModificarUsuarios.Location = new System.Drawing.Point(394, 9);
            this.lblTituloModificarUsuarios.Name = "lblTituloModificarUsuarios";
            this.lblTituloModificarUsuarios.Size = new System.Drawing.Size(225, 29);
            this.lblTituloModificarUsuarios.TabIndex = 7;
            this.lblTituloModificarUsuarios.Text = "Modificar usuarios";
            this.lblTituloModificarUsuarios.Click += new System.EventHandler(this.lblTituloModificarUsuarios_Click);
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(560, 138);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(142, 20);
            this.txtContraseña2.TabIndex = 3;
            this.txtContraseña2.TextChanged += new System.EventHandler(this.txtContraseña2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Repetir contraseña:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(560, 65);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(392, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de usuario:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdUsu
            // 
            this.txtIdUsu.Enabled = false;
            this.txtIdUsu.Location = new System.Drawing.Point(560, 170);
            this.txtIdUsu.Name = "txtIdUsu";
            this.txtIdUsu.Size = new System.Drawing.Size(34, 20);
            this.txtIdUsu.TabIndex = 4;
            this.txtIdUsu.TextChanged += new System.EventHandler(this.txtIdUsu_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gray;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Image = global::WindowsFormsApp1.Properties.Resources.icono_modificar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(516, 204);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 44);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.icono_salir;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(634, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIdUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloModificarUsuarios);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grdModificarUsu);
            this.Name = "modificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar usuarios";
            this.Load += new System.EventHandler(this.modificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdModificarUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdModificarUsu;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Label lblTituloModificarUsuarios;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUsu;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button2;
    }
}