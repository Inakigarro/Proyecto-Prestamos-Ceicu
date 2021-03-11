using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Secretarias")]
    public class Secretaria
    {
        //Atributo de la clase.
        private string aIdSecretaria;

        private string aNombreSecretaria;

        //Constructores de la clase.
        public Secretaria() { }

        public Secretaria(string pIdSecretaria, string pNombreSecretaria)
        {
            aIdSecretaria = pIdSecretaria;
            aNombreSecretaria = pNombreSecretaria;
        }

        //Getters y Setters de la clase.
        [Key]
        [Column("IdSecretaria")]
        public string IdSecretaria
        {
            get { return aIdSecretaria; }
            set { aIdSecretaria = value; }
        }

        [Column("Secretaria")]
        public string NombreSecretaria
        {
            get { return aNombreSecretaria; }
            set { aNombreSecretaria = value; }
        }
    }
}
