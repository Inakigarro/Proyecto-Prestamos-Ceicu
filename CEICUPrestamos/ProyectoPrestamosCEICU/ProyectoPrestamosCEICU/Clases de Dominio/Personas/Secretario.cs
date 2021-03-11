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
        
        private Secretaria aSecretaria;

        private string aPin;

        //Constructores de la clase.
        public Secretario() { }
        public Secretario(Secretaria pSecretaria, string pPin)
        {
            aSecretaria = pSecretaria;
            aPin = pPin;
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
        public Secretaria Secretaria
        {
            set { aSecretaria = value; }
            get { return aSecretaria; }
        }

        [Column("Pin")]
        public string Pin
        {
            get { return aPin; }
            set { aPin = value; }
        }

        //Metodos de la clase.
        public string GetSecretaria()
        {
            if(Secretaria != null)
            {
                return Secretaria.NombreSecretaria;
            }
            else
            {
                throw new NullReferenceException("Secretaria");
            }
        }
    }
}
