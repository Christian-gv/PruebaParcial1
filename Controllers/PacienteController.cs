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
    public class PacienteController
    {
        public class PacienteController
        {
            public List<Paciente> GetPacientes()
            {
                List<Paciente> pacientes = new List<Paciente>();

                using (var connection = DatabaseConfig.GetConnection())
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "SELECT * FROM Pacientes";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    pacientes.Add(new Paciente
                                    {
                                        PacienteId = reader.GetInt32("paciente_id"),
                                        Nombre = reader.GetString("nombre"),
                                        Apellido = reader.GetString("apellido"),
                                        FechaNacimiento = reader.GetString("fecha_nacimiento"),
                                        Telefono = reader.GetString("telefono")
                                    });
                                }
                                reader.Close();

                            }
                            else
                            {
                                throw new Exception("Error: el lector de datos es null.");
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al obtener los pacientes: " + ex.Message);
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("No se pudo establecer la conexión con la base de datos.");
                    }
                }
                return pacientes;
            }
            public void AddPaciente(Paciente paciente)
            {
                using (var connection = DatabaseConfig.GetConnection())
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO Pacientes (nombre, apellido, fecha_nacimiento, telefono) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Telefono)";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                            cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                            cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al agregar el paciente: " + ex.Message);
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("No se pudo establecer la conexión con la base de datos.");
                    }
                }
            }
            public void UpdatePaciente(Paciente paciente)
            {
                using (var connection = DatabaseConfig.GetConnection())
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "UPDATE Pacientes SET nombre=@Nombre, apellido=@Apellido, fecha_nacimiento=@FechaNacimiento, telefono=@Telefono WHERE paciente_id=@PacienteId";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                            cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                            cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                            cmd.Parameters.AddWithValue("@PacienteId", paciente.PacienteId);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al actualizar el paciente: " + ex.Message);
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("No se pudo establecer la conexión con la base de datos.");
                    }
                }
            }
            public void DeletePaciente(int pacienteId)
            {
                using (var connection = DatabaseConfig.GetConnection())
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "DELETE FROM Pacientes WHERE paciente_id=@PacienteId";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@PacienteId", pacienteId);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al eliminar el paciente: " + ex.Message);
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("No se pudo establecer la conexión con la base de datos.");
                    }
                }
            }
        }
    }
}