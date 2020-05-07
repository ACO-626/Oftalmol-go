
#region BIBLIOTECAS
using System;
using System.Windows.Forms;
//BIBLIOTECAS PARA BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion
namespace Oftalmol_Go
{
    public partial class FormLogin : Form
    {

        #region INSTANCIAS DE BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        #endregion

        #region INICIALIZACIÓN DE VENTANA
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLimpiar_Click(object sender, EventArgs e)
        {
            txtbPassword.Text = "CONTRASEÑA";
            txtbPassword.PasswordChar = '\0';
            txtbUser.Text = "USUARIO";
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            var usuario = new Usuario
            {
                userID = "1",
                user = txtbUser.Text,
                password = txtbPassword.Text
            };
            FirebaseResponse recuperacion = await client.GetTaskAsync("USUARIOS/1");
            Usuario obj = recuperacion.ResultAs<Usuario>();
            if(obj.user==txtbUser.Text&&obj.password==txtbPassword.Text)
            {
                Form VentanaMenu = new FormMenu(txtbUser.Text);
                this.Close();
                VentanaMenu.Show();
            }else
            {
                MessageBox.Show("Acceso denegado, usuario o contraseña inválidos", "ACCESO DENEGADO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        #endregion

        #region COMPORTAMIENTO DE LOS TEXBOX
        private void txtbUser_Enter(object sender, EventArgs e)
        {
            if(txtbUser.Text=="USUARIO")
            {
                txtbUser.Text = "";
            }                   
        }
        private void txtbUser_Leave(object sender, EventArgs e)
        {
            if (txtbUser.Text == "")
            {
                txtbUser.Text = "USUARIO";
            }
        }
        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            if(txtbPassword.Text=="CONTRASEÑA")
            {
                txtbPassword.Text = "";
                this.txtbPassword.PasswordChar = '*';
            }
        }
        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if(txtbPassword.Text=="")
            {
                this.txtbPassword.PasswordChar = '\0';
                txtbPassword.Text = "CONTRASEÑA";
            }
          
        }


        #endregion


    }
}
