using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PruebaParcial1.Config;
using PruebaParcial1.Models;

namespace PruebaParcial1.Controllers
{
    public class CitaMedicaController
    {
        public List<CitaMedica> GetCitasMedicas()
        {
            List<CitaMedica> citas = new List<CitaMedica>();

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Citas_Medicas";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    citas.Add(new CitaMedica
                    {
                        CitaId = reader.GetInt32("cita_id"),
                        PacienteId = reader.GetInt32("paciente_id"),
                        DoctorId = reader.GetInt32("doctor_id"),
                        FechaCita = reader.GetString("fecha_cita"),
                        Motivo = reader.GetString("motivo")
                    });
                }
            }

            return citas;
        }

        public void AddCitaMedica(CitaMedica cita)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Citas_Medicas (paciente_id, doctor_id, fecha_cita, motivo) VALUES (@PacienteId, @DoctorId, @FechaCita, @Motivo)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PacienteId", cita.PacienteId);
                cmd.Parameters.AddWithValue("@DoctorId", cita.DoctorId);
                cmd.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                cmd.Parameters.AddWithValue("@Motivo", cita.Motivo);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCitaMedica(CitaMedica cita)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Citas_Medicas SET paciente_id=@PacienteId, doctor_id=@DoctorId, fecha_cita=@FechaCita, motivo=@Motivo WHERE cita_id=@CitaId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PacienteId", cita.PacienteId);
                cmd.Parameters.AddWithValue("@DoctorId", cita.DoctorId);
                cmd.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                cmd.Parameters.AddWithValue("@Motivo", cita.Motivo);
                cmd.Parameters.AddWithValue("@CitaId", cita.CitaId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCitaMedica(int citaId)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Citas_Medicas WHERE cita_id=@CitaId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CitaId", citaId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
