using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireBo;
using FormulaireEntityDal;

namespace FormulaireBll
{
    class SexeManager
    {
        // son repository
        IRepository<Sexe> sexeDao;
        public SexeManager(IRepository<Sexe> repos)
        {
            sexeDao = repos;
        }

        public ICollection<Sexe> ChargerLesSexes()
        {
            return sexeDao.GetAll().ToList();
        }
    }
}
