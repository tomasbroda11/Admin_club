using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class formEntrenamientos : Form
    {
        Profesor profesor;
        public formEntrenamientos(Profesor p)
        {
            InitializeComponent();
            this.profesor = p;
            ABMEntrenamiento abmEnt = new ABMEntrenamiento();
            List<Entrenamiento> listaEntrenamientos = abmEnt.ConsultarEntrenamientosProfesor(p.getDni().ToString());
            List<String> dias = new List<string> { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

            foreach (Entrenamiento entrenamiento in listaEntrenamientos)
            {

                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = entrenamiento.IdEntrenamiento;
                dataGridView1.Rows[rowIndex].Cells["Dia"].Value = dias[entrenamiento.Dia];
                dataGridView1.Rows[rowIndex].Cells["HoraDesde"].Value = entrenamiento.HoraDesde;
                dataGridView1.Rows[rowIndex].Cells["HoraHasta"].Value = entrenamiento.HoraHasta;
                dataGridView1.Rows[rowIndex].Cells["Actividad"].Value = entrenamiento.Instalacion.Actividad.getDescripcion();
                dataGridView1.Rows[rowIndex].Cells["Instalacion"].Value = entrenamiento.Instalacion.getDescripcion();

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }




        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuProfe formMenuProf = new formMenuProfe(this.profesor);
            formMenuProf.Show();
            this.Close();
        }



        private void btnAgregarEntrenamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAddEntrenamiento formAddP = new formAddEntrenamiento(this.profesor);
            formAddP.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                ABMEntrenamiento abme = new ABMEntrenamiento();
                Entrenamiento ent = abme.obtenerEntrenamientoXId(int.Parse(txtId.Text));
                if (ent != null && ent.Profesor.getDni() == this.profesor.getDni())
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el entrenamiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        abme.eliminarEntrenamiento(int.Parse(txtId.Text));
                        MessageBox.Show("Entrenamiento eliminado con exito!");
                        this.Hide();
                        formEntrenamientos fe = new formEntrenamientos(this.profesor);
                        fe.Show();
                        this.Close();
                    }
                }
                else MessageBox.Show("No existe el ID ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Complete el campo Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                ABMEntrenamiento abme = new ABMEntrenamiento();
                Entrenamiento ent = abme.obtenerEntrenamientoXId(int.Parse(txtId.Text));


                if (ent != null && ent.Profesor.getDni() == this.profesor.getDni())
                {
                    this.Hide();
                    formEditEntrenamiento formEditE = new formEditEntrenamiento(ent, this.profesor);
                    formEditE.Show();
                    this.Close();
                }
                else MessageBox.Show("No existe el ID ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Complete el campo Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
