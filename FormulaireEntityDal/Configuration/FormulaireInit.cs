using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FormulaireBo;

namespace FormulaireEntityDal.Configuration
{
    public class FormulaireInit:DropCreateDatabaseAlways<FormulaireContext>
    {
        protected override void Seed(FormulaireContext db)
        {
            Sexe masculin = new Sexe {Id=1,Type="Masculin" };
            Sexe feminin = new Sexe { Id=2,Type="Feminin"};
            Qualification qualif1 = new Qualification { Id = 1, LibelleQualification = "Developpeur" };
            Qualification qualif2 = new Qualification { Id = 2, LibelleQualification = "Game Designer" };
            Qualification qualif3 = new Qualification { Id = 3, LibelleQualification = "Developpeur web" };
            Qualification qualif4 = new Qualification { Id = 4, LibelleQualification = "Concepteur Developpeur" };
            Qualification qualif5 = new Qualification { Id = 5, LibelleQualification = "Analiste Big Data" };

            db.Qualifications.Add(qualif1);
            db.Qualifications.Add(qualif2);
            db.Qualifications.Add(qualif3);
            db.Qualifications.Add(qualif4);
            db.Qualifications.Add(qualif5);
            db.Sexes.Add(masculin);
            db.Sexes.Add(feminin);
        }
    }
}
