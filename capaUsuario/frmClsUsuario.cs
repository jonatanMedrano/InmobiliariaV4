using capaNegocio;
using System;
using System.Windows.Forms;

namespace capaUsuario
{
    public partial class frmClsUsuario : Form
    {
        protected Usuario usu;
        protected int ultimo = 0;

        public frmClsUsuario()
        {
            InitializeComponent();
        }

        public Usuario Usu
        {
            get { return usu; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_controles();
        }
        //Limpiar valores en componentes.
        private void Limpiar_controles()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtDni.Text = "";
            this.cmbCalle.Text = "";
            this.txtAltura.Text = "0";
            this.cmbLocalidad.Text = "";
            this.cmbPartido.Text = "";
            this.btnActualizar.Enabled = false;
            this.btnIngresar.Enabled = true;
            this.btnEliminar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.btnIngresar.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
