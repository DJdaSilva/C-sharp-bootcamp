using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerAPI.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
            Add(new CustomerItem { FirstName = "Daniel" });
        }

        public IEnumerable<CustomerItem> GetAll()
        {
            return _context.CustomerItems.ToList();
        }

        public void Add(CustomerItem item)
        {
            _context.CustomerItems.Add(item);
            _context.SaveChanges();
        }

        public CustomerItem Find(long customerId)
        {
            return _context.CustomerItems.FirstOrDefault(t => t.CustomerId == customerId);
        }

        public void Remove(long customerId)
        {
            var entity = _context.CustomerItems.First(t => t.CustomerId == customerId);
            _context.CustomerItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(CustomerItem item)
        {
            _context.CustomerItems.Update(item);
            _context.SaveChanges();
        }
    }
}