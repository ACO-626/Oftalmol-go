using System;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Form ventanaAgendar = new FormCrearCita();
            ventanaAgendar.Show();
        }

        private void btnReagendarCita_Click(object sender, EventArgs e)
        {
            Form VentanaModificarCita = new FormModificarCita();
            VentanaModificarCita.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Form VentanaConsulta = new FormConsulta();
            VentanaConsulta.Show();
        }
    }
}
