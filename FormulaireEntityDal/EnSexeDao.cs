using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireBo;
using FormulaireEntityDal.Configuration;
using FormulaireEntityDal.Exception;

namespace FormulaireEntityDal
{
    public class EnSexeDao : IRepository<Sexe>
    {
        public void Delete(Sexe obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Sexe> GetAll()
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                List<Sexe> lt;
                try
                {
                    lt = db.Sexes.ToList();
                    return lt.ToList();
                    //ICollection<Sexe> LesSexe = null;
                    //var AllSexes = db.Sexes;
                    //foreach (Sexe item in AllSexes)
                    //{
                    //    LesSexe.Add(item);
                    //}
                    //return LesSexe;
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }

        public Sexe GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Sexe obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Sexe obj)
        {
            throw new NotImplementedException();
        }
    }
}
