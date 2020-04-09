#region BIBLIOTECAS
using System;
using System.Windows.Forms;
#endregion

namespace Oftalmol_Go
{
    public partial class FormModificarCita : Form
    {
        #region INICIALIZACION DE VENTANA
        public FormModificarCita()
        {
            InitializeComponent();
        }
        #endregion
        #region BOTONES
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
#endregion
    }
}
