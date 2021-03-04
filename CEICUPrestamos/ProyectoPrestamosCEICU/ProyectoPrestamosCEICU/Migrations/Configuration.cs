namespace ProyectoPrestamosCEICU.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProyectoPrestamosCEICU.Clases_de_Control.BaseDeDatosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProyectoPrestamosCEICU.Clases_de_Control.BaseDeDatosContext";
        }

        protected override void Seed(ProyectoPrestamosCEICU.Clases_de_Control.BaseDeDatosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
