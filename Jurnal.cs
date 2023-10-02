using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_net
{
    public class Jurnal
    {
        private string title;
        private int year;
        private string description;
        private string contactPhone;
        private string email;

        public void InputData()
        {
            Console.Write("Enter the title of the magazine: ");
            title = Console.ReadLine();

            Console.Write("Enter the year of publication: ");
            int.TryParse(Console.ReadLine(), out year);

            Console.Write("Enter a description of the journal: ");
            description = Console.ReadLine();

            Console.Write("Enter your contact phone number: ");
            contactPhone = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"\nJournal information:\nMagazine name: {GetTitle()}\nthe year of publication: {GetYear()}\nLog description: {GetDescription()}\ncontact number: {GetContactPhone()}\nEmail: {GetEmail()}");
        }

        public string GetTitle() => title;
        public int GetYear() => year;
        public string GetDescription() => description;
        public string GetContactPhone() => contactPhone;
        public string GetEmail() => email;
    }

}


