using CRUD.Controlador;
using CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Vista {
    public partial class TablaReunion : Form {
        private DataGridView dataGridView;
        private CtrlReuniones ctrlReuniones;

        public TablaReunion(DataGridView dataGridView) {
            this.dataGridView = dataGridView;
            ctrlReuniones = new CtrlReuniones();
        }

        public void CargarDatos() {
            List<object> lista = ctrlReuniones.consulta();

            dataGridView.Rows.Clear();

            foreach (Reunion reunion in lista) {
                dataGridView.Rows.Add(reunion.Id_reunion, reunion.Fecha, reunion.Hora, reunion.Lugar, reunion.Tema);
            }
        }
    }

}
