using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1= new Customer { Id = 1, FirstName = "Arzu", LastName = "Yılmaz", Email = "arzu@example.com", Phone = "5551234567" };
            Customer customer2 = new Customer { Id = 2, FirstName = "Ayşe", LastName = "Kaya", Email = "ayse@example.com", Phone = "5559876543" };
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.ListCustomer();
            customerManager.DeleteCustomer(2);
            customerManager.ListCustomer();         
        }
    }
}
