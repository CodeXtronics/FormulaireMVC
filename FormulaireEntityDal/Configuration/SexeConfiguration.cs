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
    public class SexeConfiguration:EntityTypeConfiguration<Sexe>
    {
        public SexeConfiguration():base()
        {

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Type)
                .IsRequired();
            ToTable("Genre");
        }
    }
}
