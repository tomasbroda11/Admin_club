namespace ClubManagement
{
    partial class formEditProfes
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
            btnAcpetar.Location = new Point(487, 393);
            btnAcpetar.Name = "btnAcpetar";
            btnAcpetar.Size = new Size(96, 44);
            btnAcpetar.TabIndex = 60;
            btnAcpetar.Text = "Modificar";
            btnAcpetar.UseVisualStyleBackColor = false;
            btnAcpetar.Click += btnAcpetar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(285, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 44);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(203, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 50);
            lblTitle.TabIndex = 58;
            lblTitle.Text = "Modificar Datos Profesor";
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
            txtDNI.TabIndex = 53;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(244, 115);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 57;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(285, 171);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 54;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(285, 228);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(298, 27);
            txtApellido.TabIndex = 55;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(285, 282);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(298, 27);
            txtMail.TabIndex = 56;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(219, 228);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 50;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(217, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 51;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(244, 286);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 20);
            lblMail.TabIndex = 52;
            lblMail.Text = "Mail";
            // 
            // formEditProfes
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
            Name = "formEditProfes";
            Text = "formEditProfes";
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