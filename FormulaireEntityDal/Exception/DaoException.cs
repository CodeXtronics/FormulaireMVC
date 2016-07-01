using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaireEntityDal.Exception
{
        [Serializable]
        public class DaoException : System.Exception
        {
            public DaoException() { }
            public DaoException(string message) : base(message) { }
            public DaoException(string message, System.Exception inner) : base(message, inner) { }
            protected DaoException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    
}
