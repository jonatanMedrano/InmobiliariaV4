using capaNegocio;
using System;
using System.Windows.Forms;

namespace capaUsuario
{
    public partial class frmUserIni : Form
    {
        private Inmobiliaria inmo;

        public frmUserIni()
        {
            inmo = Inmobiliaria.Recuperar();
            InitializeComponent();
            //Cargar List y DataView.
            CargarCompView();

            //Completar encabezado.
            //Encabezado();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Usuario u = null;
            frmClsUsuario agregar = new frmClsCliente(u, true);
            CargarInfo(agregar);
        }
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            //frmVendedor vende = new frmVendedor();
            //vende.ShowDialog();
        }

        private void CargarInfo(frmClsUsuario agregar)
        {
            agregar.ShowDialog();
            Usuario usu = agregar.Usu;
            if (usu != null)
            {
                //Cargar el ListBox
                inmo.AgregarUsuario(usu);

                //Cargar List y DataView.
                CargarCompView();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario)lstTabla.SelectedItem;
            if (u != null)
            {
                inmo.EliminarUsuario(u);

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono un Cliente.");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario)lstTabla.SelectedItem;
            if (u != null)
            {
                frmClsUsuario agregar = new frmClsCliente(u, false);
                agregar.ShowDialog();

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono un Cliente.");
        }
        private void Encabezado()
        {
            try
            {
                dtgViewTabla.Columns.Add("nombre", "Nombre");
                dtgViewTabla.Columns.Add("apellido", "Apellido");
                dtgViewTabla.Columns.Add("dni", "Dni");
                dtgViewTabla.Columns.Add("calle", "Calle");
                dtgViewTabla.Columns.Add("altura", "Altura");
                dtgViewTabla.Columns.Add("localidad", "Localidad");
                dtgViewTabla.Columns.Add("partido", "Partido");
                dtgViewTabla.Columns.Add("cli_legajo", "cli_legajo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inmo.guardar())
                MessageBox.Show("SE ALMACENO CORRECTAMENTE EN .dat");
            else
                MessageBox.Show("ERROR AL INTENTAR GAURDAR");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCompView()
        {
            //Cargar ListBox.
            lstTabla.DataSource = null;
            lstTabla.DataSource = inmo.ListaUsuarios;
            lstTabla.ClearSelected();

            //Cargar DataGridView.
            dtgViewTabla.DataSource = null;
            dtgViewTabla.DataSource = inmo.ListaUsuarios;
            dtgViewTabla.ClearSelection();
        }

        private void dtgViewTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
