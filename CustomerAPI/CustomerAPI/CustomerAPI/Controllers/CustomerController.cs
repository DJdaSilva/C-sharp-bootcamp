using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<CustomerItem> GetAll()
        {
            return _customerRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetById(long id)
        {
            var item = _customerRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _customerRepository.Add(item);

            return CreatedAtRoute("GetCustomer", new { id = item.CustomerId }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] CustomerItem item)
        {
            if (item == null || item.CustomerId != id)
            {
                return BadRequest();
            }

            var customer = _customerRepository.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            
            customer.FirstName = item.FirstName;
            customer.LastName = item.LastName;
            customer.Email = item.Email;
            customer.Phone = item.Phone;
            customer.Address = item.Address;
            customer.City = item.City;
            customer.Province = item.Province;
            customer.PostalAddress = item.PostalAddress;

            _customerRepository.Update(customer);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var customer = _customerRepository.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            _customerRepository.Remove(id);
            return new NoContentResult();
        }
    }
}
