using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ksiazka_Telefoniczna
{
    class Contact
    {
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}
