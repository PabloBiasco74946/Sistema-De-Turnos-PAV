
namespace WindowsFormsApp1.ABM
{
    partial class bajaUsuarios
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grdEliminarUsu = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtIdUsu = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(263, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 37);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grdEliminarUsu
            // 
            this.grdEliminarUsu.AllowUserToAddRows = false;
            this.grdEliminarUsu.AllowUserToDeleteRows = false;
            this.grdEliminarUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEliminarUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombreDeUsuario,
            this.contraseña});
            this.grdEliminarUsu.Location = new System.Drawing.Point(164, 53);
            this.grdEliminarUsu.Name = "grdEliminarUsu";
            this.grdEliminarUsu.ReadOnly = true;
            this.grdEliminarUsu.Size = new System.Drawing.Size(395, 258);
            this.grdEliminarUsu.TabIndex = 12;
            this.grdEliminarUsu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEliminarUsu_CellContentClick);
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
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(257, 9);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(214, 33);
            this.lblEliminar.TabIndex = 19;
            this.lblEliminar.Text = "Eliminar Usuario";
            // 
            // txtIdUsu
            // 
            this.txtIdUsu.Enabled = false;
            this.txtIdUsu.Location = new System.Drawing.Point(715, 386);
            this.txtIdUsu.Name = "txtIdUsu";
            this.txtIdUsu.Size = new System.Drawing.Size(10, 20);
            this.txtIdUsu.TabIndex = 27;
            this.txtIdUsu.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(715, 386);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(10, 20);
            this.txtContraseña.TabIndex = 23;
            this.txtContraseña.Visible = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(715, 386);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(10, 20);
            this.txtNombreUsuario.TabIndex = 22;
            this.txtNombreUsuario.Visible = false;
            // 
            // bajaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.txtIdUsu);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grdEliminarUsu);
            this.Name = "bajaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.Load += new System.EventHandler(this.bajaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView grdEliminarUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtIdUsu;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
    }
}