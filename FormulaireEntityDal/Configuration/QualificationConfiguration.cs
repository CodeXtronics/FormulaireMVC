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
    public class QualificationConfiguration:EntityTypeConfiguration<Qualification>
    {
        public QualificationConfiguration():base()
        {
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.LibelleQualification)
                .HasColumnName("La Qualification")
                .IsRequired();
            ToTable("Qualifications");
        }
    }
}
