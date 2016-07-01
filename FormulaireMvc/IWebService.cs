using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FormulaireMvc
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWebService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWebService
    {
        [OperationContract]
        int Add(int x,int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
        int Division(int x, int y);
    }
}
