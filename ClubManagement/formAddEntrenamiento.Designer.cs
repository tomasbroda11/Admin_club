namespace ClubManagement
{
    partial class formAddEntrenamiento
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
            lblHoraDesde = new Label();
            btnAtras = new Button();
            cbHoraDesde = new ComboBox();
            btnAceptar = new Button();
            cbHoraHasta = new ComboBox();
            lblHoraHasta = new Label();
            cbDia = new ComboBox();
            lblDia = new Label();
            cbInstalacion = new ComboBox();
            lblInstalacion = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(219, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(543, 62);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Agregar Entrenamiento";
            // 
            // lblHoraDesde
            // 
            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Location = new Point(90, 249);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.Size = new Size(91, 20);
            lblHoraDesde.TabIndex = 16;
            lblHoraDesde.Text = "Hora Desde:";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(255, 192, 192);
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(154, 492);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(118, 45);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // cbHoraDesde
            // 
            cbHoraDesde.FormattingEnabled = true;
            cbHoraDesde.Location = new Point(175, 245);
            cbHoraDesde.Name = "cbHoraDesde";
            cbHoraDesde.Size = new Size(253, 28);
            cbHoraDesde.TabIndex = 17;
            cbHoraDesde.SelectedValueChanged += cbHoraDesde_SelectedValueChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 255);
            btnAceptar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(576, 484);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 53);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cbHoraHasta
            // 
            cbHoraHasta.BackColor = SystemColors.InactiveCaption;
            cbHoraHasta.Enabled = false;
            cbHoraHasta.FormattingEnabled = true;
            cbHoraHasta.Location = new Point(543, 245);
            cbHoraHasta.Name = "cbHoraHasta";
            cbHoraHasta.Size = new Size(253, 28);
            cbHoraHasta.TabIndex = 20;
            // 
            // lblHoraHasta
            // 
            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Location = new Point(458, 249);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.Size = new Size(87, 20);
            lblHoraHasta.TabIndex = 19;
            lblHoraHasta.Text = "Hora Hasta:";
            // 
            // cbDia
            // 
            cbDia.FormattingEnabled = true;
            cbDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" });
            cbDia.Location = new Point(175, 180);
            cbDia.Name = "cbDia";
            cbDia.Size = new Size(253, 28);
            cbDia.TabIndex = 22;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(141, 184);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(35, 20);
            lblDia.TabIndex = 21;
            lblDia.Text = "Dia:";
            // 
            // cbInstalacion
            // 
            cbInstalacion.FormattingEnabled = true;
            cbInstalacion.Location = new Point(175, 312);
            cbInstalacion.Name = "cbInstalacion";
            cbInstalacion.Size = new Size(253, 28);
            cbInstalacion.TabIndex = 24;
            // 
            // lblInstalacion
            // 
            lblInstalacion.AutoSize = true;
            lblInstalacion.Location = new Point(90, 316);
            lblInstalacion.Name = "lblInstalacion";
            lblInstalacion.Size = new Size(83, 20);
            lblInstalacion.TabIndex = 23;
            lblInstalacion.Text = "Instalación:";
            // 
            // formAddEntrenamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cbInstalacion);
            Controls.Add(lblInstalacion);
            Controls.Add(cbDia);
            Controls.Add(lblDia);
            Controls.Add(cbHoraHasta);
            Controls.Add(lblHoraHasta);
            Controls.Add(btnAceptar);
            Controls.Add(cbHoraDesde);
            Controls.Add(lblHoraDesde);
            Controls.Add(btnAtras);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formAddEntrenamiento";
            Text = "formAddEntrenamiento";
            Load += formAddEntrenamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHoraDesde;
        private TextBox txtId;
        private Button btnAtras;
        private ComboBox cbHoraDesde;
        private Button btnAceptar;
        private ComboBox cbHoraHasta;
        private Label lblHoraHasta;
        private ComboBox cbDia;
        private Label lblDia;
        private ComboBox cbInstalacion;
        private Label lblInstalacion;
    }
}