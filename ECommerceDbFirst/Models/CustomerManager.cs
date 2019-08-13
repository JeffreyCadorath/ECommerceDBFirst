using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceDbFirst.Models
{
    public class CustomerManager
    {
        ECommerceDBEntities db = new ECommerceDBEntities();

        public ICollection<Customer> GetCustomerInCity(string city)
        {
            var customerList = db.Customers.Where(x => x.City == city).ToList();
            return customerList;
        }
    }
}