using System;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormModifica : Form
    {
        public FormModifica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbModificacion_Enter(object sender, EventArgs e)
        {
            if(txtbModificacion.Text=="Modificacion")
            {
                txtbModificacion.Text = "";
            }
        }

        private void txtbModificacion_Leave(object sender, EventArgs e)
        {
            if(txtbModificacion.Text=="")
            {
                txtbModificacion.Text = "Modificacion";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
