using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial1.Models
{
    public class CitaMedica
    {
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public string FechaCita { get; set; }
        public string Motivo { get; set; }
    }
}

