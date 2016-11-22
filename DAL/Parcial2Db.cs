using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base ("Parcial")
        {

        }

        public DbSet<Clientes> Cliente { get; set; }

        public DbSet<TiposTelefonos> TipoTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .HasMany<TiposTelefonos>(C => C.TipoTelefonos)
                .WithMany(TT => TT.Clientes)
                .Map(CT =>
                {
                    CT.MapLeftKey("ClienteId");
                    CT.MapRightKey("TipoId");
                    CT.ToTable("ClientesTelefonos");
                });
        }
    }
}
