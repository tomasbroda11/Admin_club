namespace ClubManagement
{
    partial class formEntrenamientos
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
            btnAgregarEntrenamiento = new Button();
            btnEliminar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnAtras = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Dia = new DataGridViewTextBoxColumn();
            HoraDesde = new DataGridViewTextBoxColumn();
            HoraHasta = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            Instalacion = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarEntrenamiento
            // 
            btnAgregarEntrenamiento.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregarEntrenamiento.Location = new Point(681, 93);
            btnAgregarEntrenamiento.Name = "btnAgregarEntrenamiento";
            btnAgregarEntrenamiento.Size = new Size(170, 48);
            btnAgregarEntrenamiento.TabIndex = 16;
            btnAgregarEntrenamiento.Text = "Agregar Entrenamiento";
            btnAgregarEntrenamiento.UseVisualStyleBackColor = false;
            btnAgregarEntrenamiento.Click += btnAgregarEntrenamiento_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Location = new Point(743, 450);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(441, 426);
            lblId.Name = "lblId";
            lblId.Size = new Size(126, 20);
            lblId.TabIndex = 13;
            lblId.Text = "Id entrenamiento:";
            // 
            // txtId
            // 
            txtId.Location = new Point(444, 448);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Ingrese ID";
            txtId.Size = new Size(171, 27);
            txtId.TabIndex = 12;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(21, 440);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(118, 45);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Dia, HoraDesde, HoraHasta, Actividad, Instalacion });
            dataGridView1.Location = new Point(74, 148);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(777, 203);
            dataGridView1.TabIndex = 10;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Dia
            // 
            Dia.HeaderText = "Dia";
            Dia.MinimumWidth = 6;
            Dia.Name = "Dia";
            Dia.Width = 125;
            // 
            // HoraDesde
            // 
            HoraDesde.HeaderText = "Desde";
            HoraDesde.MinimumWidth = 6;
            HoraDesde.Name = "HoraDesde";
            HoraDesde.Width = 125;
            // 
            // HoraHasta
            // 
            HoraHasta.HeaderText = "Hasta";
            HoraHasta.MinimumWidth = 6;
            HoraHasta.Name = "HoraHasta";
            HoraHasta.Width = 125;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            Actividad.Width = 125;
            // 
            // Instalacion
            // 
            Instalacion.HeaderText = "Instalacion";
            Instalacion.MinimumWidth = 6;
            Instalacion.Name = "Instalacion";
            Instalacion.Width = 125;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(290, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(372, 62);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Entrenamientos";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 255, 255);
            btnActualizar.Location = new Point(638, 450);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // formEntrenamientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 536);
            Controls.Add(btnAgregarEntrenamiento);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnAtras);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formEntrenamientos";
            Text = "formEntrenamientos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarEntrenamiento;
        private Button btnEliminar;
        private Label lblId;
        private TextBox txtId;
        private Button btnAtras;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn HoraDesde;
        private DataGridViewTextBoxColumn HoraHasta;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Instalacion;
        private Label lblTitle;
        private Button btnActualizar;
    }
}