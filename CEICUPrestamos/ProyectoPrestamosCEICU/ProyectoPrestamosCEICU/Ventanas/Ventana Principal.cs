using ProyectoPrestamosCEICU.Ventanas;
using ProyectoPrestamosCEICU.Ventanas.VentanasProfesores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamosCEICU
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void AdministracionAlumnosMI_Click(object sender, EventArgs e)
        {
            var ventana = new VentanaAdministracionAlumnos();
            ventana.Activate();
            ventana.Visible = true;
        }

        private void AdministracionProfesoresMI_Click(object sender, EventArgs e)
        {
            var ventana = new VentanaAdministracionProfesores();
            ventana.Activate();
            ventana.Visible = true;
        }
    }
}
