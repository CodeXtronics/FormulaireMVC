using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;

namespace FormulaireMvc
{
    [WebService(Namespace = "http://tempuri.org/",
    Description = "A Simple Web Calculator Service",
    Name = "CalculatorWebService")]
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WebService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WebService.svc ou WebService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WebService : IWebService
    {
        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int Division(int x, int y)
        {
            return x / y;
        }
    }
}
