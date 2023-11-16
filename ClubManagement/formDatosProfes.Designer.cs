namespace ClubManagement
{
    partial class formDatosProfes
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
            btnAcpetar.BackColor = Color.FromArgb(192, 192, 255);
            btnAcpetar.Location = new Point(487, 388);
            btnAcpetar.Name = "btnAcpetar";
            btnAcpetar.Size = new Size(96, 44);
            btnAcpetar.TabIndex = 49;
            btnAcpetar.Text = "Modificar";
            btnAcpetar.UseVisualStyleBackColor = false;
            btnAcpetar.Click += btnAcpetar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(285, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 44);
            btnCancelar.TabIndex = 48;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(303, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 50);
            lblTitle.TabIndex = 47;
            lblTitle.Text = "Datos Profesor";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.InactiveCaption;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(285, 111);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(298, 27);
            txtDNI.TabIndex = 42;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(244, 115);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 46;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(285, 170);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(285, 233);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(298, 27);
            txtApellido.TabIndex = 44;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(285, 287);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(298, 27);
            txtMail.TabIndex = 45;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(219, 233);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 39;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(217, 174);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(244, 291);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 20);
            lblMail.TabIndex = 41;
            lblMail.Text = "Mail";
            // 
            // formDatosProfes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "formDatosProfes";
            Text = "Mis Datos Profesor";
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