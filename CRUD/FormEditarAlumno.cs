using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Controlador;
using CRUD.Modelo;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CRUD {
    public partial class FormEditarAlumno : MaterialForm {
        private Alumno alumno;
        public FormEditarAlumno(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;

            txtPrimerNombre.Text = alumno.PrimerNombre;
            txtSegundoNombre.Text = alumno.SegundoNombre;
            txtApPaterno.Text = alumno.ApPaterno;
            txtApMaterno.Text = alumno.ApMaterno;
            txtFechaNacimiento.Text = alumno.FechaNacimiento;
            txtMatricula.Text = alumno.Matricula;
            txtSemestre.Text = alumno.Semestre;
            txtEspecialidad.Text = alumno.Especialidad;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            alumno.PrimerNombre = txtPrimerNombre.Text;
            alumno.SegundoNombre = txtSegundoNombre.Text;
            alumno.ApPaterno = txtApPaterno.Text;
            alumno.ApMaterno = txtApMaterno.Text;
            alumno.FechaNacimiento = txtFechaNacimiento.Text;
            alumno.Matricula = txtMatricula.Text;
            alumno.Semestre = txtSemestre.Text;
            alumno.Especialidad = txtEspecialidad.Text;

            CtrlAlumno controladorAlumno = new CtrlAlumno();
            controladorAlumno.actualizarRegistro(alumno);
            this.Close();
        }

        public Alumno AlumnoActualizado
        {
            get
            {
                Alumno alumno = new Alumno();
                alumno.PrimerNombre = txtPrimerNombre.Text;
                alumno.SegundoNombre = txtSegundoNombre.Text;
                alumno.ApPaterno = txtApPaterno.Text;
                alumno.ApMaterno = txtApMaterno.Text;
                alumno.FechaNacimiento = txtFechaNacimiento.Text;
                alumno.Matricula = txtMatricula.Text;
                alumno.Semestre = txtSemestre.Text;
                alumno.Especialidad = txtEspecialidad.Text;
                return alumno;
            }
        }

    }
}
