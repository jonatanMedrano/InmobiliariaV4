using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaUsuario
{
    public partial class frmClsCasa : Form
    {
        private Casa casa;
        public frmClsCasa(Casa c, bool b)
        {
            InitializeComponent();

            if (c != null)
                cargarCasa(c);
        }

        private void cargarCasa(Casa c)
        {

       try
         {
            this.textBoxCalle.Text = c.Calle;
            this.textBoxNumero.Text = c.Nro.ToString() ;
            this.textBoxLocalidad.Text = c.Localidad;
            this.textBoxPartido.Text = c.Partido;
            this.textBoxProvincia.Text = c.Provincia;
            this.textBoxTotalM2.Text = c.M2Terreno.ToString();
            this.textBoxM2Cubiertos.Text = c.M2Cubiertos.ToString();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBoxCalle_TextChanged(object sender, EventArgs e)
        {

        }

        public Casa Cas
        {
            get { return this.casa; }
        }

        private void frmClsCasa_Load(object sender, EventArgs e)
        {

        }

        private void botAgregar_Click(object sender, EventArgs e)
        {

            string calle = this.textBoxCalle.Text;
            int nro = int.Parse(this.textBoxNumero.Text);
            string localidad = this.textBoxLocalidad.Text;
            string partido = this.textBoxPartido.Text;
            string provincia = this.textBoxProvincia.Text;
            int m2 = int.Parse(this.textBoxTotalM2.Text);
            int m2Cu = int.Parse(this.textBoxM2Cubiertos.Text);

            casa = new Casa(calle, nro, localidad, partido, provincia, m2Cu, m2);

            this.Close();

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            casa = null;
            this.Close();
        }
    }




}
