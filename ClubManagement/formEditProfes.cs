using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class formEditProfes : Form
    {
        Profesor profesor;
        public formEditProfes(Profesor prof)
        {
            this.profesor = prof;
            InitializeComponent();
            txtDNI.Text = this.profesor.getDni().ToString();
            txtNombre.Text = this.profesor.getNombre();
            txtApellido.Text = this.profesor.getApellido();
            txtMail.Text = this.profesor.getMail();

        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            if (!(this.txtDNI.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 ||
               this.txtMail.Text.Length == 0))
            {
                ABMpersonas abmPers = new ABMpersonas();
                bool esValido = abmPers.validarMail(txtMail.Text.ToString());
                if (esValido)
                {

                    Profesor profe = new Profesor(
                    this.profesor.getDni(),
                    txtNombre.Text,
                    txtApellido.Text,
                    txtMail.Text,
                    "",
                    "",
                    this.profesor.getActividad()
                    );
                    abmPers.update(profe);
                    MessageBox.Show("Modificacion exitosa!");
                    this.Hide();
                    formProfesores formProf = new formProfesores();
                    formProf.Show();
                    this.Close();

                }
                else MessageBox.Show("Formato de mail incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formProfesores formProf = new formProfesores();
            formProf.Show();
            this.Close();
        }
    }
}
