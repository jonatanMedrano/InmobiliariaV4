using capaNegocio;
using System;
using System.Windows.Forms;

namespace capaUsuario
{
    public partial class frmClsCliente : capaUsuario.frmClsUsuario
    {
        //private Inmobiliaria inmo;

        public frmClsCliente(Usuario u, bool c)
        {
            InitializeComponent();
            if (c)
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
            if (u != null)
                CargarUsuario(u);

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroCli.Text = "";
            this.txtNombre.Focus();
        }
        private void dtgViewInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnIngresar.Enabled = false;

                txtNombre.Text = dtgViewTabla.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dtgViewTabla.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDni.Text = dtgViewTabla.CurrentRow.Cells["Dni"].Value.ToString();
                cmbCalle.Text = dtgViewTabla.CurrentRow.Cells["Calle"].Value.ToString();
                txtAltura.Text = dtgViewTabla.CurrentRow.Cells["Altura"].Value.ToString();
                cmbLocalidad.Text = dtgViewTabla.CurrentRow.Cells["Localidad"].Value.ToString();
                cmbPartido.Text = dtgViewTabla.CurrentRow.Cells["Partido"].Value.ToString();

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Ingresar un nuevo Cliente.
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNombre.Text;
                string ape = txtApellido.Text;
                int dni = int.Parse(txtDni.Text);
                string ce = cmbCalle.Text;
                int al = int.Parse(txtAltura.Text);
                string loc = cmbLocalidad.Text;
                string par = cmbPartido.Text;
                string cod = "cli" + ultimo++.ToString();
                usu = new Cliente(nom, ape, dni, ce, al, loc, par, cod);

                MessageBox.Show("Se ingreso correctamente el Cliente:" + cod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Encabezado()
        {
            try
            {
                //Crear columnas. Esto se elimina con datos almacenados en tablas.
                dtgViewTabla.Columns.Add("nombre", "Nombre");
                dtgViewTabla.Columns.Add("apellido", "Apellido");
                dtgViewTabla.Columns.Add("dni", "Dni");
                dtgViewTabla.Columns.Add("calle", "Calle");
                dtgViewTabla.Columns.Add("altura", "Altura");
                dtgViewTabla.Columns.Add("localidad", "Localidad");
                dtgViewTabla.Columns.Add("partido", "Partido");
                dtgViewTabla.Columns.Add("cli_legajo", "cli_legajo");

                //Genero un Cliente para agregar a Clase Usuarios.
                //dtgViewTabla.Rows.Add("Juan","Justo",555,"Pueyrredon",1940,"Hurlingham","Hurlingham","cle-0001");

                //Usuario u = usu;
                //listaUsuarios = usu;

                //inmo.AgregarUsuario(u);
                //dtgViewTabla.DataSource = null;
                //dtgViewTabla.DataSource = inmo.ListaUsuarios;
                //dtgViewTabla.ClearSelection();

                btnIngresar.Enabled = true;

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            { }
        }
        private void Informacion()
        {
            string nom = "Juan";
            string ape = "Justo";
            int dni = 555;
            string ce = "Pueyrredon";
            int al = 1940;
            string loc = "Hurlingham";
            string par = "Moron";
            string cod = "cli-" + ultimo++;
            usu = new Cliente(nom, ape, dni, ce, al, loc, par, cod);
        }
        private void CargarUsuario(Usuario u)
        {
            try
            {
                txtNombre.Text = u.Nombre;
                txtApellido.Text = u.Apellido;
                txtDni.Text = u.Dni.ToString();
                cmbCalle.Text = u.Calle;
                txtAltura.Text = u.Altura.ToString();
                cmbLocalidad.Text = u.Localidad;
                cmbPartido.Text = u.Partido;
#pragma warning disable CS0219 // La variable 'cod' está asignada pero su valor nunca se usa
                string cod = "0";
#pragma warning restore CS0219 // La variable 'cod' está asignada pero su valor nunca se usa

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
