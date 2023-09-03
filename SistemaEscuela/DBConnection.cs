using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    class DBConnection
    {
        public static MySqlConnection conexion() {
            string cadenaConexion = "Database=escuela_db;Data source =localhost;User Id=root; Password=Zelda4122;";
            try {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);
                return conexionDB;
            }
            catch (MySqlException e){
                Console.WriteLine("Error:" + e.Message);
                return null;
            
            }
        }

    }
}
