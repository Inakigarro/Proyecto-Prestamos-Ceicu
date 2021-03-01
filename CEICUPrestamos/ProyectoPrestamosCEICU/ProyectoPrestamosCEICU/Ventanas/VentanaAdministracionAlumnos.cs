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
                    ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoNombre(ParametroBusquedaTb.Text);
                }
            }
        }

        private void ParametroBusquedaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Vacio la lista en la ventana.
            ListaAlumnosDGV.DataSource = null;
            //Si el campo de texto esta vacio, muestro toda la lista de alumnos.
            if (ParametroBusquedaTb.TextLength == 0)
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
                    ListaAlumnosDGV.DataSource = new BindingSource().DataSource = fachada.BuscarAlumnoNombre(ParametroBusquedaTb.Text);
                }
            }
        }
    }
}
