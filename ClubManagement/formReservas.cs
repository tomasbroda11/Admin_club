﻿using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class FormReservas : Form
    {
        private Persona persona;
        public FormReservas(Persona p)
        {
            InitializeComponent();
            this.persona = p;

            ABMreservas aBMreservas = new ABMreservas();

            List<Reserva> reservasList = aBMreservas.consultarReservaCliente(p);


            foreach (Reserva reserva in reservasList)
            {

                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = reserva.Id;
                dataGridView1.Rows[rowIndex].Cells["estado"].Value = reserva.Estado;
                dataGridView1.Rows[rowIndex].Cells["fecha"].Value = reserva.Turno.ToString("dd/MM/yyyy HH:mm");
                dataGridView1.Rows[rowIndex].Cells["instalacion"].Value = reserva.Instalacion.getDescripcion();
                dataGridView1.Rows[rowIndex].Cells["actividad"].Value = reserva.Instalacion.Actividad.getDescripcion();


            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            this.persona = persona;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenuu = new formMenu(persona);
            formMenuu.Show();
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReservar formReser = new formReservar(persona);
            formReser.ShowDialog();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length >= 1)
            {
                ABMreservas form = new ABMreservas();
                Reserva res = form.validarReserva(txtId.Text.ToString());

                if (res != null && res.Persona.getDni() == this.persona.getDni())
                {
                    if (res.Estado == "Pendiente")
                    {
                        form.cancelarReserva(res);
                        MessageBox.Show("Reserva cancelada.");
                        this.Hide();
                        FormReservas formReser = new FormReservas(persona);
                        formReser.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Esa reserva ya fue " + res.Estado.ToLower(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Reserva no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Complete el campo Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
