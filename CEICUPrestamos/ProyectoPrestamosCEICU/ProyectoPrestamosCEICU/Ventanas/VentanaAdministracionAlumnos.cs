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
    }
}
