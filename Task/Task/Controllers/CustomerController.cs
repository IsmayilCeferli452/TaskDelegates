using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data;
using Task.Services;
using Task.Services.Interfaces;

namespace Task.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public void GetAll()
        {
            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine($"Fullname: {item.FullName} | Address: {item.Address} | Age: {item.Age}");
                Console.WriteLine("===================================================================");
            }
        }

        public void GetById()
        {
            var item = _customerService.GetById(1);
            Console.WriteLine($"Fullname: {item.FullName} | Address: {item.Address} | Age: {item.Age}");
        }

        public void GetAllByFullName()
        {
            var result = _customerService.GetAllByFullName("Ismayil Ceferli");

            foreach (var item in result)
            {
                Console.WriteLine($"Fullname: {item.FullName} | Address: {item.Address} | Age: {item.Age}");
            }
        }

        public void GetCount()
        {
            var result = _customerService.GetCount();
            Console.WriteLine(result);
        }

        public void OrderByAge()
        {
            var customers = _customerService.OrderByAge(_customerService.GetAll());

            foreach (var item in customers)
            {
                Console.WriteLine($"Fullname: {item.FullName} | Address: {item.Address} | Age: {item.Age}");
                Console.WriteLine("===================================================================");
            }
        }

        public void GetByWage()
        {
            var foundCustomers = _customerService.GetByWage(m=> m.Wage > 1000);

            foreach (var item in foundCustomers)
            {
                Console.WriteLine($"Fullname: {item.FullName} | Address: {item.Address} | Age: {item.Age} | Wage: {item.Wage}");
            }
        }
    }
}
