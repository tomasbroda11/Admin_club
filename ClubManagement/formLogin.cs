using Negocio;
using Entidades;

namespace ClubManagement
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length == 0 || this.txtPass.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                if (!int.TryParse(txtDNI.Text, out int id))
                {
                    MessageBox.Show("El DNI debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ABMpersonas pers = new ABMpersonas();
                Persona p = pers.validarInicio(this.txtDNI.Text, this.txtPass.Text);
                if (p != null)
                {
                    //System.Diagnostics.Debug.WriteLine("ROL: " + p.getRol().ToString() == "admin");
                    //System.Diagnostics.Debug.WriteLine("COMPARE TO: " + p.getRol().CompareTo("admin"));
                    if (p.getRol().Trim().ToLower() == "admin")
                    {
                        this.Hide();
                        formMenuAdmin formMenuAdm = new formMenuAdmin();
                        formMenuAdm.ShowDialog();
                    }
                    else
                    {
                        if (p.getRol().Trim().ToLower() == "user")
                        {
                            this.Hide();
                            formMenu formMenup = new formMenu(p);
                            formMenup.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            formMenuProfe formMenuProf = new formMenuProfe((Profesor)p);
                            formMenuProf.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formAddSocio formregistro = new formAddSocio();
            formregistro.ShowDialog();
        }
    }
}