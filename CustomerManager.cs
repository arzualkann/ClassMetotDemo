using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"{customer.FirstName} {customer.LastName} has been successfully added.");
        }
        public void DeleteCustomer(int customerId)
        {
            Customer customerToDelete = null;
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerId)
                {
                    customerToDelete = customer;
                    break;
                }
            }

            if (customerToDelete != null)
            {
                customers.Remove(customerToDelete);
                Console.WriteLine(customerToDelete.FirstName + " " + customerToDelete.LastName + " has been successfully deleted.");
            }
            else
            {
                Console.WriteLine("Customer with the specified ID was not found.");
            }
        }
        public void ListCustomer()
        {
            Console.WriteLine("Customers: ");
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, First Name: {customer.FirstName}, " +
                    $"Last Name: {customer.LastName}, Email: {customer.Email}, Phone: {customer.Phone}");
            }
        }

    }
}
