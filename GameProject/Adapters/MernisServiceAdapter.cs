using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName, gamer.LastName, gamer.BirthYear);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
