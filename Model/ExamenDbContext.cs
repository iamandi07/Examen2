using Examen2.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2
{
    public class ExamenDbContext : IdentityDbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<InspectionPlan> InspectionPlans { get; set; }

        public DbSet<Equipments> Equipments { get; set; }

        public ExamenDbContext(DbContextOptions<ExamenDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipments>()
                .HasIndex(f => new { f.PersonId, f.InspectionPlanId })
                .IsUnique(true);
            base.OnModelCreating(modelBuilder);
        }

    }
}
