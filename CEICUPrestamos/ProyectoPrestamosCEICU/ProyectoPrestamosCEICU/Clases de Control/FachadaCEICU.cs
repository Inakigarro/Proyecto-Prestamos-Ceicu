using ProyectoPrestamosCEICU.Clases_de_Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Control
{
    public class FachadaCEICU
    {
        public void AgregarAlumno(Alumno pAlumno)
        {
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    db.Alumnos.Add(pAlumno);
                    db.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public void AgregarAlumno(string pNombre, string pApellido, string pCiudad, string pDireccion, string pTelefono, string pCorreo, string pLegajo, string pCarrera)
        {
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    Alumno alumno = new Alumno(pNombre, pApellido, pCiudad, pDireccion, pTelefono, pCorreo, pLegajo, pCarrera);
                    db.Alumnos.Add(alumno);
                    db.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public List<Alumno> ListarAlumnos()
        {
            var listaAlumnos = new List<Alumno>();
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                foreach (Alumno alumno in db.Alumnos)
                {
                    listaAlumnos.Add(alumno);
                }
            }
            return listaAlumnos;
        }
    
    }
}
