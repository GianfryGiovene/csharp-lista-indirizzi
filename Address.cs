using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Address
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }


        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            Zip = zip;

        }
        public Address() { }

        public void ShowAddress()
        {
            Console.Write("\n--- Indirizzo ---\nNome {0}\nCognome {1}\nIndirizzo {2}\nCittà {3}\nProvincia {4}\n ZipCode {5}\n--------------");
        }
    }
}
