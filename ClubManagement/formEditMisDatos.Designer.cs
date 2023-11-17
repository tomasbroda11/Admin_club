namespace ClubManagement
{
    partial class formEditMisDatos
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
            btnAcpetar = new Button();
            btnCancelar = new Button();
            lblTitle = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblMail = new Label();
            SuspendLayout();
            // 
            // btnAcpetar
            // 
            btnAcpetar.BackColor = Color.FromArgb(192, 255, 255);
            btnAcpetar.Location = new Point(312, 294);
            btnAcpetar.Margin = new Padding(3, 2, 3, 2);
            btnAcpetar.Name = "btnAcpetar";
            btnAcpetar.Size = new Size(84, 33);
            btnAcpetar.TabIndex = 38;
            btnAcpetar.Text = "Modificar";
            btnAcpetar.UseVisualStyleBackColor = false;
            btnAcpetar.Click += btnAcpetar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(135, 294);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 33);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(186, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 40);
            lblTitle.TabIndex = 36;
            lblTitle.Text = "Mis Datos";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.InactiveCaption;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(135, 86);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(261, 23);
            txtDNI.TabIndex = 31;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(100, 89);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 35;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(135, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 32;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(135, 177);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 23);
            txtApellido.TabIndex = 33;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(135, 218);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(261, 23);
            txtMail.TabIndex = 34;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(78, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 28;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(76, 133);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 29;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(100, 221);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 30;
            lblMail.Text = "Mail";
            // 
            // formEditMisDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 354);
            Controls.Add(btnAcpetar);
            Controls.Add(btnCancelar);
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
            Name = "formEditMisDatos";
            Text = "Editar Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcpetar;
        private Button btnCancelar;
        private Label lblTitle;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblMail;
    }
}