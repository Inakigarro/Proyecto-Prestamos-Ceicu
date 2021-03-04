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
    public partial class VentanaAdministracionAlumnos : Form
    {
        public VentanaAdministracionAlumnos()
        {
            InitializeComponent();
            ListaAlumnosDGV.DataSource = (new BindingSource().DataSource = fachada.ListarAlumnos());
            NombreRb.Checked = true;
        }

        private void AgregarAlumnoBtn_Click(object sender, EventArgs e)
        {
            var ventanaAgregarAlumno = new VentanaAgregarAlumno();
            ventanaAgregarAlumno.VAAlumnos = this;
            ventanaAgregarAlumno.Activate();
            ventanaAgregarAlumno.Visible = true;
            
        }

        public void ActualizarListaAlumnos()
        {
            ListaAlumnosDGV.DataSource = null;
            ListaAlumnosDGV.DataSource = (new BindingSource().DataSource = fachada.ListarAlumnos());
        }

        private void BuscarAlumnoBtn_Click(object sender, EventArgs e)
        {
            //Vacio la lista en la ventana.
            ListaAlumnosDGV.DataSource = null;
            //Si el campo de texto esta vacio, muestro toda la lista de alumnos.
            if(ParametroBusquedaTb.TextLength == 0)
            {
                ActualizarListaAlumnos();
            }
            else
            {
                //Si esta seleccionada la opcion de legajo.
                if (LegajoRb.Checked)
                {
                    ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoLegajo(ParametroBusquedaTb.Text);
                }
                //Sino, estara seleccionado la opcion de nombre.
                else
                {
                    if (NombreRb.Checked)
                    {
                        ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoNombre(ParametroBusquedaTb.Text);
                    }
                }
            }
        }
        private void ParametroBusquedaTb_TextChanged(object sender, EventArgs e)
        {
            //Si esta seleccionada la opcion de legajo.
            if (LegajoRb.Checked)
            {
                ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoLegajo(ParametroBusquedaTb.Text);
            }
            //Sino, estara seleccionado la opcion de nombre.
            else
            {
                if (NombreRb.Checked)
                {
                    ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoNombre(ParametroBusquedaTb.Text);
                }
            }
        }

        private void ModificarAlumnoBtn_Click(object sender, EventArgs e)
        {
            //Capturo el legajo del alumno seleccionado.
            var filaSeleccionada = ListaAlumnosDGV.CurrentRow;
            var legajoAlumno = (string) filaSeleccionada.Cells[0].Value;

            //Llamo a la ventana para modificar los datos.
            var ventanaAlumnos = new VentanaModificarAlumno();
            ventanaAlumnos.VentanaPadre = this;
            ventanaAlumnos.CargarAlumno(legajoAlumno);
            ventanaAlumnos.Activate();
            ventanaAlumnos.Visible = true;
        }

        private void HabilitarAlumnoBtn_Click(object sender, EventArgs e)
        {
            //Capturo el legajo del alumno seleccionado.
            var legajoAlumno = (string)ListaAlumnosDGV.CurrentRow.Cells[0].Value;

            //Intento habilitar al alumno.
            try
            {
                fachada.HabilitarAlumno(legajoAlumno);
                MessageBox.Show("Alumno habilitado correctamente.", "Alumno Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WarningException)
            {
                MessageBox.Show("Este alumno ya estaba habilitado.", "Error: Alumno No Habilitado" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Capturo el legajo del alumno seleccionado.
            var legajoAlumno = (string)ListaAlumnosDGV.CurrentRow.Cells[0].Value;

            //Intento deshabilitar al alumno.
            try
            {
                fachada.DeshabilitarAlumno(legajoAlumno);
                MessageBox.Show("Alumno deshabilitado correctamente.", "Alumno Deshabilitado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WarningException)
            {
                MessageBox.Show("Este alumno ya estaba deshabilitado.", "Error: Alumno No Deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
