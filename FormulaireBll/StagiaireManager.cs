using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireBo;
using FormulaireEntityDal;

namespace FormulaireBll
{
    public class StagiaireManager
    {
        // son repository
        private IRepository<Stagiaire> stagDao;
        public StagiaireManager(){}
        public StagiaireManager(IRepository<Stagiaire> repos)
        {
            stagDao = repos;
        }
        public void CreerStagiaire(Stagiaire s)
        {
            stagDao.Insert(s);
        }
    }
}
