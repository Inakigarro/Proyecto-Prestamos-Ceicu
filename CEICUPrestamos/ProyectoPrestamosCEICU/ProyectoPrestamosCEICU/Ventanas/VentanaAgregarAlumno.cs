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
    public partial class VentanaAgregarAlumno : Form
    {
        public VentanaAgregarAlumno()
        {
            InitializeComponent();
            CarreraAlumboCb.DataSource = Enum.GetValues(typeof(Carreras));
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            fachada.AgregarAlumno(NombreAlumnoTb.Text, ApellidoAlumnoTb.Text, CiudadAlumnoTb.Text,
                                  DireccionAlumnoTb.Text, TelefonoAlumnoTb.Text, CorreoAlumnoTb.Text,
                                  LegajoAlumnoTb.Text, CarreraAlumboCb.SelectedValue.ToString());
            VAAlumnos.ActualizarListaAlumnos();
            this.Close();
            this.Dispose();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
