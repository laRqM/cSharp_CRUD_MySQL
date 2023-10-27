using CRUD.Controlador;
using CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Vista {
    public partial class TablaAlumno : Form {
        private DataGridView dataGridView;
        private CtrlAlumno ctrlAlumno;

        public TablaAlumno(DataGridView dataGridView) {
            this.dataGridView = dataGridView;
            ctrlAlumno = new CtrlAlumno();
        }

        public void CargarDatos() {
            List<object> lista = ctrlAlumno.consulta();

            dataGridView.Rows.Clear();

            foreach (Alumno alumno in lista) {
                dataGridView.Rows.Add(alumno.Id_persona, alumno.PrimerNombre, alumno.SegundoNombre, alumno.ApPaterno, alumno.ApMaterno, alumno.FechaNacimiento, alumno.Matricula, alumno.Semestre, alumno.Especialidad);
            }
        }
    }
}
