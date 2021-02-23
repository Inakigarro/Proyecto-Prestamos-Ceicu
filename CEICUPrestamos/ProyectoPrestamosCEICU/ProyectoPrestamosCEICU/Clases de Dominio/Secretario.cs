using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Secretarios")]
    public class Secretario
    {
        //Atributos de la clase.
        
        private int aIdSecretario;
        
        private string aSecretaria;

        //Constructores de la clase.
        public Secretario() { }
        public Secretario(string pSecretaria)
        {
            aSecretaria = pSecretaria;
        }

        //Setters y Getters de la clase.
        [Key]
        [Column("IdSecretario")]
        public int IdSecretario
        {
            set { aIdSecretario = value; }
            get { return aIdSecretario; }
        }

        [Column("Secretaria")]
        public string Secretaria
        {
            set { aSecretaria = value; }
            get { return aSecretaria; }
        }
    }
}
