namespace ClubManagement
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
            lnkRegistro = new LinkLabel();
            lblRegistro = new Label();
            lnkOlvidaPass = new LinkLabel();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 255);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(287, 268);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 40);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Iniciar Sesión";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(122, 268);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(102, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Inicio de Sesión";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(79, 132);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(33, 191);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(88, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(122, 128);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(274, 27);
            txtDNI.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(122, 187);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(274, 27);
            txtPass.TabIndex = 7;
            // 
            // lnkRegistro
            // 
            lnkRegistro.AutoSize = true;
            lnkRegistro.Cursor = Cursors.Hand;
            lnkRegistro.Location = new Point(175, 345);
            lnkRegistro.Name = "lnkRegistro";
            lnkRegistro.Size = new Size(76, 20);
            lnkRegistro.TabIndex = 8;
            lnkRegistro.TabStop = true;
            lnkRegistro.Text = "Registrate";
            lnkRegistro.LinkClicked += lnkRegistro_LinkClicked;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(14, 345);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(155, 20);
            lblRegistro.TabIndex = 9;
            lblRegistro.Text = "¿Aun no tiene cuenta?";
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Cursor = Cursors.Hand;
            lnkOlvidaPass.Location = new Point(14, 379);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(149, 20);
            lnkOlvidaPass.TabIndex = 5;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 421);
            Controls.Add(lblRegistro);
            Controls.Add(lnkRegistro);
            Controls.Add(txtPass);
            Controls.Add(txtDNI);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(lblPass);
            Controls.Add(lblDNI);
            Controls.Add(lblTitle);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(3, 4, 3, 4);
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
        private LinkLabel lnkRegistro;
        private Label lblRegistro;
        private LinkLabel lnkOlvidaPass;
    }
}