using System;

namespace Rework
{
    class Panel
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Elon",
                LastName = "Musk",
                City = "Pretorya,South Africa",
                DateOfBirth = new DateTime(1971, 07, 28, 01, 01, 01),
                IdentityNumber = "99999999999"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Jeff",
                LastName = "Bezos",
                City = "Albuquerque, New Mexico, ABD",
                DateOfBirth = new DateTime(1964, 01, 12, 02, 02, 02),
                IdentityNumber = "88888888888"
            };

            Customer customer3 = new Customer
            {
                Id = 3,
                FirstName = "Andrew",
                LastName = "Lincoln",
                City = "London,United Kingdom",
                DateOfBirth = new DateTime(1973, 09, 14, 03, 03, 03),
                IdentityNumber = "77777777777"
            };

            Customer customer4 = new Customer
            {
                Id = 3,
                FirstName = "Norman",
                LastName = "Reedus",
                City = "Hollywood, Florida, ABD",
                DateOfBirth = new DateTime(1969, 01, 06, 04, 04, 04),
                IdentityNumber = "66666666666"
            };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Add(customer1);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.List(customer1);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Update(customer1);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Delete(customer1);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            //----------------------------------------------------------------------------------------------------------------------//
            customerManager.Add(customer2);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.List(customer2);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Update(customer2);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Delete(customer2);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            //----------------------------------------------------------------------------------------------------------------------//
            customerManager.Add(customer3);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.List(customer3);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Update(customer3);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Delete(customer3);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            //----------------------------------------------------------------------------------------------------------------------//
            customerManager.Add(customer4);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.List(customer4);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Update(customer4);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
            customerManager.Delete(customer4);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" ");
        }
    }
}
