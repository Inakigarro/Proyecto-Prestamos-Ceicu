using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Dominio
{
    [Table("Alumnos")]
    public class Alumno : Persona
    {
        //Atributos de la clase.
        private string aLegajo;
        private string aCarrera;
        private Secretario aSecretario;
        private bool aIsHabilitado;

        //Constructores de la clase.
        public Alumno() : base() { }
        public Alumno(string pNombre, string pApellido, string pCiudadActual, string pDireccion, string pTelefono, string pCorreo, string pLegajo, string pCarrera)
            :base(pNombre, pApellido, pCiudadActual, pDireccion, pTelefono, pCorreo)
        {
            aLegajo = pLegajo;
            aCarrera = pCarrera;
            aIsHabilitado = true;
        }

        //Setters y Getters de la clase.
        [Key]
        [Column("Legajo")]
        public string Legajo
        {
            set { aLegajo = value; }
            get { return aLegajo; }
        }

        [Column("Carrera")]
        public string Carrera
        {
            set { aCarrera = value; }
            get { return aCarrera; }
        }

        [Column("HabilitadoAlumno")]
        public bool Habilitado
        {
            get { return aIsHabilitado; }
            set { aIsHabilitado = value; }
        }
        public Secretario Secretario
        {
            set { aSecretario = value; }
            get { return aSecretario; }
        }

        //Metodos de la clase.
        public void Habilitar()
        {
            Habilitado = true;
        }
        public void Deshabilitar()
        {
            Habilitado = false;
        }
        public bool IsSecretario()
        {
            bool resultado = false;
            if(Secretario != null)
            {
                resultado = true;
            }
            return resultado;
        }
        public string getSecretaria()
        {
            string resultado = "";
            if (IsSecretario())
            {
                resultado = Secretario.Secretaria;
            }
            else
            {
                resultado = "El alumno no es secretario de la comision directiva del CEICU";
            }
            return resultado;
        }
    }
}
