using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Modelo {
    class db {
        public MySqlConnection conexion() {
            String server       = "localhost";
            String port         = "3306";
            String user         = "root";
            String password     = "";
            String dbname       = "practica_java";
            String fullString   = "Database=" + dbname + "; Data Source=" + server + "; Port=" + port + "; User Id=" + user + "; Password=" + password + ";";

            try {
                MySqlConnection conn = new MySqlConnection(fullString);
                return conn;
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
