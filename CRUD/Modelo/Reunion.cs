using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Modelo {
    class Reunion {
        private int id_reunion;
        private string fecha;
        private string hora;
        private string lugar;
        private string tema;

        public int Id_reunion { get => id_reunion; set => id_reunion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string Tema { get => tema; set => tema = value; }
    }
}
