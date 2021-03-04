using ProyectoPrestamosCEICU.Clases_de_Dominio;
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
    public partial class VentanaModificarAlumno : Form
    {
        public VentanaModificarAlumno()
        {
            InitializeComponent();
            CarreraAlumboCb.DataSource = Enum.GetValues(typeof(Carreras));
        }

        public void CargarAlumno(string pLegajo)
        {
            //Busco el alumno en la base de datos.
            this.legajoAlumno = pLegajo;
            var alumno = fachada.BuscarAlumnoLegajo(pLegajo).First();

            //Cargo los datos del alumno en la ventana.
            NombreAlumnoTb.Text = alumno.Nombre;
            ApellidoAlumnoTb.Text = alumno.Apellido;
            CiudadAlumnoTb.Text = alumno.Ciudad;
            DireccionAlumnoTb.Text = alumno.Direccion;
            TelefonoAlumnoTb.Text = alumno.Telefono;
            CorreoAlumnoTb.Text = alumno.Correo;
            LegajoAlumnoTb.Text = alumno.Legajo;
            CarreraAlumboCb.Text = alumno.Carrera;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            string nombre = NombreAlumnoTb.Text;
            string apellido = ApellidoAlumnoTb.Text;
            string ciudad = CiudadAlumnoTb.Text;
            string direccion = DireccionAlumnoTb.Text;
            string telefono = TelefonoAlumnoTb.Text;
            string correo = CorreoAlumnoTb.Text;
            string legajo = LegajoAlumnoTb.Text;
            string carrera = CarreraAlumboCb.Text; 

            //Compruebo si se modifico el legajo del alumno cargado.
            if (this.legajoAlumno != legajo)
            {
                fachada.ModificarAlumno(nombre, apellido, ciudad, direccion, telefono, correo, this.legajoAlumno, legajo, carrera);
            }
            else
            {
                fachada.ModificarAlumno(nombre, apellido, ciudad, direccion, telefono, correo, legajo, carrera);
            }

            ventanaPadre.ActualizarListaAlumnos();
            this.Close();
            this.Dispose();

        }
    }
}
