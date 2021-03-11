using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Carreras")]
    public class Carrera
    {
        //Atributos de la clase.
        private string aCodigo;
        private string aNombre;
        private bool aHablitada;

        //Constructores de la clase.
        public Carrera()
        {

        }
        public Carrera(string pNombre, string pCodigo)
        {
            aNombre = pNombre;
            aCodigo = pCodigo;
            aHablitada = true;
        }

        //Propiedades de la clase.
        [Key]
        [Column("Codigo")]
        public string Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }

        [Column("Nombre")]
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
        
        [Column("Habilitada")]
        public bool Habilitada 
        { 
            get { return aHablitada; } 
            set { aHablitada = value; } 
        }
    }
}
