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

namespace ProyectoPrestamosCEICU.Ventanas.VentanasSecretarios
{
    public partial class VentanaCrearSecretaria : Form
    {
        private FachadaCEICU fachada = new FachadaCEICU();
        public VentanaCrearSecretaria()
        {
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturo los datos ingresados.
                string vIdSecretaria = IdSecretariaTb.Text;
                string vNombreSecretaria = NombreSecretariaTb.Text;

                //Creo la secretaria.
                fachada.AgregarSecretaria(vIdSecretaria, vNombreSecretaria);
            }
            catch (ArgumentException a)
            {
                if(a.Message == "Secretaria existente")
                {
                    MessageBox.Show("Ya existe una secretaria con ese Id. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
            Dispose();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
