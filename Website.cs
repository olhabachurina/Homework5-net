using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_net
{
    public class Website
    {
        private string name;
        private string url;
        private string description;
        public string ipAddress;
        // Метод для ввода данных о веб-сайте
        public void InputData()
        {
            Console.Write("Enter site name: ");
            name = Console.ReadLine();

            Console.Write("Enter the path to the site: ");
            url = Console.ReadLine();

            Console.Write("Enter a site description: ");
            description = Console.ReadLine();

            Console.Write("Enter the site's IP address:: ");
            ipAddress = Console.ReadLine();
        }

        // Метод для вывода данных о веб-сайте
        public void DisplayData()
        {
            Console.WriteLine($"Name of the site: {GetName()}");
            Console.WriteLine($"Path to the site: {GetUrl()}");
            Console.WriteLine($"Description of the site: {GetDescription()}");
            Console.WriteLine($"IP-Website address: {GetIpAddress()}");
        }


        public string GetName() => name;
        public string GetUrl() => url;
        public string GetDescription() => description;
        public string GetIpAddress() => ipAddress;

    }
}