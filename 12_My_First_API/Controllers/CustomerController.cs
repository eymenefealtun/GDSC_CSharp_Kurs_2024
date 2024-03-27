using Microsoft.AspNetCore.Mvc;

namespace _12_My_First_API.Controllers
{
    [ApiController] // attribute
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        List<Customer> _customerList;
        Random _random;
        List<string> _cities;

        public CustomerController()
        {
            _customerList = new List<Customer>(); // ENCAPSULATION
            _random = new Random();
            _cities = new List<string>()
            {
                "Istanbul",
                "Ankara",
                "Urfa",
                "Izmir",
                "Adana"
            };

            CreateCustomer(10000);
        }

        //http://localhost:7025/GetAllCustomers
        [HttpGet("/GetAllCustomers")]
        public List<Customer> GetAllCustomers()
        {
            return _customerList;
        }

        //http://localhost:7025/GetAllCustomers/10
        [HttpGet("/GetAllCustomers/{numberOfCustomers}")]
        public List<Customer> GetAllCustomers(int numberOfCustomers)
        {
            return _customerList.Take(numberOfCustomers).ToList();
        }


        private void CreateCustomer(int numberToBeCreated)
        {
            for (int i = 0; i < numberToBeCreated; i++)
            {
                Customer customer = new Customer()
                {
                    Id = _random.Next(),
                    FirstName = GenerateName(_random.Next(5, 10)),
                    LastName = GenerateName(_random.Next(5, 10)),
                    City = _cities[_random.Next(0, _cities.Count)]
                };
                _customerList.Add(customer);
            }
        }

        private string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }


    }
}
