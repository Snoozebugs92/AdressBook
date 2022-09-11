using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Info
{
    public class PersonAddres : PersonBase
    {
        private readonly string _street;
        private readonly string _city;
        private readonly string _state;
        private readonly string _zip;

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
