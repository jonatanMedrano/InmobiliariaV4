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
    public partial class frmClsDpto : Form
    {
        private Dpto dpto;
        public frmClsDpto(Dpto d, bool b)
        {
            InitializeComponent();
            if (d != null)
                cargarDpto(d);
        }

        private void cargarDpto(Dpto d)
        {

            try
            {
                this.textBoxCalle.Text = d.Calle;
                this.textBoxNumero.Text = d.Nro.ToString();
                this.textBoxLocalidad.Text = d.Localidad;
                this.textBoxPartido.Text = d.Partido;
                this.textBoxProvincia.Text = d.Provincia;
                this.textBoxTotalM2.Text = d.M2Cubiertos.ToString();
                this.textBoxPiso.Text = d.NroPiso.ToString();
                this.textBoxDpto.Text = d.NroDpto.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBoxProvincia_TextChanged(object sender, EventArgs e)
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
            int p = int.Parse(this.textBoxPiso.Text);
            string d = this.textBoxDpto.Text;

            dpto = new Dpto(calle, nro, localidad, partido, provincia,m2, p, d);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dpto = null;
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public Dpto DptoReturn
        {
            get { return this.dpto; }
        }

    }
}
