using Newtonsoft.Json;
using ProductsAndSuppliers.Entities;
using ProductsAndSuppliers.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsAndSuppliers.Services
{
    public class CoronaService : WebServiceBase
    {   
        protected const string endpoint = "https://corona.lmao.ninja/v2/countries";

        public virtual async Task<IEnumerable<Corona>> GetAllAsync()
        {
            string json = await CallWebApiAsync(endpoint);

            IEnumerable<Corona> countryData = JsonConvert.DeserializeObject<IEnumerable<Corona>>(json);

            return countryData;
        }

        public virtual async Task<Corona> GetByNameAsync(string countryName)
        {
            string json = await CallWebApiAsync($"{endpoint}/{countryName}");

            Corona countryData = JsonConvert.DeserializeObject<Corona>(json);

            return countryData;
        }
    }
}