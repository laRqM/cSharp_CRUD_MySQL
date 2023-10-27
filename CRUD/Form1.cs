using CRUD.Controlador;
using CRUD.Modelo;
using CRUD.Vista;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD {
    public partial class Form1 : Form {
        private TablaAlumno tablaAlumno;
        private TablaReunion tablaReunion;
        private TablaInstructor tablaInstructor;
        private TablaAgendadas tablaAgendada;
        private Dictionary<string, List<DataGridViewColumn>> tablasColumnas = new Dictionary<string, List<DataGridViewColumn>>();
        private string tablaActual = "";

        public Form1() {
            InitializeComponent();
            this.Controls.Add(dataGridView1);

            List<DataGridViewColumn> columnasAlumno = new List<DataGridViewColumn>();
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "IdPersona", HeaderText = "Identificador" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "primerNombre", HeaderText = "Primer Nombre" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "segundoNombre", HeaderText = "Segundo Nombre" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "apellidoPaterno", HeaderText = "Apellido Paterno" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "apellidoMaterno", HeaderText = "Apellido Materno" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "fechaNacimiento", HeaderText = "Fecha de Nacimiento" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "Matricula", HeaderText = "Matrícula" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "Semestre", HeaderText = "Semestre" });
            columnasAlumno.Add(new DataGridViewTextBoxColumn { Name = "Especialidad", HeaderText = "Especialidad" });
            tablasColumnas["Alumno"] = columnasAlumno;

            List<DataGridViewColumn> columnasReunion = new List<DataGridViewColumn>();
            columnasReunion.Add(new DataGridViewTextBoxColumn { Name = "IdReunion", HeaderText = "ID de la Reunión" });
            columnasReunion.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha" });
            columnasReunion.Add(new DataGridViewTextBoxColumn { Name = "Hora", HeaderText = "Hora" });
            columnasReunion.Add(new DataGridViewTextBoxColumn { Name = "Lugar", HeaderText = "Lugar" });
            columnasReunion.Add(new DataGridViewTextBoxColumn { Name = "Tema", HeaderText = "Tema" });
            tablasColumnas["Reunion"] = columnasReunion;

            List<DataGridViewColumn> columnasInstructor = new List<DataGridViewColumn>();
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "IdPersona", HeaderText = "Identificador" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "primerNombre", HeaderText = "Primer Nombre" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "segundoNombre", HeaderText = "Segundo Nombre" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "apellidoPaterno", HeaderText = "Apellido Paterno" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "apellidoMaterno", HeaderText = "Apellido Materno" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "fechaNacimiento", HeaderText = "Fecha de Nacimiento" });
            columnasInstructor.Add(new DataGridViewTextBoxColumn { Name = "Folio", HeaderText = "Folio" });
            tablasColumnas["Instructor"] = columnasInstructor;

            List<DataGridViewColumn> columnasAgendada = new List<DataGridViewColumn>();
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "IdPersona", HeaderText = "Identificador" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "primerNombre", HeaderText = "Primer Nombre" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "segundoNombre", HeaderText = "Segundo Nombre" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "apellidoPaterno", HeaderText = "Apellido Paterno" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "apellidoMaterno", HeaderText = "Apellido Materno" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Matricula", HeaderText = "Matrícula" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Semestre", HeaderText = "Semestre" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Especialidad", HeaderText = "Especialidad" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "IdReunion", HeaderText = "ID Reunión" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Tema", HeaderText = "Tema" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Hora", HeaderText = "Hora" });
            columnasAgendada.Add(new DataGridViewTextBoxColumn { Name = "Lugar", HeaderText = "Lugar" });
            tablasColumnas["Agendada"] = columnasAgendada;

            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            dataGridView1.MouseDown += dataGridView_MouseDown;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            //dataGridView1.CellMouseClick += dataGridView_CellMouseClick;
        }

        private void MostrarTabla(string tabla)
        {
            if (tablasColumnas.ContainsKey(tabla))
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.AddRange(tablasColumnas[tabla].ToArray());

                switch (tabla)
                {
                    case "Alumno":
                        tablaAlumno = new TablaAlumno(dataGridView1);
                        tablaAlumno.CargarDatos();
                        break;
                    case "Reunion":
                        tablaReunion = new TablaReunion(dataGridView1);
                        tablaReunion.CargarDatos();
                        break;
                    case "Instructor":
                        tablaInstructor = new TablaInstructor(dataGridView1);
                        tablaInstructor.CargarDatos();
                        break;
                    case "Agendada":
                        tablaAgendada = new TablaAgendadas(dataGridView1);
                        tablaAgendada.CargarDatos();
                        break;
                }
            }

            tablaActual = tabla;
        }

        private void btnAlumnoTable_Click(object sender, EventArgs e)
        {
            MostrarTabla("Alumno");
        }

        private void btnReunionesTable_Click(object sender, EventArgs e)
        {
            MostrarTabla("Reunion");
        }

        private void btnInstructoresTable_Click(object sender, EventArgs e)
        {
            MostrarTabla("Instructor");
        }

        private void btnReunionesAgendadasTable_Click(object sender, EventArgs e)
        {
            MostrarTabla("Agendada");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip1.Show(dataGridView1, e.Location);
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;

                string idPersona = dataGridView1.Rows[filaSeleccionada].Cells["IdPersona"].Value.ToString();


            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            if (dataGridView1.SelectedRows.Count > 0 && !string.IsNullOrEmpty(tablaActual))
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;

                switch (tablaActual)
                {
                    case "Alumno":
                        string idPersona = dataGridView1.Rows[filaSeleccionada].Cells["IdPersona"].Value.ToString();
                        CtrlAlumno controladorAlumno = new CtrlAlumno();
                        Alumno alumno = controladorAlumno.ObtenerAlumnoPorId(int.Parse(idPersona));

                        FormEditarAlumno formEditarAlumno = new FormEditarAlumno(alumno);
                        DialogResult result = formEditarAlumno.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            Alumno alumnoActualizado = formEditarAlumno.AlumnoActualizado;
                            if (alumnoActualizado != null)
                            {
                                alumno = controladorAlumno.actualizarRegistro(alumnoActualizado);
                                if (alumno != null)
                                {
                                    MostrarTabla("Alumno");
                                }
                            }
                        }
                        break;
                    case "Reunion":
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !string.IsNullOrEmpty(tablaActual))
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;

                switch (tablaActual)
                {
                    case "Alumno":
                        string idPersona = dataGridView1.Rows[filaSeleccionada].Cells["IdPersona"].Value.ToString();
                        CtrlAlumno controladorAlumno = new CtrlAlumno();
                        controladorAlumno.borrarRegistro(int.Parse(idPersona));
                        dataGridView1.Refresh();
                        break;
                    case "Reunion":
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)sender;
                    contextMenuStrip1.Show(dataGridView, e.Location);
                }
            }
        }

        private void btnStripNuevaReunion_Click(object sender, EventArgs e)
        {
            CtrlReuniones controladorReuniones = new CtrlReuniones();

            FormAgregarReunion formAgregarReunion = new FormAgregarReunion();
            DialogResult result = formAgregarReunion.ShowDialog();
        }
    }
}