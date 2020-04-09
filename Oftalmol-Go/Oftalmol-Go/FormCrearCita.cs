#region BIBLIOTECAS
//Bibliotecas básicas

using System;
using System.Windows.Forms;

//Bibliotecas de BD

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
#endregion

namespace Oftalmol_Go
{
    public partial class FormCrearCita : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        

        #region INICIALIZACIÓN BÁSICA DE VENTANA
        public FormCrearCita()
        {
            InitializeComponent();
        }
        #endregion
        
        #region COMPORTAMIENTO DE TEXTBOX
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
        #endregion
        
        #region BOTONES
        private void lbSimpleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region MANEJO DE EXCEPCIONES AL INGRESAR DATOS DE CITA
        private async void btnAgendarCita_Click(object sender, EventArgs e)
        {

           
            if (txtbPaciente.Text=="Nombre" || txtbTel.Text=="Tel.")
            {
                MessageBox.Show("FALTAN DATOS POR LLENAR", "ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                client = new FireSharp.FirebaseClient(config);
                var cita = new Cita
                {
                    //citaId
                    //day
                    //mounth
                    //year
                    nombrePaciente = txtbPaciente.Text,
                    telefonoPciente = txtbTel.Text,
                    correoPaciente = txtbmail.Text
                };

                SetResponse response = await client.SetTaskAsync("PACIENTES/" + txtbPaciente.Text, cita);
                Cita resultados = response.ResultAs<Cita>();

                MessageBox.Show("Registro exitoso en la base de datos", "BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
         
        }
        #endregion

        #region PARAMETROS DE INICIALIZACIÓN DE BASE DE DATOS EN FIREBASE
        public void FormCrearCita_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
