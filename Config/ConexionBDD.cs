using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace PruebaParcial1.Config
{
    public static class DatabaseConfig
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost;database=Prueba1;User Id=root;pwd=192837");

            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            MessageBox.Show("Conexión establecida: " + conexion.State.ToString());
            return conexion;
        }
            }
       
    }
