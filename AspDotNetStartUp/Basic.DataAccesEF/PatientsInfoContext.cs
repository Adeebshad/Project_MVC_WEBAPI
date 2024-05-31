using Basic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF
{
    public class PatientsInfoContext : DbContext
    {
        public PatientsInfoContext(DbContextOptions options) : base(options) { }

        public DbSet<Allergies> Allergies{ get; set; }
        public DbSet<Diseases> Diseases { get; set; }
        public DbSet<NCD> Ncd { get; set; }
        public DbSet<PatientInfoStore> PatientInfoStore { get; set; }
        public DbSet<OtherNCD> OtherNCDs { get; set; }
        public DbSet<OtherAllergy> OtherAllergies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatientInfoStore>()
                .HasMany(p => p.OtherNCDs)
                .WithOne(o => o.PatientInfoStore)
                .HasForeignKey(o => o.PatientInfoId);

            modelBuilder.Entity<PatientInfoStore>()
                .HasMany(p => p.Allergies)
                .WithOne(a => a.PatientInfoStore)
                .HasForeignKey(a => a.PatientInfoId);
        }
    }
}
