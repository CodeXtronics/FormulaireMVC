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
    public class EnQualificationDao : IRepository<Qualification>
    {
        public void Delete(Qualification obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Qualification> GetAll()
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                List<Qualification> lt;
                //var AllQualifications = db.Qualifications;
                //ICollection<Qualification> LesQualifications = null;
                try
                {
                    lt = db.Qualifications.ToList();
                    return lt.ToList();
                    // Requête simple
                    //===========================


                    //foreach (Qualification item in AllQualifications)
                    //{
                    //    LesQualifications.Add(item);
                    //}
                    //return LesQualifications;
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }

        public Qualification GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Qualification obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Qualification obj)
        {
            throw new NotImplementedException();
        }
    }
}
