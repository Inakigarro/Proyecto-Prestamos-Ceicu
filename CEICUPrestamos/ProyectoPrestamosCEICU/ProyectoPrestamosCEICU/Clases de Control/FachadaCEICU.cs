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
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Agrego el alumno a la base de datos.
                    db.Alumnos.Add(pAlumno);
                    //Guardo los cambios.
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
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Creo el objeto Alumno con  los parametros ingresados.
                    Alumno alumno = new Alumno(pNombre, pApellido, pCiudad, pDireccion, pTelefono, pCorreo, pLegajo, pCarrera);
                    //Agrego el alumno creado a la base de datos.
                    db.Alumnos.Add(alumno);
                    //Gurado los cambios.
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
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<Alumno>();
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (Alumno alumno in db.Alumnos)
                    {
                        //Agrego cada alumno a la lista de alumnos a mostrar.
                        listaAlumnos.Add(alumno);
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            //Devuelvo la lista de alumnos. Puede estar vacia.
            return listaAlumnos;
        }
        public List<Alumno> BuscarAlumnoLegajo (string pLegajo)
        {
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<Alumno>();
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (Alumno alumno in db.Alumnos)
                    {
                        //Si el legajo del alumno es igual al ingresado.
                        if (alumno.Legajo == pLegajo)
                        {
                            //Agrego el alumno a la lista.
                            listaAlumnos.Add(alumno);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            //Devuelvo la lista de alumnos. Puede estar vacia.
            return listaAlumnos;
        }
        public List<Alumno> BuscarAlumnoNombre (string pNombre)
        {
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<Alumno>();
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (Alumno alumno in db.Alumnos)
                    {
                        //Si el nombre del alumno es igual al ingresado.
                        if (alumno.Nombre == pNombre)
                        {
                            //Agrego el alumno a la lista.
                            listaAlumnos.Add(alumno);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            //Devuelvo la lista de alumnos. Puede estar vacia.
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
        public List<Profesor> BuscarProfesorLegajo(string pLegajo)
        {
            //Creo la lista de profesores a mostrar.
            var listaProfesor = new List<Profesor>();
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de profesores en la base de datos.
                    foreach (Profesor profesor  in db.Profesores)
                    {
                        //Si el legajo del profesor es igual al ingresado.
                        if (profesor.Legajo == pLegajo)
                        {
                            //Agrego el profesor a la lista.
                            listaProfesor.Add(profesor);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            //Devuelvo la lista de profesores. Puede estar vacia.
            return listaProfesor;
        }
        public List<Profesor> BuscarProfesorNombre(string pNombre)
        {
            //Creo la lista de profesores a mostrar.
            var listaProfesor = new List<Profesor>();
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de profesores en la base de datos.
                    foreach (Profesor profesor in db.Profesores)
                    {
                        //Si el nombre del profesor es igual al ingresado.
                        if (profesor.Legajo == pNombre)
                        {
                            //Agrego el profesor a la lista.
                            listaProfesor.Add(profesor);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            //Devuelvo la lista de profesores. Puede estar vacia.
            return listaProfesor;
        }

        //Metodos referentes a Secretario.
        //Metodos referentes a Material.
        //Metodos referentes a Prestamo.
    }
}
