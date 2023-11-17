namespace ClubManagement
{
    partial class formAddProfesor
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
            lblTitle = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblMail = new Label();
            lblValidar = new Label();
            txtRepitePass = new TextBox();
            txtPass = new TextBox();
            lblConfPass = new Label();
            lblPass = new Label();
            cbActividad = new ComboBox();
            label1 = new Label();
            btnAtras = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(177, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 40);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Agregar Profesor";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.Window;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(177, 83);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(261, 23);
            txtDNI.TabIndex = 29;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(142, 86);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 33;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(177, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(177, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 23);
            txtApellido.TabIndex = 31;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(177, 215);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(261, 23);
            txtMail.TabIndex = 32;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(119, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 26;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(119, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(140, 218);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 28;
            lblMail.Text = "Mail";
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidar.Location = new Point(227, 381);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(72, 20);
            lblValidar.TabIndex = 39;
            lblValidar.Text = "validador";
            lblValidar.Visible = false;
            // 
            // txtRepitePass
            // 
            txtRepitePass.BackColor = SystemColors.Window;
            txtRepitePass.BorderStyle = BorderStyle.FixedSingle;
            txtRepitePass.Cursor = Cursors.IBeam;
            txtRepitePass.Location = new Point(177, 299);
            txtRepitePass.Name = "txtRepitePass";
            txtRepitePass.PasswordChar = '*';
            txtRepitePass.Size = new Size(261, 23);
            txtRepitePass.TabIndex = 38;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(177, 251);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(261, 23);
            txtPass.TabIndex = 37;
            // 
            // lblConfPass
            // 
            lblConfPass.AutoSize = true;
            lblConfPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfPass.Location = new Point(48, 301);
            lblConfPass.Name = "lblConfPass";
            lblConfPass.Size = new Size(122, 15);
            lblConfPass.TabIndex = 36;
            lblConfPass.Text = "Confirma contraseña";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(101, 254);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 35;
            lblPass.Text = "Contraseña";
            // 
            // cbActividad
            // 
            cbActividad.FormattingEnabled = true;
            cbActividad.Items.AddRange(new object[] { "Natación", "Fútbol", "Tenis", "Yoga", "Baloncesto", "Voleibol", "Hockey", "Rugby" });
            cbActividad.Location = new Point(177, 343);
            cbActividad.Margin = new Padding(3, 2, 3, 2);
            cbActividad.Name = "cbActividad";
            cbActividad.Size = new Size(261, 23);
            cbActividad.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 346);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 41;
            label1.Text = "Actividad";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(255, 192, 192);
            btnAtras.Location = new Point(177, 410);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(82, 32);
            btnAtras.TabIndex = 42;
            btnAtras.Text = "Cancelar";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 255);
            btnAceptar.Location = new Point(356, 410);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 32);
            btnAceptar.TabIndex = 43;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // formAddProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 462);
            Controls.Add(btnAceptar);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(cbActividad);
            Controls.Add(lblValidar);
            Controls.Add(txtRepitePass);
            Controls.Add(txtPass);
            Controls.Add(lblConfPass);
            Controls.Add(lblPass);
            Controls.Add(lblTitle);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblMail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formAddProfesor";
            Text = "Añadir profesor";
            Load += formAddProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblMail;
        private Label lblValidar;
        private TextBox txtRepitePass;
        private TextBox txtPass;
        private Label lblConfPass;
        private Label lblPass;
        private ComboBox cbActividad;
        private Label label1;
        private Button btnAtras;
        private Button btnAceptar;
    }
}