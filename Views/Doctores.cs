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
    public partial class Doctores : Form
    {
        private DoctorController _doctorController;
        public Doctores()
        {
            InitializeComponent();
            _doctorController = new DoctorController();
            LoadDoctores();
        }
        private void LoadDoctores()
        {
            var doctores = _doctorController.GetDoctores();
            Lista_Doctores.DataSource = doctores;
            Lista_Doctores.DisplayMember = "Nombre";
            Lista_Doctores.ValueMember = "DoctorId";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Doc_tx_TextChanged(object sender, EventArgs e)
        {
            Agragar_bt.Enabled = !string.IsNullOrEmpty(Nombre_Doc_tx.Text) && !string.IsNullOrEmpty(Apellido_Doc_tx.Text) && !string.IsNullOrEmpty(Especialiad_doc_tx.Text);
        }

        private void Apellido_Doc_tx_TextChanged(object sender, EventArgs e)
        {
            Agragar_bt.Enabled = !string.IsNullOrEmpty(Nombre_Doc_tx.Text) && !string.IsNullOrEmpty(Apellido_Doc_tx.Text) && !string.IsNullOrEmpty(Especialiad_doc_tx.Text);
        }

        private void Especialiad_doc_tx_TextChanged(object sender, EventArgs e)
        {
            Agragar_bt.Enabled = !string.IsNullOrEmpty(Nombre_Doc_tx.Text) && !string.IsNullOrEmpty(Apellido_Doc_tx.Text) && !string.IsNullOrEmpty(Especialiad_doc_tx.Text);
        }

        private void telefono_Doc_tx_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(telefono_Doc_tx.Text, out long phoneNumber))
            {
                telefono_Doc_tx.ForeColor = Color.Black;
            }
            else
            {
                telefono_Doc_tx.ForeColor = Color.Red;
            }
        }

        private void Agragar_bt_Click(object sender, EventArgs e)
        {
            Doctor nuevoDoctor = new Doctor
            {
                Nombre = Nombre_Doc_tx.Text,
                Apellido = Apellido_Doc_tx.Text,
                Especialidad = Especialiad_doc_tx.Text,
                Telefono = telefono_Doc_tx.Text
            };
            _doctorController.AddDoctor(nuevoDoctor);
            LoadDoctores();
            Nombre_Doc_tx.Clear();
            Apellido_Doc_tx.Clear();
            Especialiad_doc_tx.Clear();
            telefono_Doc_tx.Clear();
        }

        private void Eliminar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_Doctores.SelectedItem != null)
            {
                Doctor doctorSeleccionado = (Doctor)Lista_Doctores.SelectedItem;
                _doctorController.DeleteDoctor(doctorSeleccionado.DoctorId);
                LoadDoctores();
                Nombre_Doc_tx.Clear();
                Apellido_Doc_tx.Clear();
                Especialiad_doc_tx.Clear();
                telefono_Doc_tx.Clear();
            }
        }

        private void Modificar_bt_Click(object sender, EventArgs e)
        {
            if (Lista_Doctores.SelectedItem != null)
            {
                Doctor doctorSeleccionado = (Doctor)Lista_Doctores.SelectedItem;
                doctorSeleccionado.Nombre = Nombre_Doc_tx.Text;
                doctorSeleccionado.Apellido = Apellido_Doc_tx.Text;
                doctorSeleccionado.Especialidad = Especialiad_doc_tx.Text;
                doctorSeleccionado.Telefono = telefono_Doc_tx.Text;

                // Llama al controlador para actualizar el doctor
                _doctorController.UpdateDoctor(doctorSeleccionado);

                // Recarga la lista de doctores
                LoadDoctores();
            }
            }

        private void Lista_Doctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_Doctores.SelectedItem != null)
            {
                Doctor doctorSeleccionado = (Doctor)Lista_Doctores.SelectedItem;
                Nombre_Doc_tx.Text = doctorSeleccionado.Nombre;
                Apellido_Doc_tx.Text = doctorSeleccionado.Apellido;
                Especialiad_doc_tx.Text = doctorSeleccionado.Especialidad;
                telefono_Doc_tx.Text = doctorSeleccionado.Telefono;
            }
        }
    }
}
