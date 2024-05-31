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
        public DbSet<NCD> NCD { get; set; }
        public DbSet<PatientInfoStore> PatientInfoStore { get; set; }
        public DbSet<NCD_Details> NCD_Details { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatientInfoStore>()
                .HasMany(p => p.NCDs)
                .WithOne(o => o.PatientInfoStore)
                .HasForeignKey(o => o.PatientInfoId);

            modelBuilder.Entity<PatientInfoStore>()
                .HasMany(p => p.Allergies)
                .WithOne(a => a.PatientInfoStore)
                .HasForeignKey(a => a.PatientInfoId);
        }
    }
}
