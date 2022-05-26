using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AccesoADatos;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.ABM
{
    public partial class ProcesoTurnoXPaciente : Form
    {
        public ProcesoTurnoXPaciente()
        {
            InitializeComponent();
        }


        private void ObtenerUltimoIdEspecialidad()
        {

            int id = AdEspecialidad.ObtenerUltimoIdEspecialidad();
            txtIdEspecialidad.Text = (id + 1).ToString();
        }

        private void ObtenerUltimoIdTurno()
        {

            int id = AdTurnos.ObtenerUltimoIdTurno();
            txtNumTurno.Text = (id + 1).ToString();
        }

        private void ProcesoTurnoXPaciente_Load(object sender, EventArgs e)
        {
            ObtenerUltimoIdTurno();
            ObtenerUltimoIdEspecialidad();
            CargarFecha();
            CargarGrillaProfesional();
            CargarComboEspecialidades();
            CargarComboTiposDocumentos();
            CargarComboObrasSociales();
            LimpiarCampos();
        }

        private bool ComprobarCampos()
        {
            if (txtNombrePaciente.Text.Equals("") || txtApellidoPaciente.Text.Equals("") || txtDniPaciente.Text.Equals("")
                || txtNombreProfesional.Text.Equals("") || txtApellidoProfesional.Text.Equals("") || txtNumDocProfesional.Text.Equals("")
                || txtPrecioAtencion.Text.Equals("") || mskFechaTurno.Text.Equals("") || mskFechaTurno.Text.Equals("  /  /       :") || mskFechaTurno.Text.Length < 12 || txtPrecioAtencion.Text.Equals("") || txtPrecioDescuento.Text.Equals(""))

            {
                return true;
            }
            
            else
            {
                return false; 
            }      

            if (mskFechaTurno.Text.Length < 10)
            {
                MessageBox.Show("Error, ingresa una fecha y hora válidas");
            }
        }
        private void CargarComboTiposDocumentos()
        {

            try
            {

                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbTipoDocProfesional.DataSource = AdOtros.ObtenerTabla("tipo_Documento");
                cmbTipoDocProfesional.DisplayMember = "nombre";
                cmbTipoDocProfesional.ValueMember = "cod";
                cmbTipoDocProfesional.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar combo tipo documentos.");

            }
        }

        private void CargarGrillaProfesional()
        {
            try
            {
                grdProfesionales.DataSource = AdProfesional.ObtenerDatosProfesional();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }

        }

        private void CargarFecha()
        {
            lblFechaHoy.Text = DateTime.Now.ToLongDateString();
        }

        private Arancel ObtenerAranceles(string idara)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Arancel ara = new Arancel();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from aranceles WHERE idArancel = @idArancel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idArancel", idara);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ara.TipoDocDeProfesional = int.Parse(dr["tipoDocProfesional"].ToString());
                    ara.NumDocDeProfesional = dr["numDocProfesional"].ToString();
                    ara.FechaDeInicioVigencia = DateTime.Parse(dr["fecha_Inicio_Vigencia"].ToString());
                    ara.FechaDeFinVigencia = DateTime.Parse(dr["fecha_Fin_Vigencia"].ToString());
                    ara.PrecioDeArancel = dr["Precio"].ToString();
                    ara.IdDeAranceles = int.Parse(dr["idArancel"].ToString());

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return ara;
        }

        private void grdProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdProfesionales.Rows[indice];
            string documento = filaseleccionada.Cells["dni"].Value.ToString();           
            Profesional pro = ObtenerProfesional(documento);
            CargarCampos(pro);
            Arancel ara = ObtenerArancel(documento);
            CargarCamposArancel(ara);
            cmbEspecialidad.Enabled = true;
            if (chkObraSocial.Checked)
            {
                cmbObraSocial.Enabled = true;
                int precioDescuento = int.Parse(txtPrecioDescuento.Text);
                int precio_total = precioDescuento / 2;
                txtPrecioAtencion.Text = precio_total.ToString();
            }

            else
            {
                txtPrecioAtencion.Text = ara.PrecioDeArancel;
            }

            if(chkSinObraSocial.Checked)
            {
                txtPrecioAtencion.Text = ara.PrecioDeArancel;
            }

            else
            {
                int precioDescuento = int.Parse(txtPrecioDescuento.Text);
                int precio_total = precioDescuento / 2;
                txtPrecioAtencion.Text = precio_total.ToString();
            }

            

        }

        private void CargarComboEspecialidades()
        {
            try
            {

                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbEspecialidad.DataSource = AdOtros.ObtenerTabla("especialidades");
                cmbEspecialidad.DisplayMember = "Nombre";
                cmbEspecialidad.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar las especialidades.");

            }
        }

        private void CargarComboObrasSociales()
        {
            try
            {
                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbObraSocial.DataSource = AdOtros.ObtenerTabla("obrasSociales");
                cmbObraSocial.DisplayMember = "nombre";
                cmbObraSocial.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar las Obras Sociales.");

            }
        }

        private Profesional ObtenerProfesional(string documento)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Profesional pro = new Profesional();
            CargarCampos(pro);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from profesionales where numDoc like @numDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDoc", documento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    pro.NombreProfesional = dr["nombre"].ToString();
                    pro.ApellidoProfesional = dr["apellido"].ToString();
                    pro.NumeroDeDocumentoProfesional = dr["numDoc"].ToString();
                    pro.TipoDocumentoProfesional = int.Parse(dr["tipoDoc"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return pro;
        }



        private Arancel ObtenerArancel(string documento)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Arancel ara = new Arancel();
            CargarCamposArancel(ara);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select precio from aranceles where numDocProfesional like @numDocProfesional";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDocProfesional", documento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ara.PrecioDeArancel = dr["precio"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return ara;
        }



        private void CargarCampos(Profesional pro)
        {
            LimpiarCamposProfesional();
            txtNombreProfesional.Text = pro.NombreProfesional;
            txtApellidoProfesional.Text = pro.ApellidoProfesional;
            txtNumDocProfesional.Text = pro.NumeroDeDocumentoProfesional;
            txtTipoDocProfesional.Text = pro.TipoDocumentoProfesional.ToString();     
        }


        private void CargarCamposArancel(Arancel ara)
        {
            txtPrecioDescuento.Text = ara.PrecioDeArancel;
            if (txtPrecioDescuento.Text.Equals(""))
            {
                txtPrecioDescuento.Text = "0"; 
            }

            if (txtPrecioAtencion.Text.Equals(""))
            {
                txtPrecioAtencion.Text = "0";
            }
        }

        private void LimpiarCamposProfesional()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtNumDocProfesional.Text = "";
            txtTipoDocProfesional.Text = "";

        }

        private void LimpiarCampos()
        {
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            txtDniPaciente.Text = "";
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtNumDocProfesional.Text = "";
            cmbEspecialidad.Text = "";
            txtPrecioDescuento.Text = "0";
            cmbObraSocial.Text = "";
            mskFechaTurno.Text = "";
            txtTipoDocProfesional.Text = "";
            txtIdEspecialidad.Text = "";
            txtIDObraSocial.Text = "";
            cmbEspecialidad.Enabled = false;
            cmbObraSocial.Enabled = false;
            txtPrecioAtencion.Text = "0";
        }

        private void cmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AdObraSocial.ObtenerObraSocialXNombre(cmbObraSocial.Text.Trim());
                if (tablaResultado.Rows.Count >= 0)
                {
                    txtIDObraSocial.Text = tablaResultado.Rows[0][0].ToString();
                }

                else
                {
                    MessageBox.Show("Obra Social no encontrada!");
                    txtIDObraSocial.Text = "";
                    cmbObraSocial.Text = "";

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataTable tablaResultado = AdPaciente.ObtenerPacienteXDocumento(txtDniPaciente.Text.Trim());
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombrePaciente.Text = tablaResultado.Rows[0][2].ToString();
                    txtApellidoPaciente.Text = tablaResultado.Rows[0][3].ToString();
                    txtTipoDocPaciente.Text = tablaResultado.Rows[0][0].ToString();
                    chkObraSocial.Enabled = true;
                    chkSinObraSocial.Enabled = true;
                    mskFechaTurno.Enabled = true;

                }

                else
                {
                    MessageBox.Show("Paciente no encontrado!");
                    txtNombrePaciente.Focus();
                    txtNombrePaciente.Text = "";
                    txtApellidoPaciente.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el Paciente!");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
      
        {
            bool comprobacion = ComprobarCampos();
            if (comprobacion == false)
            {
                if (txtIDObraSocial.Text.Equals(""))
                {
                    txtIDObraSocial.Text = "0";
                }
                bool resultado = AdTurnos.AltaNuevoTurno(int.Parse(txtNumTurno.Text), txtNombreProfesional.Text, txtApellidoProfesional.Text, txtNombrePaciente.Text, txtApellidoPaciente.Text, int.Parse(txtNumDocProfesional.Text), int.Parse(txtTipoDocProfesional.Text), int.Parse(txtDniPaciente.Text), int.Parse(txtTipoDocPaciente.Text), int.Parse(txtIDObraSocial.Text), int.Parse(txtPrecioDescuento.Text), int.Parse(txtIdEspecialidad.Text), DateTime.Parse(mskFechaTurno.Text));
                comprobacion = true;

                if (resultado)
                {
                    MessageBox.Show("Turno dado de alta con éxito!");
                    chkObraSocial.Checked = false;
                    chkSinObraSocial.Checked = false;
                    chkSinObraSocial.Enabled = false;
                    chkObraSocial.Enabled = false; 
                    LimpiarCampos();
                }

                else
                {
                    MessageBox.Show("Error al dar de alta!");

                }
            }

            else
            {
                MessageBox.Show("Por favor complete todos los campos!");
            }
               
        }

        
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AdEspecialidad.ObtenerEspecialidadXID(cmbEspecialidad.Text.Trim());
                if (tablaResultado.Rows.Count >= 0)
                {
                    txtIdEspecialidad.Text = tablaResultado.Rows[0][0].ToString();
                }

                else
                {
                    MessageBox.Show("Especialidad no encontrada!");
                    txtIdEspecialidad.Text = "";
                    cmbEspecialidad.Text = "";

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show(); 
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void chkObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObraSocial.Checked)
            {
                grdProfesionales.Enabled = true;
                chkSinObraSocial.Enabled = false;
                cmbObraSocial.Enabled = true;
                LimpiarCamposObraSocial();

            }


            else
            {
                chkSinObraSocial.Enabled = true;
                LimpiarCamposObraSocial();
            }

        }

        private void LimpiarCamposObraSocial()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtNumDocProfesional.Text = ""; 
            txtPrecioDescuento.Text = "";
            txtPrecioAtencion.Text = "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinObraSocial.Checked)
            {
                chkObraSocial.Enabled = false;
                cmbObraSocial.Enabled = false;
                grdProfesionales.Enabled = true;
            }
            else
            {
                chkObraSocial.Enabled = true;
            }

        }
    }
    }

