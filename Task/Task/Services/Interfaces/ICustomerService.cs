using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetAllByFullName(string name);
        int GetCount();
        public List<Customer> OrderByAge(List<Customer> customers);

        ////Person tipinden listimiz var. Maashi 1000-den cox olan personlarin ad, soyad ve addresini gosteren ve 
        ////parametr olaraq predicate qebul  eden method yazin.

        public List<Customer> GetByWage(Func<Customer, bool> expresssion);

        ////Book tipinden listimiz olacaq. Authoru  Nizami olan book-larin sayini gosteren ve predicate qebul eden method yazin.
        

    }
}
