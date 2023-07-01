using CustomerGrpcServer.DataLayer.Models;

namespace CustomerGrpcServer.DataLayer.Repositories
{
    public class CustomerRepository
    {
        private static List<CustomerModel> Customers;
        public CustomerRepository()
        {
            if (Customers == null)
            {
                Customers = new()
                {
                    new CustomerModel
                    {
                        Id = 1,
                        Age = 32,
                        Name = "Payam Darabi"
                    },

                    new CustomerModel
                    {
                        Id = 2,
                        Age = 39,
                        Name = "Seyyed Mehdi Hosseini"
                    }
                };
            }
        }

        public void Add(CustomerModel customer)
        {
            Customers.Add(customer);
        }

        public void Update(CustomerModel customerModel)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == customerModel.Id);
            if (customer != null)
            {
                Customers.Remove(customer);
                Customers.Add(customerModel);
            }
        }

        public void Delete(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                Customers.Remove(customer);
            }
        }

        public CustomerModel Get(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public List<CustomerModel> GetAll()
        {
            return Customers;
        }
    }
}
