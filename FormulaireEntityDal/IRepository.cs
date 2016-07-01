using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaireEntityDal
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        T GetById(object id);
        ICollection<T> GetAll();
    }
}
