﻿namespace Oftalmol_Go
{
    partial class FormCrearCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCita));
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.horaLabel = new System.Windows.Forms.Label();
            this.lbSimpleHorasdisp = new System.Windows.Forms.Label();
            this.fechaAgendarLabel = new System.Windows.Forms.Label();
            this.txtbPaciente = new System.Windows.Forms.TextBox();
            this.comboDia = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.comboMin = new System.Windows.Forms.ComboBox();
            this.txtbTel = new System.Windows.Forms.TextBox();
            this.txtbmail = new System.Windows.Forms.TextBox();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.lbSimpleCancel = new System.Windows.Forms.Label();
            this.lbSimpleFecha = new System.Windows.Forms.Label();
            this.lbSimpleHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 68);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(99, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 291);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.Color.Transparent;
            this.btnBefore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBefore.BackgroundImage")));
            this.btnBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBefore.FlatAppearance.BorderSize = 0;
            this.btnBefore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBefore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBefore.ForeColor = System.Drawing.Color.Coral;
            this.btnBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBefore.Location = new System.Drawing.Point(38, 331);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(55, 107);
            this.btnBefore.TabIndex = 17;
            this.btnBefore.UseVisualStyleBackColor = false;
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.Color.Transparent;
            this.btnAfter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfter.BackgroundImage")));
            this.btnAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfter.FlatAppearance.BorderSize = 0;
            this.btnAfter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAfter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfter.ForeColor = System.Drawing.Color.Coral;
            this.btnAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAfter.Location = new System.Drawing.Point(659, 331);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(55, 107);
            this.btnAfter.TabIndex = 20;
            this.btnAfter.UseVisualStyleBackColor = false;
            // 
            // horaLabel
            // 
            this.horaLabel.AllowDrop = true;
            this.horaLabel.AutoSize = true;
            this.horaLabel.BackColor = System.Drawing.Color.Transparent;
            this.horaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.horaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.horaLabel.Location = new System.Drawing.Point(204, 331);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(325, 120);
            this.horaLabel.TabIndex = 21;
            this.horaLabel.Text = "15:30";
            // 
            // lbSimpleHorasdisp
            // 
            this.lbSimpleHorasdisp.AllowDrop = true;
            this.lbSimpleHorasdisp.AutoSize = true;
            this.lbSimpleHorasdisp.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleHorasdisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbSimpleHorasdisp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSimpleHorasdisp.Location = new System.Drawing.Point(197, 200);
            this.lbSimpleHorasdisp.Name = "lbSimpleHorasdisp";
            this.lbSimpleHorasdisp.Size = new System.Drawing.Size(332, 36);
            this.lbSimpleHorasdisp.TabIndex = 22;
            this.lbSimpleHorasdisp.Text = "Horas disponibles hoy";
            // 
            // fechaAgendarLabel
            // 
            this.fechaAgendarLabel.AllowDrop = true;
            this.fechaAgendarLabel.AutoSize = true;
            this.fechaAgendarLabel.BackColor = System.Drawing.Color.Transparent;
            this.fechaAgendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.fechaAgendarLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fechaAgendarLabel.Location = new System.Drawing.Point(295, 290);
            this.fechaAgendarLabel.Name = "fechaAgendarLabel";
            this.fechaAgendarLabel.Size = new System.Drawing.Size(141, 29);
            this.fechaAgendarLabel.TabIndex = 23;
            this.fechaAgendarLabel.Text = "29 / 09 / 20";
            // 
            // txtbPaciente
            // 
            this.txtbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPaciente.Location = new System.Drawing.Point(843, 159);
            this.txtbPaciente.Name = "txtbPaciente";
            this.txtbPaciente.Size = new System.Drawing.Size(387, 45);
            this.txtbPaciente.TabIndex = 24;
            this.txtbPaciente.Text = "Nombre";
            this.txtbPaciente.Enter += new System.EventHandler(this.txtbPaciente_Enter);
            this.txtbPaciente.Leave += new System.EventHandler(this.txtbPaciente_Leave);
            // 
            // comboDia
            // 
            this.comboDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDia.FormattingEnabled = true;
            this.comboDia.Location = new System.Drawing.Point(843, 251);
            this.comboDia.Name = "comboDia";
            this.comboDia.Size = new System.Drawing.Size(124, 39);
            this.comboDia.TabIndex = 29;
            // 
            // comboMes
            // 
            this.comboMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(973, 251);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(124, 39);
            this.comboMes.TabIndex = 30;
            // 
            // comboAño
            // 
            this.comboAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Location = new System.Drawing.Point(1106, 251);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(124, 39);
            this.comboAño.TabIndex = 31;
            // 
            // comboHora
            // 
            this.comboHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Location = new System.Drawing.Point(886, 331);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(124, 39);
            this.comboHora.TabIndex = 32;
            // 
            // comboMin
            // 
            this.comboMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMin.FormattingEnabled = true;
            this.comboMin.Location = new System.Drawing.Point(1055, 331);
            this.comboMin.Name = "comboMin";
            this.comboMin.Size = new System.Drawing.Size(124, 39);
            this.comboMin.TabIndex = 33;
            // 
            // txtbTel
            // 
            this.txtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTel.Location = new System.Drawing.Point(843, 415);
            this.txtbTel.Name = "txtbTel";
            this.txtbTel.Size = new System.Drawing.Size(387, 45);
            this.txtbTel.TabIndex = 34;
            this.txtbTel.Text = "Tel.";
            this.txtbTel.Enter += new System.EventHandler(this.txtbTel_Enter);
            this.txtbTel.Leave += new System.EventHandler(this.txtbTel_Leave);
            // 
            // txtbmail
            // 
            this.txtbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbmail.Location = new System.Drawing.Point(843, 496);
            this.txtbmail.Name = "txtbmail";
            this.txtbmail.Size = new System.Drawing.Size(387, 45);
            this.txtbmail.TabIndex = 35;
            this.txtbmail.Text = "Correo";
            this.txtbmail.Enter += new System.EventHandler(this.txtbmail_Enter);
            this.txtbmail.Leave += new System.EventHandler(this.txtbmail_Leave);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgendarCita.BackgroundImage")));
            this.btnAgendarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgendarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarCita.FlatAppearance.BorderSize = 0;
            this.btnAgendarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgendarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgendarCita.Location = new System.Drawing.Point(915, 582);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(251, 68);
            this.btnAgendarCita.TabIndex = 36;
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // lbSimpleCancel
            // 
            this.lbSimpleCancel.AutoSize = true;
            this.lbSimpleCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSimpleCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSimpleCancel.ForeColor = System.Drawing.Color.Maroon;
            this.lbSimpleCancel.Location = new System.Drawing.Point(1012, 653);
            this.lbSimpleCancel.Name = "lbSimpleCancel";
            this.lbSimpleCancel.Size = new System.Drawing.Size(59, 13);
            this.lbSimpleCancel.TabIndex = 37;
            this.lbSimpleCancel.Text = "Cancelar X";
            this.lbSimpleCancel.Click += new System.EventHandler(this.lbSimpleCancel_Click);
            // 
            // lbSimpleFecha
            // 
            this.lbSimpleFecha.AllowDrop = true;
            this.lbSimpleFecha.AutoSize = true;
            this.lbSimpleFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbSimpleFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSimpleFecha.Location = new System.Drawing.Point(1004, 223);
            this.lbSimpleFecha.Name = "lbSimpleFecha";
            this.lbSimpleFecha.Size = new System.Drawing.Size(67, 25);
            this.lbSimpleFecha.TabIndex = 38;
            this.lbSimpleFecha.Text = "Fecha";
            // 
            // lbSimpleHora
            // 
            this.lbSimpleHora.AllowDrop = true;
            this.lbSimpleHora.AutoSize = true;
            this.lbSimpleHora.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbSimpleHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSimpleHora.Location = new System.Drawing.Point(1010, 303);
            this.lbSimpleHora.Name = "lbSimpleHora";
            this.lbSimpleHora.Size = new System.Drawing.Size(54, 25);
            this.lbSimpleHora.TabIndex = 39;
            this.lbSimpleHora.Text = "Hora";
            // 
            // FormCrearCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ControlBox = false;
            this.Controls.Add(this.lbSimpleHora);
            this.Controls.Add(this.lbSimpleFecha);
            this.Controls.Add(this.lbSimpleCancel);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.txtbmail);
            this.Controls.Add(this.txtbTel);
            this.Controls.Add(this.comboMin);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.comboAño);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboDia);
            this.Controls.Add(this.txtbPaciente);
            this.Controls.Add(this.fechaAgendarLabel);
            this.Controls.Add(this.lbSimpleHorasdisp);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.btnAfter);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCrearCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Cita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label lbSimpleHorasdisp;
        private System.Windows.Forms.Label fechaAgendarLabel;
        private System.Windows.Forms.TextBox txtbPaciente;
        private System.Windows.Forms.ComboBox comboDia;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.ComboBox comboMin;
        private System.Windows.Forms.TextBox txtbTel;
        private System.Windows.Forms.TextBox txtbmail;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Label lbSimpleCancel;
        private System.Windows.Forms.Label lbSimpleFecha;
        private System.Windows.Forms.Label lbSimpleHora;
    }
}