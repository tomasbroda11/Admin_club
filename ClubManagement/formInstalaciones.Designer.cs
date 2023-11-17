namespace ClubManagement
{
    partial class formInstalaciones
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
            label1 = new Label();
            dataInstalaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnAtras = new Button();
            txtIdInstalacion = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataInstalaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 28);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 0;
            label1.Text = "Instalaciones";
            // 
            // dataInstalaciones
            // 
            dataInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInstalaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Activo, Actividad });
            dataInstalaciones.Location = new Point(55, 103);
            dataInstalaciones.Margin = new Padding(3, 4, 3, 4);
            dataInstalaciones.Name = "dataInstalaciones";
            dataInstalaciones.RowHeadersWidth = 51;
            dataInstalaciones.RowTemplate.Height = 25;
            dataInstalaciones.Size = new Size(477, 255);
            dataInstalaciones.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Width = 125;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            Actividad.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 392);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(55, 383);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(86, 40);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtIdInstalacion
            // 
            txtIdInstalacion.Location = new Point(259, 388);
            txtIdInstalacion.Margin = new Padding(3, 4, 3, 4);
            txtIdInstalacion.Name = "txtIdInstalacion";
            txtIdInstalacion.Size = new Size(52, 27);
            txtIdInstalacion.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightPink;
            btnEliminar.Location = new Point(429, 381);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.PaleTurquoise;
            btnActualizar.Location = new Point(319, 383);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 40);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Modificar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Location = new Point(429, 55);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 40);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // formInstalaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 452);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdInstalacion);
            Controls.Add(btnAtras);
            Controls.Add(label2);
            Controls.Add(dataInstalaciones);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formInstalaciones";
            Text = "Instalaciones";
            Load += formInstalacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataInstalaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataInstalaciones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn Actividad;
        private Label label2;
        private Button btnAtras;
        private TextBox txtIdInstalacion;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}