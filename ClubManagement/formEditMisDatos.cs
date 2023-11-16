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
    public partial class formEditMisDatos : Form
    {
        Persona persona;
        public formEditMisDatos(Persona p)
        {
            this.persona = p;
            InitializeComponent();
            txtDNI.Text = persona.getDni().ToString();
            txtNombre.Text = persona.getNombre().ToString();
            txtApellido.Text = persona.getApellido().ToString();
            txtMail.Text = persona.getMail().ToString();
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
                        this.persona.getDni(),
                        txtNombre.Text,
                        txtApellido.Text,
                        txtMail.Text,
                        "",
                        ""
                        );
                    abmPers.update(pers);
                    if (this.persona.getRol() == "user")
                    {
                        MessageBox.Show("Tus datos han sidos actualizados con exito!");
                        this.Hide();
                        formMenu formMenu = new formMenu(pers);
                        formMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Modificacion exitosa!");
                        Profesor p = (Profesor)this.persona;
                        this.Hide();
                        formMenuProfe formProf = new formMenuProfe(p);
                        formProf.Show();
                        this.Close();
                    }
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
            formMenu formMenu = new formMenu(this.persona);
            formMenu.Show();
            this.Close();
        }
    }
}

