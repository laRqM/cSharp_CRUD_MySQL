using CRUD.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Controlador {
    class CtrlAlumno : db {
        public List<Object> consulta() {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql = "SELECT persona.id_persona, nombre_uno, nombre_dos, apellido_uno, apellido_dos, D_nacimiento, matricula, semestre, especialidad FROM persona, alumno WHERE persona.id_persona = alumno.id_persona";

            try {
                MySqlConnection conn = base.conexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Alumno _alumno = new Alumno();
                    _alumno.Id_persona = int.Parse(reader.GetString(0));
                    _alumno.PrimerNombre = reader[1].ToString();
                    _alumno.SegundoNombre = reader[2].ToString();
                    _alumno.ApPaterno = reader[3].ToString();
                    _alumno.ApMaterno = reader[4].ToString();
                    _alumno.FechaNacimiento = reader[5].ToString();
                    _alumno.Matricula = reader[6].ToString();
                    _alumno.Semestre = reader[7].ToString();
                    _alumno.Especialidad = reader[8].ToString();
                    lista.Add(_alumno);
                }
            } catch(MySqlException ex) {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return lista;
        }

        public Alumno ObtenerAlumnoPorId(int idPersona) {
            try {
                using (MySqlConnection conexion = base.conexion()) {
                    conexion.Open();

                    string query = "SELECT persona.id_persona, nombre_uno, nombre_dos, apellido_uno, apellido_dos, D_nacimiento, matricula, semestre, especialidad FROM persona, alumno WHERE persona.id_persona = alumno.id_persona AND persona.id_persona = @idPersona";
                    using (MySqlCommand command = new MySqlCommand(query, conexion)) {
                        command.Parameters.AddWithValue("@idPersona", idPersona);
                        using (MySqlDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                Alumno alumno = new Alumno();
                                alumno.Id_persona = int.Parse(reader.GetString(0));
                                alumno.PrimerNombre = reader[1].ToString();
                                alumno.SegundoNombre = reader[2].ToString();
                                alumno.ApPaterno = reader[3].ToString();
                                alumno.ApMaterno = reader[4].ToString();
                                alumno.FechaNacimiento = reader[5].ToString();
                                alumno.Matricula = reader[6].ToString();
                                alumno.Semestre = reader[7].ToString();
                                alumno.Especialidad = reader[8].ToString();
                                return alumno;
                            }
                        }
                    }
                }
            } catch (MySqlException ex) {
                MessageBox.Show("Error al obtener el registro del alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


        public Alumno actualizarRegistro(Alumno alumno) {        
            try {
                using (MySqlConnection conexion = base.conexion()) {
                    conexion.Open();

                    string updateQuery = "UPDATE persona SET nombre_uno = @nombreUno, nombre_dos = @nombreDos, apellido_uno = @apUno, apellido_dos = @apDos, D_nacimiento = @DNacimiento WHERE persona.id_persona = @idPersona";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexion)) {
                        updateCommand.Parameters.AddWithValue("@nombreUno", alumno.PrimerNombre);
                        updateCommand.Parameters.AddWithValue("@nombreDos", alumno.SegundoNombre);
                        updateCommand.Parameters.AddWithValue("@apUno", alumno.ApPaterno);
                        updateCommand.Parameters.AddWithValue("@apDos", alumno.ApMaterno);
                        updateCommand.Parameters.AddWithValue("@DNacimiento", alumno.FechaNacimiento);
                        updateCommand.Parameters.AddWithValue("@idPersona", alumno.Id_persona);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0) {
                            string updateQuery2 = "UPDATE alumno SET matricula = @matricula, semestre = @semestre, especialidad = @especialidad WHERE alumno.id_persona = @idPersona";
                            using (MySqlCommand updateCommand2 = new MySqlCommand(updateQuery2, conexion)) {
                                updateCommand2.Parameters.AddWithValue("@matricula", alumno.Matricula);
                                updateCommand2.Parameters.AddWithValue("@semestre", alumno.Semestre);
                                updateCommand2.Parameters.AddWithValue("@especialidad", alumno.Especialidad);
                                updateCommand2.Parameters.AddWithValue("@idPersona", alumno.Id_persona);

                                int rowsAffected2 = updateCommand2.ExecuteNonQuery();

                                if (rowsAffected2 > 0) {
                                    MessageBox.Show("Registro actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return alumno;
                                }
                                else  {
                                    MessageBox.Show("No se encontró el registro en la tabla de alumnos correspondiente al identificador especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            return alumno;
                        } else {
                            MessageBox.Show("No se encontró el registro con el identificador especificado en la tabla de personas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }
                }
            } catch (MySqlException ex) {
                MessageBox.Show("Error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void borrarRegistro(int identificador) {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) {
                try {
                    using (MySqlConnection conexion = base.conexion()) {
                        conexion.Open();

                        string personaQuery = "DELETE FROM persona WHERE persona.id_persona = @idPersona";
                        using (MySqlCommand personaCommand = new MySqlCommand(personaQuery, conexion)) {
                            personaCommand.Parameters.AddWithValue("@idPersona", identificador);

                            int personaFilas = personaCommand.ExecuteNonQuery();

                            if (personaFilas > 0) {

                                MessageBox.Show("Registro eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("No se encontró el registro con el identificador especificado en la tabla de personas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (MySqlException ex) {
                    MessageBox.Show("Error al intentar borrar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
