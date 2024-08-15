using PruebaParcial1.Controllers;
using PruebaParcial1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaParcial1.Views
{
    public partial class Cita_medica : Form
    {
        private CitaMedicaController _citaMedicaController;
        private PacienteController _pacienteController;
        private DoctorController _doctorController;
        public Cita_medica()
        {
            InitializeComponent();
            _citaMedicaController = new CitaMedicaController();
            _pacienteController = new PacienteController();
            _doctorController = new DoctorController();
            LoadPacientes();
            LoadDoctores();
            LoadCitasMedicas();
            InitializeComponent();
        }
        private void LoadPacientes()
        {
            var pacientes = _pacienteController.GetPacientes()
                .Select(p => new
                {
                    p.PacienteId,
                    DisplayName = $"{p.PacienteId} - {p.Nombre}"
                }).ToList();

            Lista_Pacientes.DataSource = pacientes;
            Lista_Pacientes.DisplayMember = "DisplayName";
            Lista_Pacientes.ValueMember = "PacienteId";

        }
        private void LoadDoctores()
        {
            var doctores = _doctorController.GetDoctores()
    .Select(d => new
    {
        d.DoctorId,
        DisplayName = $"{d.DoctorId} - {d.Nombre}"
    }).ToList();

            Lista_Doctores.DataSource = doctores;
            Lista_Doctores.DisplayMember = "DisplayName";
            Lista_Doctores.ValueMember = "DoctorId";
        }
        private void LoadCitasMedicas()
        {
            var citas = _citaMedicaController.GetCitasMedicas();
            var citasDisplay = citas.Select(c => new
            {
                Id = c.CitaId,
                Paciente = _pacienteController.GetPacientes().FirstOrDefault(p => p.PacienteId == c.PacienteId)?.Nombre,
                Doctor = _doctorController.GetDoctores().FirstOrDefault(d => d.DoctorId == c.DoctorId)?.Nombre,
                FechaCita = c.FechaCita
            }).ToList();

            Lista_citas.DataSource = citasDisplay;
            Lista_citas.DisplayMember = "Paciente";
            Lista_citas.ValueMember = "Id";
        }

        private void Nombre_Doc_tx_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombre_Pac_tx.Text))
            {
                MessageBox.Show("Paciente encontrado");
            }

            }

        private void Apellido_Doc_tx_TextChanged(object sender, EventArgs e)
        {
if (!string.IsNullOrEmpty(Apellido_Doc_tx.Text))
            {
                MessageBox.Show("Doctor encontrado");
            }
        }

        private void Fecha_cita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Motivo_cita_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agragar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_Pacientes.SelectedValue != null && Lista_Doctores.SelectedValue != null)
            {
                CitaMedica nuevaCita = new CitaMedica
                {
                    PacienteId = (int)Lista_Pacientes.SelectedValue,
                    DoctorId = (int)Lista_Doctores.SelectedValue,
                    FechaCita = Fecha_cita.Value.ToString("yyyy-MM-dd"),
                    Motivo = Motivo_cita.Text
                };
                _citaMedicaController.AddCitaMedica(nuevaCita);
                LoadCitasMedicas();
                Motivo_cita.Clear();
            }
        }

        private void Eliminar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_citas.SelectedValue != null)
            {
                int citaId = (int)Lista_citas.SelectedValue;
                _citaMedicaController.DeleteCitaMedica(citaId);
                LoadCitasMedicas();
                Motivo_cita.Clear();
            }

        }

        private void Modificar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_citas.SelectedValue != null && Lista_Pacientes.SelectedValue != null && Lista_Doctores.SelectedValue != null)
            {
                int citaId = (int)Lista_citas.SelectedValue;
                CitaMedica citaActualizada = new CitaMedica
                {
                    CitaId = citaId,
                    PacienteId = (int)Lista_Pacientes.SelectedValue,
                    DoctorId = (int)Lista_Doctores.SelectedValue,
                    FechaCita = Fecha_cita.Value.ToString("yyyy-MM-dd"),
                    Motivo = Motivo_cita.Text
                };
                _citaMedicaController.UpdateCitaMedica(citaActualizada);
                LoadCitasMedicas();
            }
        }

        private void Lista_Doctores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lista_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void Lista_citas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_citas.SelectedValue != null)
            {
                int citaId = (int)Lista_citas.SelectedValue;
                CitaMedica citaSeleccionada = _citaMedicaController.GetCitasMedicas().FirstOrDefault(c => c.CitaId == citaId);

                if (citaSeleccionada != null)
                {
                    Lista_Pacientes.SelectedValue = citaSeleccionada.PacienteId;
                    Lista_Doctores.SelectedValue = citaSeleccionada.DoctorId;
                    Fecha_cita.Value = DateTime.Parse(citaSeleccionada.FechaCita);
                    Motivo_cita.Text = citaSeleccionada.Motivo;
                }
            }
        }
    }
}

