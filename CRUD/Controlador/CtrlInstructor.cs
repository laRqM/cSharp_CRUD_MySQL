using CRUD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Controlador {
    class CtrlInstructor : db {
        public List<Object> consulta() {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql = "SELECT persona.id_persona, nombre_uno, nombre_dos, apellido_uno, apellido_dos, D_nacimiento, folio FROM persona, instructor WHERE persona.id_persona = instructor.id_persona";

            try {
                MySqlConnection conn = base.conexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Instructor _instructor = new Instructor();
                    _instructor.Id_persona = int.Parse(reader.GetString(0));
                    _instructor.PrimerNombre = reader[1].ToString();
                    _instructor.SegundoNombre = reader[2].ToString();
                    _instructor.ApPaterno = reader[3].ToString();
                    _instructor.ApMaterno = reader[4].ToString();
                    _instructor.FechaNacimiento = reader[5].ToString();
                    _instructor.Folio = reader[6].ToString();
                    lista.Add(_instructor);
                }
            }
            catch (MySqlException ex) {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return lista;
        }
    }
}
