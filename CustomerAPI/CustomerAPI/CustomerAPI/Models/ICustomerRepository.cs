using System.Collections.Generic;

namespace CustomerAPI.Models
{
    public interface ICustomerRepository
    {
        void Add(CustomerItem item);

        IEnumerable<CustomerItem> GetAll();

        CustomerItem Find(long customerId);

        void Remove(long customerId);

        void Update(CustomerItem item);
    }
}