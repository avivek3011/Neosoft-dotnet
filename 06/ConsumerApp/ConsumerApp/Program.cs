using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CallCustomerService();
            CallCalculatorService(20, 5);
            Console.Read();
        }
        static void CallCalculatorService(int a, int b)
        {
            CalculatorServiceReference.CalculatorSoapClient client = new CalculatorServiceReference.CalculatorSoapClient();
            Console.WriteLine($"{a}+{b}={client.Add(a,b)}");
            Console.WriteLine($"{a}/{b}={client.Divide(a,b)}");
            Console.WriteLine($"{a}*{b}={client.Multiply(a,b)}");
            Console.WriteLine($"{a}-{b}={client.Subtract(a, b)}");
        }
        static void CallCustomerService()
        {
            CustomerServiceReference.CustomerServiceClient client = new CustomerServiceReference.CustomerServiceClient();
            var customers=client.GetCustomers();
            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Name}  {c.Email}");
            }
        }
    }
}
