using System;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormCrearCita : Form
    {
        public FormCrearCita()
        {
            InitializeComponent();
        }

        //Comportamiento de Nombre paciente
        private void txtbPaciente_Enter(object sender, EventArgs e)
        {
            if (txtbPaciente.Text == "Nombre")
            {
                txtbPaciente.Text = "";
            }

        }
        private void txtbPaciente_Leave(object sender, EventArgs e)
        {
            if(txtbPaciente.Text=="")
            {
                txtbPaciente.Text = "Nombre";
            }
            
        }

        //Fin de sección de Paciente nombre
        //
        //

        private void lbSimpleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Comportamiento de caja teléfono
        private void txtbTel_Enter(object sender, EventArgs e)
        {
            if (txtbTel.Text == "Tel.")
            {
                txtbTel.Text = "";
                
            }
        }

        private void txtbTel_Leave(object sender, EventArgs e)
        {
            if (txtbTel.Text == "")
            {
                txtbTel.Text = "Tel.";
            }
        }
        //Fin de comportamiento de caja teléfono
        //
        //Comportamiento caja de texto correo
        private void txtbmail_Enter(object sender, EventArgs e)
        {
            if (txtbmail.Text == "Correo")
            {
                txtbmail.Text = "";
            }
        }

        private void txtbmail_Leave(object sender, EventArgs e)
        {
            if (txtbmail.Text == "")
            {
                txtbmail.Text = "Correo";
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if(txtbPaciente.Text=="Nombre" || txtbTel.Text=="Tel.")
            {
                MessageBox.Show("FALTAN DATOS POR LLENAR", "ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("REGISTRO EXITOSO EN LA BASE DE DATOS", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //Fin de comportamiento de caja de texto correo



    }
}
