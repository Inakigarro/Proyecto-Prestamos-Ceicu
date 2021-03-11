using ProyectoPrestamosCEICU.Clases_de_Dominio;
using ProyectoPrestamosCEICU.Clases_DTO;
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
    public partial class VentanaModificarAlumno : Form
    {
        private AlumnoDTO aAlumno;
        public VentanaModificarAlumno(AlumnoDTO pAlumno)
        {
            InitializeComponent();
            aAlumno = pAlumno;
            ListarCarreras();
            CargarAlumno();
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
        private void CargarAlumno()
        {
            //Cargo los campos de texto.
            NombreAlumnoTb.Text = aAlumno.Nombre;
            ApellidoAlumnoTb.Text = aAlumno.Apellido;
            CiudadAlumnoTb.Text = aAlumno.Ciudad;
            DireccionAlumnoTb.Text = aAlumno.Direccion;
            TelefonoAlumnoTb.Text = aAlumno.Telefono;
            CorreoAlumnoTb.Text = aAlumno.Correo;
            LegajoAlumnoTb.Text = aAlumno.Legajo;
            CarreraAlumboCb.SelectedItem = aAlumno.Carrera;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturo los datos de los campos.
                string vNombre = NombreAlumnoTb.Text;
                string vApellido = ApellidoAlumnoTb.Text;
                string vCiudad = CiudadAlumnoTb.Text;
                string vDireccion = DireccionAlumnoTb.Text;
                string vTelefono = TelefonoAlumnoTb.Text;
                string vCorreo = CorreoAlumnoTb.Text;
                string vLegajo = LegajoAlumnoTb.Text;
                string vCarrera = CarreraAlumboCb.SelectedItem.ToString();
                
                //Compruebo si se modifico el legajo.
                if (aAlumno.Legajo != vLegajo)
                {
                    var resultado = MessageBox.Show("Esta modificando el Legajo. ¿Esta seguro que desea hacerlo?",
                                    "Cuidado! Esta modificando el Legajo",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);
                    if(resultado == DialogResult.OK)
                    {
                        fachada.ModificarAlumnoNuevo(aAlumno, vNombre, vApellido, vCiudad, vDireccion, vTelefono, vCorreo, vLegajo, vCarrera);
                    }
                    
                }
                else
                {
                    fachada.ModificarAlumno(vNombre, vApellido, vCiudad, vDireccion, vTelefono, vCorreo, vLegajo, vCarrera);
                }
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
            this.Dispose();

        }

        private void AgregarCarreraBtn_Click(object sender, EventArgs e)
        {
            using (VentanaAgregarCarrera ventana = new VentanaAgregarCarrera())
            {
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    ListarCarreras();
                }
            }
            ListarCarreras();
        }
    }
}
