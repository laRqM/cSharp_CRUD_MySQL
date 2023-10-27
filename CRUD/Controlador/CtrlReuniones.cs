using CRUD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Controlador {
    class CtrlReuniones : db {
        public List<Object> consulta() {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql = "SELECT * FROM reunion";

            try {
                MySqlConnection conn = base.conexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Reunion _reunion = new Reunion();
                    _reunion.Id_reunion = int.Parse(reader.GetString(0));
                    _reunion.Fecha = reader[1].ToString();
                    _reunion.Hora = reader[2].ToString();
                    _reunion.Lugar = reader[3].ToString();
                    _reunion.Tema = reader[4].ToString();
                    lista.Add(_reunion);
                }
            }
            catch (MySqlException ex) {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return lista;
        }

        public bool AgregarReunion(string fecha, string hora, string lugar, string tema) {
            using (MySqlConnection conexion = base.conexion()) {
                try {
                    conexion.Open();

                    string insertQuery = "INSERT INTO reunion (fecha, hora, lugar, tema) VALUES (@fecha, @hora, @lugar, @tema)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conexion)) {
                        insertCommand.Parameters.AddWithValue("@fecha", fecha);
                        insertCommand.Parameters.AddWithValue("@hora", hora);
                        insertCommand.Parameters.AddWithValue("@lugar", lugar);
                        insertCommand.Parameters.AddWithValue("@tema", tema);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException) {
                    return false;
                }
            }
        }
    }
}
