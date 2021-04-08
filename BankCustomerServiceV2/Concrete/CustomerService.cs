using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rework
{
    class CustomerManager : ICustomerAdd, ICustomerDelete, ICustomerUpdate, IListCustomer
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer successfully added to the system" + "| | |" + "Id: " + customer.Id + " | " + "FirstName: " + customer.FirstName + " | " + "LastName: " + customer.LastName + " | " + "City: " + customer.City + " | " + "Date Of Birty: " + customer.DateOfBirth + " | " + "Identity Number: " + customer.IdentityNumber + " | " + "ADDED" + " | ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("The customer has been successfully deleted from the system" + "| | |" + customer.Id + " | " + "FirstName: " + customer.FirstName + " | " + "LastName: " + customer.LastName + " | " + "City: " + customer.City + " | " + "Date Of Birty: " + customer.DateOfBirth + " | " + "Identity Number: " + customer.IdentityNumber + " | " + "DELETED" + " | ");
        }

        public void List(Customer customer)
        {
            Customer[] list = new Customer[] { customer };

            foreach (var search in list)
            {
                Console.WriteLine("Customer information listed" + "| | |" + "Id: " + customer.Id + " | " + "FirstName: " + customer.FirstName + " | " + "LastName: " + customer.LastName + " | " + "City: " + customer.City + " | " + "Date Of Birty: " + customer.DateOfBirth + " | " + "Identity Number: " + customer.IdentityNumber + " | " + "LISTED" + " | ");
            }

        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer information has been updated in the system" + "| | |" + "Id: " + customer.Id + " | " + "FirstName: " + customer.FirstName + " | " + "LastName: " + customer.LastName + " | " + "City: " + customer.City + " | " + "Date Of Birty: " + customer.DateOfBirth + " | " + "Identity Number: " + customer.IdentityNumber + " | " + "UPDATED" + " | ");
        }
    }
}
