using ProyectoPrestamosCEICU.Clases_de_Dominio;
using ProyectoPrestamosCEICU.Ventanas.VentanasAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamosCEICU.Ventanas
{
    public partial class VentanaAgregarAlumno : Form
    {
        public VentanaAgregarAlumno()
        {
            InitializeComponent();
            ListarCarreras();
        }

        private void ListarCarreras()
        {
            var lista = new List<string>();
            var listaCarreras = fachada.ListarCarreras();
            foreach (var item in listaCarreras)
            {
                lista.Add(item.Codigo);
            }
            CarreraAlumboCb.DataSource = lista;
            CarreraAlumboCb.Refresh();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturo la informacion ingresada.
                string nombre = NombreAlumnoTb.Text;
                string apellido = ApellidoAlumnoTb.Text;
                string ciudad = CiudadAlumnoTb.Text;
                string direccion = DireccionAlumnoTb.Text;
                string telefono = TelefonoAlumnoTb.Text;
                string correo = CorreoAlumnoTb.Text;
                string legajo = LegajoAlumnoTb.Text;
                string carrera = CarreraAlumboCb.SelectedItem.ToString();

                //Agrego el alumno a la base de datos.
                fachada.AgregarAlumno(nombre, apellido, ciudad, direccion, telefono, correo, legajo, carrera);

                this.Close();
                this.Dispose();
            }
            catch (ArgumentException a)
            {

                if(a.Message == "Carrera no existe")
                {
                    MessageBox.Show("No existe la carrera seleccionada o no se encontro en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(a.Message == "Alumno ya existe")
                {
                    MessageBox.Show("Ya existe un alumno con ese legajo. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AgregarCarrera_Click(object sender, EventArgs e)
        {
            using (VentanaAgregarCarrera ventana = new VentanaAgregarCarrera())
            {
                if(ventana.ShowDialog() == DialogResult.OK)
                {
                    ListarCarreras();
                }
            }
            ListarCarreras();
        }
    }
}
