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
    public partial class formAddSocio : Form
    {
        public formAddSocio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSocios formSoc = new formSocios();
            formSoc.ShowDialog();
            this.Close();
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (this.txtApellido.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (this.txtMail.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtRepitePass_Leave(object sender, EventArgs e)
        {
            if (this.txtRepitePass.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtRepitePass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length > 0)
            {
                if (this.txtRepitePass.Text != this.txtPass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Las contraseñas no coinciden!";
                }
                else
                {
                    this.lblValidar.Visible = false;
                }
                validar();
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRepitePass.Text.Length > 0)
            {
                if (this.txtRepitePass.Text != this.txtPass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Las contraseñas no coinciden!";
                }
                else
                {
                    this.lblValidar.Visible = false;
                }
            }
            validar();

        }

        private void validar()
        {
            if (!(this.txtDNI.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 ||
                this.txtMail.Text.Length == 0 || this.txtPass.Text.Length == 0 || this.txtRepitePass.Text.Length == 0) && this.txtPass.Text == this.txtRepitePass.Text)
            {
                this.btnAceptar.Enabled = true;
            }
            else
            {
                this.btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length == 8 && int.TryParse(txtDNI.Text, out int dni))
            {
                ABMpersonas abmPers = new ABMpersonas();
                bool esValido = abmPers.validarMail(txtMail.Text.ToString());
                if (esValido)
                {

                    ABMpersonas pers = new ABMpersonas();
                    Persona p = new Persona(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtMail.Text, txtPass.Text, "user");
                    int v = pers.add(p);
                    if (v == 1)
                    {
                        MessageBox.Show("Socio añadido correctamente", "Exito");
                        this.Hide();
                        formSocios formSoc = new formSocios();
                        formSoc.ShowDialog();
                        this.Close();
                    }
                    else if (v == 2)
                    {
                        MessageBox.Show("Dni ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Formato de mail incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("El dni debe ser un numero entero de 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}