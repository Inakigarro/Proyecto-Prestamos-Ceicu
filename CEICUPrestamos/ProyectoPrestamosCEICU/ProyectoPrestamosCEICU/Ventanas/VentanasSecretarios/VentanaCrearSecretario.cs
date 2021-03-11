using ProyectoPrestamosCEICU.Clases_de_Control;
using ProyectoPrestamosCEICU.Clases_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamosCEICU.Ventanas.VentanasSecretarios
{
    public partial class VentanaCrearSecretario : Form
    {
        private AlumnoDTO alumno;
        private FachadaCEICU fachada = new FachadaCEICU();
        public VentanaCrearSecretario(AlumnoDTO pAlumno)
        {
            InitializeComponent();
            alumno = pAlumno;
            CargarAlumno();
            CargarSecretarias();
        }

        private void CargarAlumno()
        {
            LegajoAlumnoTb.Text = alumno.Legajo;
            NombreAlumnoTb.Text = alumno.Nombre;
            ApellidoAlumnoTb.Text = alumno.Apellido;
        }
        private void CargarSecretarias()
        {
            try
            {
                var lista = new List<string>();
                foreach (var secretaria in fachada.ListarSecretarias())
                {
                    lista.Add(secretaria.NombreSecretaria);
                }
                NombreSecretariaCb.DataSource = null;
                NombreSecretariaCb.DataSource = lista;
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Error al cargar secretarias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CrearSecretariaBtn_Click(object sender, EventArgs e)
        {
            using(VentanaCrearSecretaria ventana = new VentanaCrearSecretaria())
            {
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    CargarSecretarias();
                }
            }
            CargarSecretarias();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturo los datos ingresados.
                string vNombreSecretaria = NombreSecretariaCb.SelectedItem.ToString();
                string vPinSecretario = ContraseñaSecretarioTb.Text;

                fachada.AgregarSecretario(vNombreSecretaria, vPinSecretario, alumno.Legajo);
            }
            catch (Exception)
            {

                throw;
            }

            Close();
            Dispose();
        }
    }
}
