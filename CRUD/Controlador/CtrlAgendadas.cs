using CRUD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Controlador {
    internal class CtrlAgendadas : db {
        public List<Object> consulta() {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql = "SELECT persona.id_persona, nombre_uno, nombre_dos, apellido_uno, apellido_dos, matricula, semestre, especialidad,"
                + "reunion.id_reunion, tema, fecha, hora, lugar FROM persona, alumno, alumno_reunion, reunion WHERE alumno.id_persona = "
                + "alumno_reunion.id_alumno AND alumno_reunion.id_reunion = reunion.id_reunion AND persona.id_persona = alumno.id_persona";

            try {
                MySqlConnection conn = base.conexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Agendada _agendada = new Agendada();
                    _agendada.Id_persona = int.Parse(reader.GetString(0));
                    _agendada.PrimerNombre = reader[1].ToString();
                    _agendada.SegundoNombre = reader[2].ToString();
                    _agendada.ApPaterno = reader[3].ToString();
                    _agendada.ApMaterno = reader[4].ToString();
                    _agendada.Matricula = reader[5].ToString();
                    _agendada.Semestre = reader[6].ToString();
                    _agendada.Especialidad = reader[7].ToString();
                    _agendada.Id_reunion = int.Parse(reader.GetString(8));
                    _agendada.Tema = reader[9].ToString();
                    _agendada.Fecha = reader[10].ToString();
                    _agendada.Hora = reader[11].ToString();
                    _agendada.Lugar = reader[12].ToString();
                    lista.Add(_agendada);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return lista;
        }
    }
}
