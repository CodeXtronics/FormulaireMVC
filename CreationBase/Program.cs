using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaireEntityDal.Configuration;

namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new FormulaireInit());
            using (var context = new FormulaireContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}