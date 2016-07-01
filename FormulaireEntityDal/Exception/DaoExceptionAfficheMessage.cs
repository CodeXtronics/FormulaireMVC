using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaireEntityDal.Exception
{

    [Serializable]
    public class DaoExceptionAfficheMessage : DaoException
    {
        public DaoExceptionAfficheMessage() { }
        public DaoExceptionAfficheMessage(string message) : base(message) { }
        public DaoExceptionAfficheMessage(string message, System.Exception inner) : base(message, inner) { }
        protected DaoExceptionAfficheMessage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
