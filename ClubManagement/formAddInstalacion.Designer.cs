namespace ClubManagement
{
    partial class formAddInstalacion
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtDescripcion = new TextBox();
            cbActivo = new ComboBox();
            cbActividades = new ComboBox();
            btnCancelar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 1;
            label1.Text = "Añadir Instalación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 93);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 135);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 177);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Activa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 218);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Actividad";
            // 
            // txtID
            // 
            txtID.Location = new Point(122, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(231, 23);
            txtID.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(122, 132);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(231, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // cbActivo
            // 
            cbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActivo.FlatStyle = FlatStyle.System;
            cbActivo.FormattingEnabled = true;
            cbActivo.Items.AddRange(new object[] { "0", "1" });
            cbActivo.Location = new Point(122, 174);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(231, 23);
            cbActivo.TabIndex = 8;
            // 
            // cbActividades
            // 
            cbActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActividades.FlatStyle = FlatStyle.System;
            cbActividades.FormattingEnabled = true;
            cbActividades.Location = new Point(122, 215);
            cbActividades.Name = "cbActividades";
            cbActividades.Size = new Size(231, 23);
            cbActividades.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(122, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 255, 255);
            btnActualizar.Location = new Point(274, 280);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 30);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Aceptar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // formAddInstalacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 335);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(cbActividades);
            Controls.Add(cbActivo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAddInstalacion";
            Text = "Añadir Instalación";
            Load += formAddInstalacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtDescripcion;
        private ComboBox cbActivo;
        private ComboBox cbActividades;
        private Button btnCancelar;
        private Button btnActualizar;
    }
}