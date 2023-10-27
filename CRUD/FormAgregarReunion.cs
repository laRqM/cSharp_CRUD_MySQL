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
using MySql.Data.MySqlClient;

namespace CRUD {
    public partial class FormAgregarReunion : MaterialForm {
        public FormAgregarReunion()
        {
            InitializeComponent();
        }

        private void btnAgregarReunion_Click_1(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string hora = txtHora.Text;
            string lugar = txtLugar.Text;
            string tema = txtTema.Text;

            if (string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(hora) || string.IsNullOrEmpty(lugar) || string.IsNullOrEmpty(tema))
            {
                MessageBox.Show("Favor de completar todos los campos antes de agregar la reunión.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CtrlReuniones controladorReuniones = new CtrlReuniones();
            bool agregadaExitosamente = controladorReuniones.AgregarReunion(fecha, hora, lugar, tema);

            if (agregadaExitosamente)
            {
                MessageBox.Show("Reunión agregada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la reunión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
