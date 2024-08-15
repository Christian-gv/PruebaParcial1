using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaParcial1.Views;

namespace PruebaParcial1.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\descarga.jpg");
            this.BackgroundImage = img;
        }

        private void General_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agr_pacientes_Click(object sender, EventArgs e)
        {
            Pacientes pacientesForm = new Pacientes();
            pacientesForm.Show();
        }

        private void Agr_Doctores_Click(object sender, EventArgs e)
        {
            Doctores doctoresForm = new Doctores();
            doctoresForm.Show();

        }

        private void Crear_citas_Click(object sender, EventArgs e)
        {
            Cita_medica citaForm = new Cita_medica();
            citaForm.Show();
        }
    }
}
