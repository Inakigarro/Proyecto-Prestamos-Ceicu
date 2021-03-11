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
    public partial class VentanaModificarSecretaria : Form
    {
        private FachadaCEICU fachada;
        private SecretariaDTO aSecretaria;
        public VentanaModificarSecretaria(SecretariaDTO pSecretaria)
        {
            InitializeComponent();
            aSecretaria = pSecretaria;
            CargarSecretaria();
        }

        private void CargarSecretaria()
        {
            IdSecretariaTb.Text = aSecretaria.IdSecretaria;
            NombreSecretariaTb.Text = aSecretaria.NombreSecretaria;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //Capturo los datos ingresados.
            string vIdSecretaria = IdSecretariaTb.Text;
            string vNombreSecretaria = NombreSecretariaTb.Text;

            try
            {
                if(aSecretaria.IdSecretaria != vIdSecretaria)
                {
                    fachada.ModificarSecretariaNuevo(aSecretaria, vIdSecretaria, vNombreSecretaria);
                }
                else
                {
                    fachada.ModificarSecretaria(vIdSecretaria, vNombreSecretaria);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
