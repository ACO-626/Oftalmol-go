#region BIBLIOTECAS
using System;
using System.Windows.Forms;
#endregion

namespace Oftalmol_Go
{
    public partial class FormMenu : Form
    {
        #region INICIALIZACIÓN DE VENTANA
        public FormMenu()
        {
            InitializeComponent();
        }
        #endregion
        #region BOTONES
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
        #endregion

    }
}
