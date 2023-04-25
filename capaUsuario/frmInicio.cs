using System;
using System.Windows.Forms;

namespace capaUsuario
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void OpenFormHijo(object formhija)
        {
            if (this.pnlFill.Controls.Count > 0)
                this.pnlFill.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlFill.Controls.Add(fh);
            this.pnlFill.Tag = fh;
            fh.Show();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new frmViviendaIni());
        }

        private void btnMenu6_Click(object sender, EventArgs e)
        {
            OpenFormHijo(new frmUserIni());
        }
    }
}
