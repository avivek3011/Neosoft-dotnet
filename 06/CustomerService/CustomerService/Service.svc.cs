using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>() { 
                new Customer(){Id=1, Name="Tom", Email="tom@yahoo.com", Password="Password123"},
                new Customer(){Id=2, Name="Jerry", Email="jerry@outlook.com", Password="Password123"}
            };
            return customers;
        }
    }
}
