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
    public partial class VentanaAdministracionProfesores : Form
    {
        public VentanaAdministracionProfesores()
        {
            InitializeComponent();
            ListaProfesoresDGV.DataSource = (new BindingSource().DataSource = fachada.ListarProfesores());
        }
        public void ActualizarListaProfesores()
        {
            ListaProfesoresDGV.DataSource = null;
            ListaProfesoresDGV.DataSource = (new BindingSource().DataSource = fachada.ListarProfesores());
        }

        private void AgregarAlumnoBtn_Click(object sender, EventArgs e)
        {
            var ventana = new VentanaAgregarProfesor();
            ventana.VentanaPadre = this;
            ventana.Activate();
            ventana.Visible = true;
        }
    }
}
