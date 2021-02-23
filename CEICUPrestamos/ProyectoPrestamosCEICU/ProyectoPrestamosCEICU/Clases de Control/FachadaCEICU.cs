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

        //Metodos referentes Alumno.
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

        //Metodos referentes a Profesor.
        public void AgregarProfesor(Profesor pProfesor)
        {
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    db.Profesores.Add(pProfesor);
                    db.SaveChanges();
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public void AgregarProfesor(string pNombre, string pApellido, string pCiudad, string pDireccion, string pTelefono, string pCorreo, string pLegajo, string pMateria)
        {
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    Profesor profesor = new Profesor(pNombre, pApellido, pCiudad, pDireccion, pTelefono, pCorreo, pLegajo, pMateria);
                    db.Profesores.Add(profesor);
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
        }
        public List<Profesor> ListarProfesores()
        {
            var listaProfesores = new List<Profesor>();
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                foreach (Profesor profesor in db.Profesores)
                {
                    listaProfesores.Add(profesor);
                }
            }
            return listaProfesores;
        }

        //Metodos referentes a Secretario.
        //Metodos referentes a Material.
        //Metodos referentes a Prestamo.
    }
}
