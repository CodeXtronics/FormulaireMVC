using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireBo;
using FormulaireBll;
using FormulaireEntityDal;

namespace FormulaireBll
{
    public class GestionnaireFormulaire
    {
        QualificationManager qualifMgr;
        SexeManager sexeMgr;
        StagiaireManager stagMgr;
        public GestionnaireFormulaire()
        {
            qualifMgr = new QualificationManager(new EnQualificationDao());
            sexeMgr = new SexeManager(new EnSexeDao());
            stagMgr = new StagiaireManager(new EnStagiaireDao());
        }
        public ICollection<Sexe> ChargerLesSexes()
        {
            return sexeMgr.ChargerLesSexes();
        }

        public ICollection<Qualification> ChargerLesQualifications()
        {
            return qualifMgr.ChargerLesQualifications();
        }

        public void CreerStagiaire(Stagiaire s)
        {
            stagMgr.CreerStagiaire(s);
        }
    }
}
