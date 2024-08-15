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
    public class DoctorController
    {
        public List<Doctor> GetDoctores()
        {
            List<Doctor> doctores = new List<Doctor>();

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Doctores";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctores.Add(new Doctor
                    {
                        DoctorId = reader.GetInt32("doctor_id"),
                        Nombre = reader.GetString("nombre"),
                        Apellido = reader.GetString("apellido"),
                        Especialidad = reader.GetString("especialidad"),
                        Telefono = reader.GetString("telefono")
                    });
                }
            }

            return doctores;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Doctores (nombre, apellido, especialidad, telefono) VALUES (@Nombre, @Apellido, @Especialidad, @Telefono)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", doctor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", doctor.Apellido);
                cmd.Parameters.AddWithValue("@Especialidad", doctor.Especialidad);
                cmd.Parameters.AddWithValue("@Telefono", doctor.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Doctores SET nombre=@Nombre, apellido=@Apellido, especialidad=@Especialidad, telefono=@Telefono WHERE doctor_id=@DoctorId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", doctor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", doctor.Apellido);
                cmd.Parameters.AddWithValue("@Especialidad", doctor.Especialidad);
                cmd.Parameters.AddWithValue("@Telefono", doctor.Telefono);
                cmd.Parameters.AddWithValue("@DoctorId", doctor.DoctorId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int doctorId)
        {
            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Doctores WHERE doctor_id=@DoctorId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

