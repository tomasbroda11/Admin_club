﻿namespace ClubManagement
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblTitle = new Label();
            lblDNI = new Label();
            lblPass = new Label();
            txtDNI = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 255);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(251, 201);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 30);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Iniciar Sesión";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(107, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(92, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(277, 47);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Inicio de Sesión";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(69, 99);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(29, 143);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(107, 96);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(240, 23);
            txtDNI.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(107, 140);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(240, 23);
            txtPass.TabIndex = 7;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 271);
            Controls.Add(txtPass);
            Controls.Add(txtDNI);
            Controls.Add(lblPass);
            Controls.Add(lblDNI);
            Controls.Add(lblTitle);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "formLogin";
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblTitle;
        private Label lblDNI;
        private Label lblPass;
        private TextBox txtDNI;
        private TextBox txtPass;
    }
}