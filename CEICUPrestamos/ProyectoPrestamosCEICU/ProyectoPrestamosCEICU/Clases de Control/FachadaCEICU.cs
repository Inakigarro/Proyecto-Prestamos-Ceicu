using ProyectoPrestamosCEICU.Clases_de_Dominio;
using ProyectoPrestamosCEICU.Clases_DTO;
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
        //Metodos referentes a la clase Carrera.
        public void AgregarCarrera(string pNombre, string pCodigo) //Agrega una carrera a la base de datos.
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Consulto si la carrera ya existe.
                    var prueba = db.Carreras.Find(pCodigo);
                    if (prueba != null)
                    {
                        //Si existe, lanzo excepcion de argumento.
                        throw new ArgumentException("Carrera existente");
                    }
                    else
                    {
                        //Si no existe, creo la carrera y la agrego a la base de datos.
                        Carrera carrera = new Carrera(pNombre, pCodigo);
                        db.Carreras.Add(carrera);
                        db.SaveChanges();
                    }
                }
                catch (NullReferenceException)
                {

                    throw new NullReferenceException("Error al buscar carrera");
                }
            }
        }  

        public Carrera BuscarCarrera(string pCodigo) //Busca una carrera.
        {
            Carrera carrera = null;
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la carrera por el codigo.
                    carrera = db.Carreras.Find(pCodigo);
                    if(carrera == null)
                    {
                        throw new NullReferenceException("Carrera no existe.");
                    }
                }
                catch (NullReferenceException e)
                {
                    throw e;
                }
                return carrera;
            }
        } 

        public void ModificarCarrera(string pNombre, string pCodigo)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la carrera.
                    Carrera carrera = db.Carreras.Find(pCodigo);
                    if(carrera != null)
                    {
                        carrera.Nombre = pNombre;
                    }
                    else
                    {
                        throw new NullReferenceException("Carrera no existe");
                    }
                }
                catch (NullReferenceException e)
                {

                    throw e;
                }
            }
        }

        public List<CarreraDTO> ListarCarreras()
        {
            //Creo la lista a devolver.
            var listaCarrera = new List<CarreraDTO>();

            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    foreach (var carrera in db.Carreras)
                    {
                        var carreraDTO = new CarreraDTO
                        {
                            Codigo = carrera.Codigo,
                            Nombre = carrera.Nombre
                        };
                        listaCarrera.Add(carreraDTO);
                    }
                }
                catch (NullReferenceException)
                {
                    throw new NullReferenceException("Error al cargar carrera");
                }
                
            }

            //Devuelvo la lista.
            return listaCarrera;
        }

        public void EliminarCarrera(string pCodigo)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la carrera por el codigo ingresado.
                    var carrera = db.Carreras.Find(pCodigo);

                    //Si la encontro, la elimino.
                    if(carrera != null)
                    {
                        db.Carreras.Remove(carrera);
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new ArgumentException("Carrera no existe.");
                    }
                }
                catch (ArgumentException e)
                {

                    throw e;
                }                
            }
        }

        //Metodos referentes a la clase Alumno.

        public void AgregarAlumno(string pNombre, string pApellido, string pCiudad, 
                                  string pDireccion, string pTelefono, string pCorreo, 
                                  string pLegajo, string pCarrera)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la carrera en la base de datos.
                    var vCarrera = db.Carreras.Find(pCarrera);
                    //Busco si ya existe un alumno con ese legajo.
                    var vAlumno = db.Alumnos.Find(pLegajo);
                    if (vCarrera != null || vAlumno == null)
                    {
                        Alumno alumno = new Alumno(pNombre, pApellido, pCiudad,
                                                   pDireccion, pTelefono, pCorreo,
                                                   pLegajo, vCarrera);
                        db.Alumnos.Add(alumno);
                        db.SaveChanges();
                    }
                    else
                    {
                        if (vCarrera == null)
                        {
                            throw new ArgumentException("Carrera no existe");
                        }
                        if(vAlumno != null)
                        {
                            throw new ArgumentException("Alumno ya existe");
                        }
                    }
                }
                catch (ArgumentException e)
                {

                    throw e;
                }
                
            }
        }
        
        public List<AlumnoDTO> ListarAlumnos()
        {
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<AlumnoDTO>();
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (var alumno in db.Alumnos.Include(x => x.Carrera).Include(x => x.Secretario).Include(x => x.Secretario.Secretaria))
                    {
                        if(alumno.Secretario != null)
                        {
                            var alumnoDTO = new AlumnoDTO
                            {
                                Legajo = alumno.Legajo,
                                Nombre = alumno.Nombre,
                                Apellido = alumno.Apellido,
                                Ciudad = alumno.CiudadActual,
                                Direccion = alumno.Direccion,
                                Telefono = alumno.Telefono,
                                Correo = alumno.Correo,
                                Carrera = alumno.Carrera.Codigo,
                                Secretaria = alumno.Secretario.Secretaria.NombreSecretaria
                            };
                            //Agrego cada alumno a la lista de alumnos a mostrar.
                            listaAlumnos.Add(alumnoDTO);
                        }
                        else
                        {
                            var alumnoDTO = new AlumnoDTO
                            {
                                Legajo = alumno.Legajo,
                                Nombre = alumno.Nombre,
                                Apellido = alumno.Apellido,
                                Ciudad = alumno.CiudadActual,
                                Direccion = alumno.Direccion,
                                Telefono = alumno.Telefono,
                                Correo = alumno.Correo,
                                Carrera = alumno.Carrera.Codigo,
                            };
                            //Agrego cada alumno a la lista de alumnos a mostrar.
                            listaAlumnos.Add(alumnoDTO);
                        }
                        
                    }
                }
                catch (NullReferenceException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            //Devuelvo la lista de alumnos. Puede estar vacia.
            return listaAlumnos;
        }

        public List<AlumnoDTO> BuscarAlumnoLegajo (string pLegajo)
        {
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<AlumnoDTO>();
            //Creo el contexto para trabajar con la base de datos.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (Alumno alumno in db.Alumnos.Include(x => x.Carrera).Include(x => x.Secretario))
                    {
                        //Si el legajo del alumno es igual al ingresado.
                        if (alumno.Legajo.Contains(pLegajo))
                        {
                            var alumnoDTO = new AlumnoDTO
                            {
                                Legajo = alumno.Legajo,
                                Nombre = alumno.Nombre,
                                Apellido = alumno.Apellido,
                                Ciudad = alumno.CiudadActual,
                                Direccion = alumno.Direccion,
                                Telefono = alumno.Telefono,
                                Correo = alumno.Correo,
                                Carrera = alumno.Carrera.Codigo
                            };
                            //Agrego el alumno a la lista.
                            listaAlumnos.Add(alumnoDTO);
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

        public List<AlumnoDTO> BuscarAlumnoNombre (string pNombre)
        {
            //Creo la lista de alumnos a mostrar.
            var listaAlumnos = new List<AlumnoDTO>();
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Recorro la lista de alumnos en la base de datos.
                    foreach (Alumno alumno in db.Alumnos.Include(x => x.Carrera).Include(x => x.Secretario))
                    {
                        string nombreApellido = alumno.Nombre + ' ' + alumno.Apellido;
                        //Si el nombre del alumno es igual al ingresado.
                        if (nombreApellido.Contains(pNombre))
                        {
                            var alumnoDTO = new AlumnoDTO
                            {
                                Legajo = alumno.Legajo,
                                Nombre = alumno.Nombre,
                                Apellido = alumno.Apellido,
                                Ciudad = alumno.CiudadActual,
                                Direccion = alumno.Direccion,
                                Telefono = alumno.Telefono,
                                Correo = alumno.Correo,
                                Carrera = alumno.Carrera.Codigo
                            };
                            //Agrego el alumno a la lista.
                            listaAlumnos.Add(alumnoDTO);
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

        public void ModificarAlumno(string pNombre, string pApellido, string pCiudad, string pDireccion, string pTelefono, string pCorreo, string pLegajo, string pCarrera)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    Alumno vAlumno = null;
                    //Busco el alumno.
                    foreach (var alumno in db.Alumnos.Include(x => x.Carrera).Include(x => x.Secretario).Include(x => x.Secretario.Secretaria))
                    {
                        if(alumno.Legajo == pLegajo)
                        {
                            vAlumno = alumno;
                        }
                    }
                    
                    if(vAlumno != null)
                    {
                        if(vAlumno.Carrera.Codigo != pCarrera)
                        {
                            var vCarrera = db.Carreras.Find(pCarrera);
                            vAlumno.Carrera = vCarrera;
                        }
                        vAlumno.Nombre = pNombre;
                        vAlumno.Apellido = pApellido;
                        vAlumno.CiudadActual = pCiudad;
                        vAlumno.Direccion = pDireccion;
                        vAlumno.Telefono = pTelefono;
                        vAlumno.Correo = pCorreo;
                        vAlumno.Legajo = pLegajo;
                    }
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new NullReferenceException();
                }
            }
        }

        public void ModificarAlumnoNuevo(AlumnoDTO pAlumno, string pNombre, string pApellido, 
                                         string pCiudad, string pDireccion, string pTelefono,
                                         string pCorreo, string pLegajo, string pCarrera)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco el alumno a eliminar.
                    Alumno vAlumnoViejo = null;
                    //Busco el alumno.
                    foreach (var alumno in db.Alumnos.Include(x => x.Carrera))
                    {
                        if (alumno.Legajo == pAlumno.Legajo)
                        {
                            vAlumnoViejo = alumno;
                        }
                    }
                    //Si lo encontro, lo elimino.
                    if (vAlumnoViejo != null)
                    {
                        db.Alumnos.Remove(vAlumnoViejo);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                db.SaveChanges();
            }
            //Una vez eliminado el objeto nuevo, cargo el nuevo.
            AgregarAlumno(pNombre, pApellido, pCiudad, pDireccion, pTelefono, pCorreo, pLegajo, pCarrera);
        }

        public void HabilitarAlumno(string pLegajo)
        {
            //Creo el contexto para trabajar con la base dedatos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                //Busco el alumno.
                var alumno = db.Alumnos.Find(pLegajo);

                //Si ya esta habilitado, lanzo excepcion.
                if (alumno.Habilitado == true)
                {
                    throw new WarningException();
                }
                //Si no, habilito.
                else
                {
                    alumno.Habilitar();
                }
                db.SaveChanges();
            }
        }

        public void DeshabilitarAlumno(string pLegajo)
        {
            //Creo el contexto para trabajar con la base dedatos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                //Busco el alumno.
                var alumno = db.Alumnos.Find(pLegajo);

                //Si ya esta habilitado, lanzo excepcion.
                if (alumno.Habilitado == false)
                {
                    throw new WarningException();
                }
                //Si no, habilito.
                else
                {
                    alumno.Deshabilitar();
                }
                db.SaveChanges();
            }
        }

        //Metodos referentes a la clase Secretario.
        public void AgregarSecretario(string pNombreSecretaria, string pContraseña, string pLegajo)
        {
            //Creo el contexto para trabajar con la base de datos
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                Secretaria vSecretaria = null;
                //Busco el alumno por legajo.
                var alumno = db.Alumnos.Find(pLegajo);
                //Busco la secretaria.
                foreach (var secretaria in db.Secretarias)
                {
                    if(secretaria.NombreSecretaria == pNombreSecretaria)
                    {
                        vSecretaria = secretaria;
                    }
                }

                if (vSecretaria != null)
                {
                    Secretario secretario = new Secretario(vSecretaria, pContraseña);
                    alumno.Secretario = secretario;

                    Usuario usuario = new Usuario
                    {
                        Legajo = pLegajo,
                        Contraseña = pContraseña
                    };

                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Error al buscar carrera");
                }

            }
        }
        public void ModificarSecretario() { }
        public void EliminarSecretario() { }
        //Metodos referentes a la clase Secretaria.
        public void AgregarSecretaria(string pIdSecretaria, string pNombreSecretaria)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //compruebo que no exista una secretaria con el IdSecretaria ingresado.
                    foreach (var item in db.Secretarias)
                    {
                        if(item.IdSecretaria == pIdSecretaria)
                        {
                            throw new ArgumentException("Secretaria existente");
                        }
                    }

                    //Creo el objeto secretaria.
                    Secretaria secretaria = new Secretaria(pIdSecretaria, pNombreSecretaria);

                    //Guardo la secretaria en la base de datos y guardo los cambios.
                    db.Secretarias.Add(secretaria);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public IList<SecretariaDTO> BuscarSecretariaNombre(string pNombreSecretaria)
        {
            var listaSecretaria = new List<SecretariaDTO>();
            //Creo el contexto para trabajar con la base de dato.
            using(BaseDeDatosContext db = new BaseDeDatosContext())
            {
                foreach (var secretaria in db.Secretarias)
                {
                    if(secretaria.NombreSecretaria == pNombreSecretaria)
                    {
                        var sec = new SecretariaDTO
                        {
                            IdSecretaria = secretaria.IdSecretaria,
                            NombreSecretaria = secretaria.NombreSecretaria,
                        };
                        listaSecretaria.Add(sec);
                    }
                }
            }
            return listaSecretaria;
        }

        public IList<SecretariaDTO> ListarSecretarias()
        {
            //Creo la lista a devolver.
            List<SecretariaDTO> lista = new List<SecretariaDTO>();
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                foreach (var secretaria in db.Secretarias)
                {
                    SecretariaDTO sec = new SecretariaDTO
                    {
                        IdSecretaria = secretaria.IdSecretaria,
                        NombreSecretaria = secretaria.NombreSecretaria
                    };
                    lista.Add(sec);
                }
            }
            return lista;
        }

        public void ModificarSecretaria(string pIdSecretaria, string pNombreSecretaria)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la secretaria.
                    var secretaria = db.Secretarias.Find(pIdSecretaria);
                    if (secretaria != null)
                    {
                        secretaria.IdSecretaria = pIdSecretaria;
                        secretaria.NombreSecretaria = pNombreSecretaria;
                    }
                    else
                    {
                        throw new NullReferenceException("Error al buscar secretaria");
                    }
                    db.SaveChanges();
                }
                catch (NullReferenceException e)
                {

                    throw e;
                }
            }
        }

        public void ModificarSecretariaNuevo(SecretariaDTO pSecretaria, string pIdSecretaria, string pNombreSecretaria)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la secretaria a eliminar.
                    var secretariaVieja = db.Secretarias.Find(pSecretaria.IdSecretaria);

                    if(secretariaVieja != null)
                    {
                        db.Secretarias.Remove(secretariaVieja);
                    }
                    else
                    {
                        throw new NullReferenceException("Error al buscar secretaria");
                    }

                    //Creo la nueva secretaria.
                    Secretaria secretaria = new Secretaria(pIdSecretaria, pNombreSecretaria);

                    //Guardo la secretaria nueva en la base de datos y guardo los cambios.
                    db.Secretarias.Add(secretaria);
                    db.SaveChanges();
                }
                catch (NullReferenceException e)
                {

                    throw e;
                }
            }
        }

        public void EliminarSecretaria(string pIdSecretaria)
        {
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    //Busco la secretaria por Id.
                    var secretaria = db.Secretarias.Find(pIdSecretaria);
                    if(secretaria != null)
                    {
                        //Elimino la secretaria.
                        db.Secretarias.Remove(secretaria);
                    }
                    else
                    {
                        throw new NullReferenceException("Secretaria no existe");
                    }

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }  
            }
        }


        //Metodos referentes a la clase Materia.
        public void AgregarMateria(string pNombre)
        {
            var vBool = false;
            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    foreach (var materia in db.Materias)
                    {
                        if (materia.Nombre == pNombre)
                        {
                            vBool = true;
                        }
                    }
                    if (!vBool)
                    {
                        Materia materia = new Materia(pNombre);
                        db.Materias.Add(materia);
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new ArgumentException("Materia ya existe");
                    }
                }
                catch (ArgumentException e)
                {

                    throw e;
                }
                
            }
        }
        
        public Materia BuscarMateria(string pNombre)
        {
            Materia materia = null;

            //Creo el contexto para trabajar con la base de datos.
            using (BaseDeDatosContext db = new BaseDeDatosContext())
            {
                try
                {
                    foreach (var mat in db.Materias)
                    {
                        if(mat.Nombre == pNombre)
                        {
                            materia = mat;
                        }
                    }

                    if(materia == null) { throw new ArgumentException("Materia no existe"); }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return materia;
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

        public void AgregarProfesor(string pNombre, string pApellido, string pCiudad, string pDireccion, string pTelefono, string pCorreo, string pLegajo, Materia pMateria)
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
                        if (profesor.Legajo.Contains(pLegajo))
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
                        string nombreApellido = profesor.Nombre + ' ' + profesor.Apellido;
                        if (nombreApellido.Contains(pNombre))
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


        //Metodos referentes a Material.
        //Metodos referentes a Prestamo.
    }
}
