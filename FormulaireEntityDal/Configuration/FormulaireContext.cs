using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FormulaireBo;
using FormulaireEntityDal.Configuration;

namespace FormulaireEntityDal.Configuration
{
    
    public class FormulaireContext:DbContext
    {
        public FormulaireContext() : base("name=CreationBase.Properties.Settings.AfpaEnqueteF") { }
        public DbSet<Sexe> Sexes { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Stagiaire> Stagiaires { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new SexeConfiguration());
            modelBuilder.Configurations.Add(new QualificationConfiguration());
            modelBuilder.Configurations.Add(new StagiaireConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
