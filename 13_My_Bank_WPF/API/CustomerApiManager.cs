using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace _13_My_Bank_WPF.API
{
    internal class CustomerApiManager
    {
        string _baseUrl = "https://localhost:7058";
        //https://localhost:7058/GetAllCustomers
        public async Task<List<Customer>> GetAllCustomers()
        {
            string url = _baseUrl + "/GetAllCustomers";
            using (HttpClient httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(url);

                var responseString = await response.Content.ReadAsStringAsync();

                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(responseString).ToList();

                return customers;
            }
        }


    }
}
