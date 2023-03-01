using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ksiazka_Telefoniczna
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>(); 

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void RemoveContact(string number)
        {
            var contactToRemove = Contacts.FirstOrDefault(c => c.Number == number);
            if (contactToRemove != null)
            {
                Contacts.Remove(contactToRemove);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        public static string CountNumber(string number)
        {
            Regex regex = new Regex(@"[0-9]");
            bool isMatch = regex.IsMatch(number);
            string[] counts = number.Split(' ');
            string score = "";
            for (int i = 0; i < counts.Length; i++)
            {
                string aktualycounts = counts[i];
                while (aktualycounts.Contains("0-9"))
                {
                    if (aktualycounts.Length == 9)
                    {
                        score = aktualycounts;
                    }
                    else
                    {
                        Console.WriteLine("ERROR BAD VALUE - must contain 9 Numbers");
                    }
                }
            }
            return score;
        }
        public static string CountString(string name)
        {
            string[] letter = name.Split(' ');
            string score = "";
            for (int i = 0; i < letter.Length; i++)
            {
                string aktualyletter = letter[i];
                if (aktualyletter.Length >= 3)
                {
                    score = aktualyletter;
                }
                else
                {
                    Console.WriteLine("ERROR BAD VALUE - must contain 3 characters");
                }
            }
            return score;
        }

        private void DisplayContactDetails(Contact contact) 
        {
            Console.WriteLine($"Contact: {contact.Name},{contact.Surname},{contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayContact(string number) 
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact != null) 
            {
                DisplayContactDetails(contact);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void DisplayAllContact() 
        {
            DisplayContactsDetails(Contacts);
        }
        public void DisplayMatchingContact(string searchPhrase) 
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
