namespace ClubManagement
{
    partial class formMenuAdmin
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
            lblMenu = new Label();
            btnProfesores = new Button();
            btnSocios = new Button();
            btnReservas = new Button();
            btnInstalaciones = new Button();
            btn_menu_salir = new Button();
            btnHistorico = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(135, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(320, 37);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Panel de Administrador";
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(207, 213);
            btnProfesores.Margin = new Padding(3, 4, 3, 4);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(161, 33);
            btnProfesores.TabIndex = 3;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(207, 173);
            btnSocios.Margin = new Padding(3, 4, 3, 4);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(161, 33);
            btnSocios.TabIndex = 4;
            btnSocios.Text = "Socios";
            btnSocios.UseVisualStyleBackColor = true;
            btnSocios.Click += btnSocios_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(192, 192, 255);
            btnReservas.Location = new Point(207, 118);
            btnReservas.Margin = new Padding(3, 4, 3, 4);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(161, 33);
            btnReservas.TabIndex = 5;
            btnReservas.Text = "Reservas de Hoy";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnInstalaciones
            // 
            btnInstalaciones.Location = new Point(207, 253);
            btnInstalaciones.Margin = new Padding(3, 4, 3, 4);
            btnInstalaciones.Name = "btnInstalaciones";
            btnInstalaciones.Size = new Size(161, 33);
            btnInstalaciones.TabIndex = 7;
            btnInstalaciones.Text = "Instalaciones";
            btnInstalaciones.UseVisualStyleBackColor = true;
            btnInstalaciones.Click += btnInstalaciones_Click;
            // 
            // btn_menu_salir
            // 
            btn_menu_salir.BackColor = Color.LightCoral;
            btn_menu_salir.Location = new Point(207, 307);
            btn_menu_salir.Name = "btn_menu_salir";
            btn_menu_salir.Size = new Size(161, 33);
            btn_menu_salir.TabIndex = 8;
            btn_menu_salir.Text = "Salir";
            btn_menu_salir.UseVisualStyleBackColor = false;
            btn_menu_salir.Click += btn_menu_salir_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(192, 255, 255);
            btnHistorico.Location = new Point(207, 77);
            btnHistorico.Margin = new Padding(3, 4, 3, 4);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(161, 33);
            btnHistorico.TabIndex = 9;
            btnHistorico.Text = "Historico de Reservas";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // formMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 352);
            Controls.Add(btnHistorico);
            Controls.Add(btn_menu_salir);
            Controls.Add(btnInstalaciones);
            Controls.Add(btnReservas);
            Controls.Add(btnSocios);
            Controls.Add(btnProfesores);
            Controls.Add(lblMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formMenuAdmin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnProfesores;
        private Button btnSocios;
        private Button btnReservas;
        private Button btnInstalaciones;
        private Button btn_menu_salir;
        private Button btnHistorico;
    }
}