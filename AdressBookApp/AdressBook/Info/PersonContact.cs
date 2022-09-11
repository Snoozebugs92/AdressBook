using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Info
{
    public class PersonContact : PersonAddres
    {
        private readonly string? _email;
        private readonly string? _phone;
        private readonly string? _workPhone;
        private readonly string? _linkedin;
        private readonly string? _instagram;
        private readonly string? _youtube;

        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorkPhone { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
    }
}
