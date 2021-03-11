using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Personas")]
    public class Persona
    {
        //Atributos de la clase.
        private string aNombre;
        private string aApellido;
        private string aCiudadActual;
        private string aDireccion;
        private string aTelefono;
        private string aCorreo;

        //Constructores de la clase.
        public Persona() { }
        public Persona(string pNombre, string pApellido, string pCiudadActual, string pDireccion, string pTelefono, string pCorreo)
        {
            aNombre = pNombre;
            aApellido = pApellido;
            aCiudadActual = pCiudadActual;
            aDireccion = pDireccion;
            aTelefono = pTelefono;
            aCorreo = pCorreo;
        }

        //Setters y Getters de la clase.
        [Column("Nombre")]
        public string Nombre
        {
            set { aNombre = value; }
            get { return aNombre; }
        }

        [Column("Apellido")]
        public string Apellido
        {
            set { aApellido = value; }
            get { return aApellido; }
        }

        [Column("Ciudad")]
        public string CiudadActual
        {
            set { aCiudadActual = value; }
            get { return aCiudadActual; }
        }

        [Column("Direccion")]
        public string Direccion
        {
            set { aDireccion = value; }
            get { return aDireccion; }
        }

        [Column("Telefono")]
        public string Telefono
        {
            set { aTelefono = value; }
            get { return aTelefono; }
        }

        [Column("Correo")]
        public string Correo
        {
            set { aCorreo = value; }
            get { return aCorreo; }
        }
    }
}
