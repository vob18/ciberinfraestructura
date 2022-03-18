using Microsoft.EntityFrameworkCore;
using WebServicePostgre.Models;

namespace WebServicePostgre.DataAccess
{
    /// <summary>
    /// Monserrat Delgado 20220312
    /// CREACIÓN
    /// </summary>
    public class PostgreSqlContext : DbContext
    {
        /// <summary>
        /// Propiedades de modelo en conjunto con set de datos
        /// </summary>
        public DbSet<catalumno> catalumno { get; set; }

        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Monserrat Delgado 20220312
        /// CREACIÓN
        /// Sobreescribe el acceso a persistencia y guardado de datos
        /// </summary>
        /// <returns>int</returns>
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

    }
}
