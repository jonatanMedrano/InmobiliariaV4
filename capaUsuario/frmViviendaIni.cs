using capaNegocio;
using System;
using System.Windows.Forms;

namespace capaUsuario
{
    public partial class frmViviendaIni : Form
    {
        private Inmobiliaria inmoCasa;
        private Inmobiliaria inmoDpto;

        public frmViviendaIni()
        {
            inmoCasa = Inmobiliaria.RecuperarCasa();
            inmoDpto = Inmobiliaria.RecuperarDpto();
            InitializeComponent();
            //Cargar List y DataView.
            CargarCompView();

            //Completar encabezado.
            //Encabezado();
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Casa c = null;
            frmClsCasa agregar = new frmClsCasa(c, true);
            CargarInfo(agregar);
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            Dpto d = null;
            frmClsDpto agregar = new frmClsDpto(d, true);
            CargarInfoDpto(agregar);
        }

        private void CargarInfo(frmClsCasa agregar)
        {
            agregar.ShowDialog();
            Casa cas = agregar.Cas;
            if (cas != null)
            {
                //Cargar el ListBox
                inmoCasa.agregarCasa(cas);

                //Cargar List y DataView.
                CargarCompView();
            }
        }

        private void CargarInfoDpto(frmClsDpto agregar)
        {
            agregar.ShowDialog();
            Dpto dep = agregar.DptoReturn;
            if (dep != null)
            {
                //Cargar el ListBox
                inmoDpto.agregarDpto(dep);

                //Cargar List y DataView.
                CargarCompView();
            }
        }


        private void btnEliminarCasa_Click(object sender, EventArgs e)
        {
            Casa c = (Casa)lstTablaCasa.SelectedItem;
            if (c != null)
            {
                inmoCasa.eliminarCasa(c);

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono una Casa.");
        }

        private void btnActualizarCasa_Click(object sender, EventArgs e)
        {
            Casa c = (Casa)lstTablaCasa.SelectedItem;
            if (c != null)
            {
                frmClsCasa agregar = new frmClsCasa(c, true);
                agregar.ShowDialog();

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono una Casa.");
        }

        /*    private void Encabezado()
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
            }*/

        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inmoCasa.guardarCasa())
                MessageBox.Show("SE ALMACENO CORRECTAMENTE La casa");
            else
                MessageBox.Show("ERROR AL INTENTAR GAURDAR");
           
            if (inmoDpto.guardarDpto())
                MessageBox.Show("SE ALMACENO CORRECTAMENTE el Dpto");
            else
                MessageBox.Show("ERROR AL INTENTAR GAURDAR");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCompView()
        {
            //Cargar ListBox Casa
            lstTablaCasa.DataSource = null;
            lstTablaCasa.DataSource = inmoCasa.Casas;
            lstTablaCasa.ClearSelected();

            //Cargar ListBox Dpto
            listBoxDpto.DataSource = null;
            listBoxDpto.DataSource = inmoDpto.Dptos;
            listBoxDpto.ClearSelected();

            //Cargar DataGridView.
            //   dtgViewTabla.DataSource = null;
            //   dtgViewTabla.DataSource = inmo.ListaUsuarios;
            //   dtgViewTabla.ClearSelection();
        }

        private void dtgViewTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butActDpto_Click(object sender, EventArgs e)
        {
            Dpto d = (Dpto)listBoxDpto.SelectedItem;
            if (d != null)
            {
                frmClsDpto agregar = new frmClsDpto(d, true);
                agregar.ShowDialog();

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono un Departamento.");
        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDpto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butEliminaDpto_Click(object sender, EventArgs e)
        {
            Dpto d = (Dpto) listBoxDpto.SelectedItem;
            if (d != null)
            {
                inmoDpto.eliminarDpto(d);

                //Cargar List y DataView.
                CargarCompView();
            }
            else
                MessageBox.Show("No selecciono un Departamento.");
        }
    }
}
