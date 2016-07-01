using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using FormulaireBo;

namespace FormulaireEntityDal.Configuration
{
    public class StagiaireConfiguration:EntityTypeConfiguration<Stagiaire>
    {
        public StagiaireConfiguration():base()
        {
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nom)
                .IsRequired();
            Property(p => p.Prenom)
                .IsRequired();
            Property(p => p.DateDenaissance)
                .IsRequired();
            Property(p => p.Adresse)
                .IsRequired();
            Property(p => p.Ville)
                .IsRequired();
            Property(p => p.Email)
                .IsRequired();
            Property(p => p.Autre);
            Property(p => p.Remuneration)
                .IsRequired();
            Property(p => p.AnneeStage)
                .IsRequired();
            Property(p => p.Commentaire);

            HasRequired(p => p.LeSexe)
                .WithMany()
                .HasForeignKey(p => p.LeSexeId);
            HasRequired(p => p.LaQualification)
                .WithMany()
                .HasForeignKey(p => p.LaQualificationId);
            ToTable("Stagiaires");
        }
    }
}
