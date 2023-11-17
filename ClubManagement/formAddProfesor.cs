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
    public partial class formAddProfesor : Form
    {
        public formAddProfesor()
        {
            InitializeComponent();
        }

        private void formAddProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(this.txtDNI.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 || this.cbActividad.SelectedValue != null ||
               this.txtMail.Text.Length == 0 || this.txtPass.Text.Length == 0 || this.txtRepitePass.Text.Length == 0))
            {
                if (this.txtDNI.Text.Length == 8 && int.TryParse(txtDNI.Text, out int dni))
                {

                    if (this.txtPass.Text == this.txtRepitePass.Text)
                    {

                        ABMpersonas profe = new ABMpersonas();
                        if (profe.validarMail(txtMail.Text))
                        {

                            ABMActividades abmAct = new ABMActividades();
                            Actividad act = abmAct.obtenerActividadPorDesc(cbActividad.SelectedItem.ToString());
                            Profesor p = new Profesor(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtMail.Text, txtPass.Text, "profesor", act);
                            int v = profe.addProfesor(p);
                            if (v == 1)
                            {
                                MessageBox.Show("Alta profesor exitosa!");
                                this.Hide();
                                formProfesores formProfe = new formProfesores();
                                formProfe.Show();
                                this.Close();
                            }
                            else if (v == 2)
                            {
                                MessageBox.Show("Este DNI ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error en el registro. Vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else MessageBox.Show("El formato de mail no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Las contraseñas no coinciden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El dni debe ser un numero entero de 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
