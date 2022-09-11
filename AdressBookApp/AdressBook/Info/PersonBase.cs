using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Info
{
    public class PersonBase
    {
        private readonly string _name;
        private readonly string _gender;
        private readonly string _birthday;

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
    }
}
