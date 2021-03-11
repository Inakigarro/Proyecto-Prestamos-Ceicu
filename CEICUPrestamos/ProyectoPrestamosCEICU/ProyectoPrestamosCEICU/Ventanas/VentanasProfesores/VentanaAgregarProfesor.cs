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

namespace ProyectoPrestamosCEICU.Ventanas.VentanasProfesores
{
    public partial class VentanaAgregarProfesor : Form
    {
        public VentanaAgregarProfesor()
        {
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //Capturo la informacion ingresada.
            string nombre = NombreProfesorTb.Text;
            string apellido = ApellidoProfesorTb.Text;
            string ciudad = CiudadProfesorTb.Text;
            string direccion = DireccionProfesorTb.Text;
            string telefono = TelefonoProfesorTb.Text;
            string correo = CorreoProfesorTb.Text;
            string legajo = LegajoProfesorTb.Text;
            Materia materia = fachada.BuscarMateria(MateriaProfesorCb.Text);

            //Agrego el profesor a la base de datos.
            fachada.AgregarProfesor(nombre, apellido, ciudad, direccion, telefono, correo, legajo, materia);

            //Actualizo la lista de profesores.
            ventanaPadre.ActualizarListaProfesores();
        }
    }
}
