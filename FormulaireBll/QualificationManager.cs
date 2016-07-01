using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireBo;
using FormulaireEntityDal;

namespace FormulaireBll
{
    class QualificationManager
    {
        // son repository
        IRepository<Qualification> qualificationDao;
        public QualificationManager(IRepository<Qualification> repos)
        {
            qualificationDao = repos;
        }

        public ICollection<Qualification> ChargerLesQualifications()
        {
            return qualificationDao.GetAll().ToList();
        }
    }
}
