using CRUD.Controlador;
using CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Vista {
    public partial class TablaInstructor : Form {
        private DataGridView dataGridView;
        private CtrlInstructor ctrlReuniones;

        public TablaInstructor(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            ctrlReuniones = new CtrlInstructor();
        }

        public void CargarDatos()
        {
            List<object> lista = ctrlReuniones.consulta();

            dataGridView.Rows.Clear();

            foreach (Instructor instructor in lista)
            {
                dataGridView.Rows.Add(instructor.Id_persona, instructor.PrimerNombre, instructor.SegundoNombre, instructor.ApPaterno, instructor.ApMaterno, instructor.FechaNacimiento, instructor.Folio);
            }
        }
    }
}
