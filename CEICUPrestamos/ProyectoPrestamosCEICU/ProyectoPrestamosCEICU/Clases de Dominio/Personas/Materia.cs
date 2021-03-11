using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    public class Materia
    {
        //Atributos de la clase.
        private int aIdMateria;
        private string aNombre;

        //Constructores de la clase.
        public Materia()
        {

        }

        public Materia(string pNombre)
        {
            aNombre = pNombre;
        }

        //Getters y Setters de la clase.
        [Key]
        [Column("IdMateria")]
        public int IdMateria
        {
            get { return aIdMateria; }
            set { aIdMateria = value; }
        }

        [Column("NombreMateria")]
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
    }
}
