namespace ClubManagement
{
    partial class formReservar
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
            lblTitulo = new Label();
            lblFecha = new Label();
            calendar = new MonthCalendar();
            lblHorario = new Label();
            label1 = new Label();
            cbActividad = new ComboBox();
            label2 = new Label();
            cbIntalacion = new ComboBox();
            cbHorario = new ComboBox();
            btnAceptar = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(211, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Reserva";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(58, 167);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(98, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Seleccione fecha:";
            // 
            // calendar
            // 
            calendar.Location = new Point(58, 189);
            calendar.Margin = new Padding(8, 7, 8, 7);
            calendar.MinDate = new DateTime(2023, 11, 9, 22, 5, 33, 0);
            calendar.Name = "calendar";
            calendar.TabIndex = 3;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(342, 167);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(107, 15);
            lblHorario.TabIndex = 4;
            lblHorario.Text = "Seleccione horario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 78);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 5;
            label1.Text = "Seleccione actividad:";
            // 
            // cbActividad
            // 
            cbActividad.FormattingEnabled = true;
            cbActividad.Items.AddRange(new object[] { "Natación", "Fútbol", "Tenis", "Yoga", "Baloncesto", "Voleibol", "Hockey", "Rugby" });
            cbActividad.Location = new Point(190, 75);
            cbActividad.Margin = new Padding(3, 2, 3, 2);
            cbActividad.Name = "cbActividad";
            cbActividad.Size = new Size(302, 23);
            cbActividad.TabIndex = 6;
            cbActividad.SelectedValueChanged += cbActividad_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 120);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 7;
            label2.Text = "Seleccione instalacion:";
            // 
            // cbIntalacion
            // 
            cbIntalacion.FormattingEnabled = true;
            cbIntalacion.Location = new Point(190, 117);
            cbIntalacion.Margin = new Padding(3, 2, 3, 2);
            cbIntalacion.Name = "cbIntalacion";
            cbIntalacion.Size = new Size(302, 23);
            cbIntalacion.TabIndex = 8;
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(342, 189);
            cbHorario.Margin = new Padding(3, 2, 3, 2);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(150, 23);
            cbHorario.TabIndex = 9;
            cbHorario.Click += cbHorario_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 255);
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(384, 375);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(108, 40);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ControlLightLight;
            btnAtras.Location = new Point(58, 375);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(108, 40);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // formReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 440);
            Controls.Add(btnAtras);
            Controls.Add(btnAceptar);
            Controls.Add(cbHorario);
            Controls.Add(cbIntalacion);
            Controls.Add(label2);
            Controls.Add(cbActividad);
            Controls.Add(label1);
            Controls.Add(lblHorario);
            Controls.Add(calendar);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formReservar";
            Text = "Reservar";
            Load += formReservar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFecha;
        private MonthCalendar calendar;
        private Label lblHorario;
        private Label label1;
        private ComboBox cbActividad;
        private Label label2;
        private ComboBox cbIntalacion;
        private ComboBox cbHorario;
        private Button btnAceptar;
        private Button btnAtras;
    }
}