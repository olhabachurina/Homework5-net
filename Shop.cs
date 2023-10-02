using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_net
{
    internal class Shop
    {
        private string name;
        private string address;
        private string description;
        private string contactPhone;
        private string email;

        public void EnterData()
        {
            Console.Write("Enter store name: ");
            name = Console.ReadLine();

            Console.Write("Enter store address: ");
            address = Console.ReadLine();

            Console.Write("Enter a description of the store profile: ");
            description = Console.ReadLine();

            Console.Write("Enter the store's contact phone number: ");
            contactPhone = Console.ReadLine();

            Console.Write("Enter store email: ");
            email = Console.ReadLine();
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}

