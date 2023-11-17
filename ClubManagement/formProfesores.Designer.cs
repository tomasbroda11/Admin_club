namespace ClubManagement
{
    partial class formProfesores
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
            dataProfesores = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            btnAtras = new Button();
            txtDni = new TextBox();
            lblIngresar = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProfesores).BeginInit();
            SuspendLayout();
            // 
            // dataProfesores
            // 
            dataProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProfesores.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Apellido, Email, Actividad });
            dataProfesores.Location = new Point(35, 86);
            dataProfesores.Margin = new Padding(3, 2, 3, 2);
            dataProfesores.Name = "dataProfesores";
            dataProfesores.RowHeadersWidth = 51;
            dataProfesores.RowTemplate.Height = 29;
            dataProfesores.Size = new Size(510, 170);
            dataProfesores.TabIndex = 0;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            Actividad.Width = 125;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(35, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Profesores";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(35, 281);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(92, 32);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(275, 286);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(94, 23);
            txtDni.TabIndex = 3;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Location = new Point(239, 290);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(30, 15);
            lblIngresar.TabIndex = 4;
            lblIngresar.Text = "DNI:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 255);
            btnModificar.Location = new Point(375, 283);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 28);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Location = new Point(463, 283);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 28);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Location = new Point(450, 53);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // formProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 338);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(lblIngresar);
            Controls.Add(txtDni);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(dataProfesores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formProfesores";
            Text = "Profesores";
            Load += formProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dataProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataProfesores;
        private Label lblTitulo;
        private Button btnAtras;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Actividad;
        private TextBox txtDni;
        private Label lblIngresar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}