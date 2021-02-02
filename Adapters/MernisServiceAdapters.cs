using MernisServiceAdapter;
using System.Collections.Generic;
using MyGameSimulation.Entities;
using System.Text;


namespace MyGameSimulation.Adapters
{
    public class MernisServiceAdapters : IUserValidationService
    {
      


        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(gamer.IdentitiyNumber, gamer.FirstName, gamer.LastName,
                gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }


    
    }

}
