using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Profesores")]
    public class Profesor : Persona
    {
        //Atributos de la clase.

        private string aLegajo;
        
        private string aMateria;

        private bool aIsHabilitado;

        //Constructor de la clase.
        public Profesor() : base() { }
        public Profesor(string pNombre, string pApellido, string pCiudadActual, string pDireccion, string pTelefono, string pCorreo, string pLegajo, string pMateria)
            : base(pNombre, pApellido, pCiudadActual, pDireccion, pTelefono, pCorreo)
        {
            aLegajo = pLegajo;
            aMateria = pMateria;
        }

        //Setters y Getters de la clase.
        [Key]
        [Column("Legajo")]
        public string Legajo
        {
            set { aLegajo = value; }
            get { return aLegajo; }
        }

        [Column("Materia")]
        public string Materia
        {
            set { aMateria = value; }
            get { return aMateria; }
        }

        [Column("HabilitadoProfesor")]
        public bool Habilitado
        {
            get { return aIsHabilitado; }
            set { aIsHabilitado = value; }
        }
    }
}
