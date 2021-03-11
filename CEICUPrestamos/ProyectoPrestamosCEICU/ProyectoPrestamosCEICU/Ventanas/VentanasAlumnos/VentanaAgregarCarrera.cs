using ProyectoPrestamosCEICU.Clases_de_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamosCEICU.Ventanas.VentanasAlumnos
{
    public partial class VentanaAgregarCarrera : Form
    {
        private FachadaCEICU fachada;
        public VentanaAgregarCarrera()
        {
            InitializeComponent();
            fachada = new FachadaCEICU();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //Capturo los datos ingresados.
            string vCodigo = CodigoCarreraTb.Text;
            string vNombre = NombreCarreraTb.Text;
            //Agrego la carrera a la base de datos.
            try
            {
                fachada.AgregarCarrera(vNombre, vCodigo);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ya existe una carrera con ese codigo. Intente nuevamente.", "Codigo existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            this.Dispose();
        }
    }
}
