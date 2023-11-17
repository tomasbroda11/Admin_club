namespace ClubManagement
{
    partial class FormReservas
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
            components = new System.ComponentModel.Container();
            lblReservas = new Label();
            reservaBindingSource = new BindingSource(components);
            reservaBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewLinkColumn();
            instalacion = new DataGridViewTextBoxColumn();
            actividad = new DataGridViewTextBoxColumn();
            btnAtras = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnCancelar = new Button();
            btnReservar = new Button();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReservas.Location = new Point(42, 23);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(172, 50);
            lblReservas.TabIndex = 1;
            lblReservas.Text = "Reservas";
            // 
            // reservaBindingSource
            // 
            reservaBindingSource.DataSource = typeof(Entidades.Reserva);
            // 
            // reservaBindingSource1
            // 
            reservaBindingSource1.DataSource = typeof(Entidades.Reserva);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Estado, fecha, instalacion, actividad });
            dataGridView1.Location = new Point(42, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(560, 150);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // instalacion
            // 
            instalacion.HeaderText = "Instalacion";
            instalacion.MinimumWidth = 6;
            instalacion.Name = "instalacion";
            instalacion.Width = 125;
            // 
            // actividad
            // 
            actividad.HeaderText = "Actividad";
            actividad.MinimumWidth = 6;
            actividad.Name = "actividad";
            actividad.Width = 125;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(42, 293);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(91, 31);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(451, 299);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(427, 304);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(520, 289);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar Reserva";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(192, 255, 192);
            btnReservar.Location = new Point(492, 40);
            btnReservar.Margin = new Padding(3, 2, 3, 2);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(110, 36);
            btnReservar.TabIndex = 8;
            btnReservar.Text = "Agregar Reserva";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 354);
            Controls.Add(btnReservar);
            Controls.Add(btnCancelar);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnAtras);
            Controls.Add(dataGridView1);
            Controls.Add(lblReservas);
            Name = "FormReservas";
            Text = "Reservas";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReservas;
        private BindingSource reservaBindingSource;
        private BindingSource reservaBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private Button btnAtras;
        private TextBox txtId;
        private Label lblId;
        private Button btnCancelar;
        private Button btnReservar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewLinkColumn fecha;
        private DataGridViewTextBoxColumn instalacion;
        private DataGridViewTextBoxColumn actividad;
    }
}