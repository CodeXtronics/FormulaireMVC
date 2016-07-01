using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FormulaireBo;
using FormulaireEntityDal.Configuration;
using FormulaireEntityDal.Exception;

namespace FormulaireEntityDal
{
    public class EnStagiaireDao : IRepository<Stagiaire>
    {
        public void Insert(Stagiaire obj)
        {
            using (FormulaireContext db =new FormulaireContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(obj.LaQualification).State = EntityState.Unchanged;
                    db.Entry(obj.LeSexe).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new DaoException("Le code existe déjà");

                    throw new DaoException(ex.Message);
                }
                //try
                //{
                //    db.Stagiaires.Add(obj);
                //    int n = db.SaveChanges();
                //}
                //catch (DaoExceptionAfficheMessage ex)
                //{

                //    throw new DaoExceptionAfficheMessage("" + ex.Message);
                //}
            }
        }

        public void Update(Stagiaire obj)
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }
        public void Delete(Stagiaire obj)
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                try
                {
                    db.Stagiaires.Attach(obj);
                    db.Stagiaires.Remove(obj);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }

        public ICollection<Stagiaire> GetAll()
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                ICollection<Stagiaire> LesStag = null;
                try
                {
                    
                    var AllStagiaires = db.Stagiaires;
                    foreach (Stagiaire item in AllStagiaires)
                    {
                        LesStag.Add(item);
                    }
                    return LesStag;
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }

        public Stagiaire GetById(object id)
        {
            using (FormulaireContext db = new FormulaireContext())
            {
                try
                {
                    var Lestag = db.Stagiaires.Find(id);
                    if (Lestag==null)
                    {
                        throw new DaoExceptionAfficheMessage("Stagiaire inexistant");
                    }
                    return Lestag;
                }
                catch (DaoExceptionAfficheMessage ex)
                {

                    throw new DaoExceptionAfficheMessage("" + ex.Message);
                }
            }
        }


    }
}
