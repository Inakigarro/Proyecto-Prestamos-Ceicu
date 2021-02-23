using ProyectoPrestamosCEICU.Clases_de_Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamosCEICU.Clases_de_Control
{
    public class BaseDeDatosContext : DbContext
    {
        //Constructor de la clase.
        public BaseDeDatosContext() : base("name=PrestamosCEICU") { }

        //DbSets.
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Secretario> Secretarios { get; set; }
        public DbSet<Material> Materiales { get; set; }
    }
}
