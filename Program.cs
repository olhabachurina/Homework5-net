using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_net
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Exercise 1:");
            Website myWebsite = new Website();

            
            myWebsite.InputData();

           
            Console.WriteLine("\nWebsite Information:");
            myWebsite.DisplayData();
           
            Console.WriteLine($"\nAccess to individual fields:"); // Доступ к отдельным полям с использованием методов
            Console.WriteLine($"Name of the site: {myWebsite.GetName()}");
            Console.WriteLine($"Path to the site: {myWebsite.GetUrl()}");
            Console.WriteLine($"Description of the site: {myWebsite.GetDescription()}");
            Console.WriteLine($"IP-Website address: {myWebsite.GetIpAddress()}");
            Console.WriteLine("Exercise 2:");
            Jurnal myJournal = new Jurnal();

            myJournal.InputData();
            Console.WriteLine("\nJournal information:");
            myJournal.DisplayData();
            Console.WriteLine("\nAccess to individual fields:");

            Console.WriteLine($"Journal information: {myJournal.GetTitle()}");
            Console.WriteLine($"The year of publishing: {myJournal.GetYear()}");
            Console.WriteLine($"Log description: {myJournal.GetDescription()}");
            Console.WriteLine($"contact number: {myJournal.GetContactPhone()}");
            Console.WriteLine($"Email: {myJournal.GetEmail()}");
            Console.WriteLine("Exercise 3:");
            Shop myShop = new Shop();
            myShop.EnterData();

            Console.WriteLine("Name of shop: " + myShop.GetName());
            Console.WriteLine("Store Address: " + myShop.GetAddress());
            Console.WriteLine("Store profile description: " + myShop.GetDescription());
            Console.WriteLine("Store contact phone number: " + myShop.GetContactPhone());
            Console.WriteLine("Email shop: " + myShop.GetEmail());




        }
    }
}
