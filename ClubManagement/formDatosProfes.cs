using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class formDatosProfes : Form
    {
        Profesor profesor;
        public formDatosProfes(Profesor prof)
        {
            this.profesor = prof;
            InitializeComponent();
            txtDNI.Text = this.profesor.getDni().ToString();
            txtNombre.Text = this.profesor.getNombre().ToString();
            txtApellido.Text = this.profesor.getApellido().ToString();
            txtMail.Text = this.profesor.getMail().ToString();

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

                    Persona pers = new Persona(
                    this.profesor.getDni(),
                    txtNombre.Text,
                    txtApellido.Text,
                    txtMail.Text,
                    "",
                    ""
                    );
                    abmPers.update(pers);
                    Profesor profesor = new Profesor(pers.getDni(), pers.getNombre(), pers.getApellido(), pers.getMail(), this.profesor.getPassword(), "profesor", this.profesor.getActividad());
                    MessageBox.Show("Modificación exitosa!");
                    this.Hide();
                    formMenuProfe formProf = new formMenuProfe(profesor);
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
            formMenuProfe formProf = new formMenuProfe(this.profesor);
            formProf.Show();
            this.Close();
        }
    }
}

