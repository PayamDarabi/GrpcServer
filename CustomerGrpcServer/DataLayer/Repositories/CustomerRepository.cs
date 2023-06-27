using CustomerGrpcServer.DataLayer.Models;

namespace CustomerGrpcServer.DataLayer.Repositories
{
    public static class CustomerRepository
    {
        private static List<CustomerModel> Customers = new();
        public static void Add(CustomerModel customer)
        {
            Customers.Add(customer);
        }

        public static void Update(CustomerModel customerModel)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == customerModel.Id);
            if (customer != null)
            {
                Customers.Remove(customer);
                Customers.Add(customerModel);
            }
        }

        public static void Delete(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                Customers.Remove(customer);
            }
        }

        public static CustomerModel Get(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public static List<CustomerModel> GetAll()
        {
            return Customers;
        }
    }
}
