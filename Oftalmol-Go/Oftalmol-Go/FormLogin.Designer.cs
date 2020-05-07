namespace Oftalmol_Go
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbLimpiar = new System.Windows.Forms.Label();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(737, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(308, 361);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 56);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelar.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCancelar.Location = new System.Drawing.Point(400, 420);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(48, 13);
            this.lbCancelar.TabIndex = 2;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbLimpiar
            // 
            this.lbLimpiar.AutoSize = true;
            this.lbLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimpiar.ForeColor = System.Drawing.Color.Green;
            this.lbLimpiar.Location = new System.Drawing.Point(343, 420);
            this.lbLimpiar.Name = "lbLimpiar";
            this.lbLimpiar.Size = new System.Drawing.Size(40, 13);
            this.lbLimpiar.TabIndex = 3;
            this.lbLimpiar.Text = "Limpiar";
            this.lbLimpiar.Click += new System.EventHandler(this.lbLimpiar_Click);
            // 
            // txtbUser
            // 
            this.txtbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUser.Font = new System.Drawing.Font("Simplex_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUser.Location = new System.Drawing.Point(261, 249);
            this.txtbUser.Multiline = true;
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(246, 30);
            this.txtbUser.TabIndex = 4;
            this.txtbUser.Text = "USUARIO";
            this.txtbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbUser.WordWrap = false;
            this.txtbUser.Enter += new System.EventHandler(this.txtbUser_Enter);
            this.txtbUser.Leave += new System.EventHandler(this.txtbUser_Leave);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPassword.Font = new System.Drawing.Font("Simplex_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.Location = new System.Drawing.Point(261, 305);
            this.txtbPassword.Multiline = true;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(246, 30);
            this.txtbPassword.TabIndex = 5;
            this.txtbPassword.Text = "CONTRASEÑA";
            this.txtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPassword.WordWrap = false;
            this.txtbPassword.Enter += new System.EventHandler(this.txtbPassword_Enter);
            this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 481);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.lbLimpiar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbLimpiar;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.TextBox txtbPassword;
    }
}