using CRUD.Controlador;
using CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Vista {
    internal class TablaAgendadas : Form {
        private DataGridView dataGridView;
        private CtrlAgendadas ctrlAgendadas;

        public TablaAgendadas(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            ctrlAgendadas = new CtrlAgendadas();
        }

        public void CargarDatos()
        {
            List<object> lista = ctrlAgendadas.consulta();

            dataGridView.Rows.Clear();

            foreach (Agendada agendada in lista)
            {
                dataGridView.Rows.Add(agendada.Id_reunion, agendada.PrimerNombre, agendada.SegundoNombre, agendada.ApPaterno, agendada.ApMaterno, agendada.Matricula, agendada.Semestre, agendada.Especialidad, agendada.Id_reunion, agendada.Tema, agendada.Fecha, agendada.Hora, agendada.Lugar);
            }
        }
    }
}
