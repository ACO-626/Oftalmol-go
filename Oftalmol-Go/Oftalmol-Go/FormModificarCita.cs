using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormModificarCita : Form
    {
        public FormModificarCita()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModFecha_Click(object sender, EventArgs e)
        {
            Form VentanaModificacion = new FormModifica();
            VentanaModificacion.Show();
        }

        private void btnModNombre_Click(object sender, EventArgs e)
        {
            Form VentanaModificacion = new FormModifica();
            VentanaModificacion.Show();
        }

        private void btnModTel_Click(object sender, EventArgs e)
        {
            Form VentanaModificacion = new FormModifica();
            VentanaModificacion.Show();
        }

        private void btnModCorreo_Click(object sender, EventArgs e)
        {
            Form VentanaModificacion = new FormModifica();
            VentanaModificacion.Show();
        }
    }
}
