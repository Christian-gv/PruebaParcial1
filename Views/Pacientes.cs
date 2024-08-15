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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PruebaParcial1
{
    public partial class Pacientes : Form
    {
        private PacienteController _pacienteController;

        public Pacientes()
        {
            InitializeComponent();
            _pacienteController = new PacienteController();
            LoadPacientes();
        }
        private void LoadPacientes()
        {
            var pacientes = _pacienteController.GetPacientes();
            Lista_Pacientes.DataSource = pacientes;
            Lista_Pacientes.DisplayMember = "Nombre";
            Lista_Pacientes.ValueMember = "PacienteId";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Agragar_bt.Enabled = !string.IsNullOrEmpty(Nombre_paciente_tx.Text) && !string.IsNullOrEmpty(Apellido_cliente_tx.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Agragar_bt.Enabled = !string.IsNullOrEmpty(Nombre_paciente_tx.Text) && !string.IsNullOrEmpty(Apellido_cliente_tx.Text);
        }

        private void telefono_paciente_tx_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(telefono_paciente_tx.Text, out long phoneNumber))
            {
                telefono_paciente_tx.ForeColor = Color.Black;
            }
            else
            {
                telefono_paciente_tx.ForeColor = Color.Red;
            }
        }


        private void Fechas_paciente_date_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = Fechas_paciente_date.Value;
        }

        private void Lista_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_Pacientes.SelectedItem != null)
            {
                Paciente pacienteSeleccionado = (Paciente)Lista_Pacientes.SelectedItem;
                Nombre_paciente_tx.Text = pacienteSeleccionado.Nombre;
                Apellido_cliente_tx.Text = pacienteSeleccionado.Apellido;
                Fechas_paciente_date.Value = DateTime.Parse(pacienteSeleccionado.FechaNacimiento);
                telefono_paciente_tx.Text = pacienteSeleccionado.Telefono;
            }
        }

        private void Agragar_bt_Click(object sender, EventArgs e)
        {
              Paciente nuevoPaciente = new Paciente

            {
                Nombre = Nombre_paciente_tx.Text,
                Apellido = Apellido_cliente_tx.Text,
                FechaNacimiento = Fechas_paciente_date.Value.ToString("yyyy-MM-dd"),
                Telefono = telefono_paciente_tx.Text
            };
            _pacienteController.AddPaciente(nuevoPaciente);
            LoadPacientes();
            Nombre_paciente_tx.Clear();
            Apellido_cliente_tx.Clear();
            telefono_paciente_tx.Clear();
        }

        private void Eliminar_bt_Click(object sender, EventArgs e)
        {
            string respuesta="";
            if (Lista_Pacientes.SelectedItem != null)
            {
                Paciente pacienteSeleccionado = (Paciente)Lista_Pacientes.SelectedItem;
                respuesta=_pacienteController.DeletePaciente(pacienteSeleccionado.PacienteId);
                if (respuesta == "ok" )
                {
                LoadPacientes();
                Nombre_paciente_tx.Clear();
                Apellido_cliente_tx.Clear();
                telefono_paciente_tx.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
                 }
        }

        private void Modificar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_Pacientes.SelectedItem != null)
            {
                Paciente pacienteSeleccionado = (Paciente)Lista_Pacientes.SelectedItem;
                pacienteSeleccionado.Nombre = Nombre_paciente_tx.Text;
                pacienteSeleccionado.Apellido = Apellido_cliente_tx.Text;
                pacienteSeleccionado.FechaNacimiento = Fechas_paciente_date.Value.ToString("yyyy-MM-dd");
                pacienteSeleccionado.Telefono = telefono_paciente_tx.Text;
                _pacienteController.UpdatePaciente(pacienteSeleccionado);
                LoadPacientes();
            }
        }
    }
}
