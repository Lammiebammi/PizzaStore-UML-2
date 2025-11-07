using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CustomerFile
    {
        private List<Customer> _customerList = new List<Customer>();

        public void Add(Customer customer)
        {
            if (!_customerList.Contains(customer))
                _customerList.Add(customer);
        }

        // constructor 
        public CustomerFile()
        { }

        // FOR READ (get)
        public Customer? Get(int id)
        {
            // finder kunden, hvis id'et matcher
            foreach (Customer customer in _customerList)
            {
                if (customer.CustomerID == id)
                {
                    return customer;

                }

            }
            // Hvis der ingen kunde findes med det ID
            return null;
        }


        // UPDATE (update)
        public void Update(Customer updatedCustomer)
        {
            for (int i = 0; i < _customerList.Count; i++)
            {
                if (_customerList[i].CustomerID == updatedCustomer.CustomerID)
                {
                    _customerList[i] = updatedCustomer;

                }
            }
        }



        // DELETE (remove)
        public void Remove(int id)
        {
            for (int i = 0; i < _customerList.Count; i++)
            {
                if (_customerList[i].CustomerID == id)
                {
                    _customerList.RemoveAt(i);
                }
            }

        }

        public void PrintMenu()
        {
            Console.WriteLine("--- KUNDELISTE ---");

            foreach (Customer customer in _customerList)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("------");
        }
    }
}
 
  
       
    




